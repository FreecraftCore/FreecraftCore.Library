using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;

namespace FreecraftCore
{
	class Program
	{
		static async Task Main(string[] args)
		{
			foreach (string filePath in Directory.GetFiles(Directory.GetCurrentDirectory(), "*.cs", SearchOption.AllDirectories))
			{
				List<string> file = (await File.ReadAllLinesAsync(filePath)).ToList();

				bool isFileModified = false;
				int errorCount = 0;

				//Find the a WireMember
				for (int i = 0; i < file.Count; i++)
				{
					if (file[i].Contains("[WireMember"))
					{
						//Now, find the member it's actually tagging
						for (int j = i; j < file.Count; j++)
						{
							//TODO: Support same line.
							//Attributes are done.
							if (file[j].Contains("{ get"))
							{
								string original = file[j];

								file[j] = file[j].Replace("{ get; }", "{ get; internal set; }");

								//All privates should be internal
								file[j] = file[j].Replace("private ", "internal ");
								file[j] = file[j].Replace("protected set", "internal set");
								file[j] = file[j].Replace("{ get; set; }", "{ get; internal set; }");

								//Cover case where it's internal i { get; internal set; }
								if (file[j].Contains("internal set") && file[j].Contains("\tinternal "))
									file[j] = file[j].Replace("internal set", "set");

								if (original != file[j])
								{
									isFileModified = true;
									errorCount++;
								}

								break;
							}
						}
					}

					if (file[i].Contains(": GamePacketPayload") && !file[i].Contains("partial class"))
					{
						file[i] = file[i].Replace("public sealed class", "public sealed partial class");
						file[i] = file[i].Replace("public class", "public partial class");
						isFileModified = true;
					}

					if (IsBasePayloadCtorCallMissing(file, i) && !file.Any(f => f.Contains(": base(")))
					{
						isFileModified = AddBaseConstructorCall(file, i);

						if (isFileModified)
							i++;

						if (file.Count(s => s.Contains("Payload(") || s.Contains("PAYLOAD(")) > 1)
							for (int j = i; j < file.Count; j++)
								if (IsBasePayloadCtorCallMissing(file, j) && (!file[j + 1].Contains("base") || !file[j + 1].Contains("this")))
									if (AddBaseConstructorCall(file, j))
									{
										isFileModified = true;
										j++;
									}
					}
				}

				if (isFileModified)
				{
					Console.WriteLine($"Fixed Errors in {Path.GetFileNameWithoutExtension(filePath)}: {errorCount}");
					await File.WriteAllLinesAsync(filePath, file);
				}
			}
		}

		private static bool IsBasePayloadCtorCallMissing(List<string> file, int i)
		{
			return (file[i].Contains("Payload(") || file[i].Contains("PAYLOAD(")) && file.Any(f => f.Contains("GamePayloadOperationCode"));
		}

		private static bool AddBaseConstructorCall(List<string> file, int i)
		{
			bool isFileModified;
			StringBuilder builder = new StringBuilder();
			for (int j = 0; j < file[i].Count(c => c == '\t') + 1; j++)
				builder.Append('\t');

			string attribute = file.First(s => s.Contains("GamePayloadOperationCode"));
			string opcodeName = attribute.Split('(')
				.Last()
				.Split(')')
				.First();

			//Parameterless
			if (file[i].Contains("Payload()") || file[i].Contains("PAYLOAD()"))
			{
				builder.Append($": base(");
				builder.Append(opcodeName);
				builder.Append(")");
			}
			else
			{
				builder.Append($": this()");
			}

			file.Insert(i + 1, builder.ToString());
			isFileModified = true;
			return isFileModified;
		}
	}
}
