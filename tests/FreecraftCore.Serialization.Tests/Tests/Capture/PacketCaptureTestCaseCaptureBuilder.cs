﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using FreecraftCore.Serializer;
using NUnit.Framework;

namespace FreecraftCore
{
	public abstract class PacketCaptureTestCaseCaptureBuilder
	{
		public abstract ExpansionType Expac { get; }

		protected PacketCaptureTestCaseCaptureBuilder()
		{
			
		}

		/// <summary>
		/// Implementer should return the types they want to be serializable.
		/// </summary>
		/// <returns></returns>
		public abstract IEnumerable<Type> BuildSerializableTypes();

		public IReadOnlyCollection<PacketCaptureTestEntry> BuildCaptureEntries(ExpansionType expacType, ISerializerService serializer, IEnumerable<Type> typesToRegister)
		{
			List<PacketCaptureTestEntry> testSource = new List<PacketCaptureTestEntry>(500);

			//Do file loading first because it could fail
			//Then we need to populate the input source for the tests.
			string testPath = Path.Combine(TestContext.CurrentContext.TestDirectory, "PacketCaptures", expacType.ToString());

			//Get every folder
			foreach(string dir in Directory.GetDirectories(testPath))
			{
				//Each directory should fit the form of OpCode name
				//Even though the below is a Path with the directory if we pretend it's a file we can easily get the last part of the path
				//which represents the opcode
				NetworkOperationCode code = (NetworkOperationCode)Enum.Parse(typeof(NetworkOperationCode), Path.GetFileNameWithoutExtension(dir));
				string[] files = null;

				try
				{
					files = Directory.GetFiles(Path.Combine(testPath, dir));
				}
				catch(Exception ee)
				{
					throw new InvalidOperationException($"Failed to load File: {Path.Combine(testPath, dir)} Exception: {ee.Message} Stack: {ee.StackTrace}");
				}

				//Now we want to load each capture.
				foreach(var cap in files)
				{
					string filePath = Path.Combine(testPath, dir, cap);
					//Captures should have a guid on the end of them
					Guid guid = Guid.Parse(cap.Split('_').Last());

					try
					{
						byte[] bytes = File.ReadAllBytes(filePath);

						testSource.Add(new PacketCaptureTestEntry(code, bytes, Path.GetFileName(cap)));
					}
					catch(Exception e)
					{
						throw new InvalidOperationException($"Failed to open File: {filePath} Exception: {e.Message}", e);
					}
				}
			}

			typesToRegister
				.ToList()
				.ForEach(t => serializer.RegisterType(t));

			//This is kinda hacky but we compile here for test reasons
			serializer.Compile();

			return testSource;
		}
	}
}