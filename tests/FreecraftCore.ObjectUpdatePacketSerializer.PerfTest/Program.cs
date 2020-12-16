using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using FreecraftCore.Serializer;
using Ionic.Zlib;
using Reinterpret.Net;

namespace FreecraftCore.ObjectUpdatePacketSerializer.PerfTest
{
	class Program
	{
		static void Main(string[] args)
		{
			foreach(var t in TestSource)
				Can_Deserialize_Captures_To_GamePacketPayloads(t);

			Console.ReadKey();
		}

		public static SerializerService Serializer { get; }

		public static List<PacketCaptureTestEntry> TestSource { get; } = new List<PacketCaptureTestEntry>(500);

		static Program()
		{
			try
			{
				//Do file loading first because it could fail
				//Then we need to populate the input source for the tests.
				string testPath = Path.Combine(Directory.GetCurrentDirectory(), "PacketCaptures");

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

							TestSource.Add(new PacketCaptureTestEntry(code, bytes, cap));
						}
						catch(Exception e)
						{
							throw new InvalidOperationException($"Failed to open File: {filePath} Exception: {e.Message}", e);
						}
					}

					Serializer = new SerializerService();
				}
			}
			catch(Exception e)
			{
				string message = $"{e.Message} {e.StackTrace}";
				Console.WriteLine();
				throw new InvalidOperationException(message, e);
			}
		}

		public static void Can_Deserialize_Captures_To_GamePacketPayloads(PacketCaptureTestEntry entry)
		{
			Console.WriteLine($"Entry Size: {entry.BinaryData.Length} OpCode: {entry.OpCode}");

			//TODO: Test compression another time.
			if(entry.OpCode == NetworkOperationCode.SMSG_COMPRESSED_UPDATE_OBJECT)
			{
				//Skip the opcode
				int decompressedSize = entry.BinaryData.Reinterpret<int>(2);
				byte[] newBytes = new byte[decompressedSize + 2]; // +2 for opcode

				ZlibCodec stream = new ZlibCodec(CompressionMode.Decompress)
				{
					InputBuffer = entry.BinaryData,
					NextIn = 2 + 4, //opcode + size
					AvailableBytesIn = entry.BinaryData.Length,
					OutputBuffer = newBytes,
					NextOut = 2,
					AvailableBytesOut = decompressedSize
				};

				stream.Inflate(FlushType.None);
				stream.Inflate(FlushType.Finish);
				stream.EndInflate();

				((short)(NetworkOperationCode.SMSG_UPDATE_OBJECT)).Reinterpret(newBytes, 0);

				entry = new PacketCaptureTestEntry(NetworkOperationCode.SMSG_UPDATE_OBJECT, newBytes, entry.FileName);
			}

			//arrange
			SerializerService serializer = Serializer;

			GamePacketPayload payload;

			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			//act
			try
			{
				payload = serializer.Deserialize<GamePacketPayload>(entry.BinaryData);
			}
			catch(Exception e)
			{
				Console.WriteLine($"Critical failure. Cannot deserialize File: {entry.FileName} FileSize: {entry.BinaryData.Length} \n\n Exception: {e.Message} Stack: {e.StackTrace}");
				return;
			}
			finally
			{
				stopwatch.Stop();
			}

			Console.WriteLine($"Serialization time in ms: {stopwatch.ElapsedMilliseconds}");

			foreach(ObjectUpdateBlock block in ((IObjectUpdatePayload)payload).UpdateBlocks.Items)
			{
				Console.WriteLine($"Encountered: {block.GetType().Name} Block Type: {block.UpdateType}");
			}


			//assert
			if(payload == null)
				Console.WriteLine($"Resulting capture capture deserialization attempt null for File: {entry.FileName}");

			//We should have deserialized it. We want to make sure the opcode matches
			if(entry.OpCode != payload.OperationCode)
			Console.WriteLine($"Mismatched {nameof(NetworkOperationCode)} on packet capture File: {entry.FileName}. Expected: {entry.OpCode} Was: {payload.OperationCode}");
		}

		public class PacketCaptureTestEntry
		{
			public NetworkOperationCode OpCode { get; }

			public byte[] BinaryData { get; }

			public string FileName { get; }

			/// <inheritdoc />
			public PacketCaptureTestEntry(NetworkOperationCode opCode, byte[] binaryData, string fileName)
			{
				OpCode = opCode;
				BinaryData = binaryData;
				FileName = fileName;
			}

			/// <inheritdoc />
			public override string ToString()
			{
				return FileName;
			}

			/// <inheritdoc />
			public override int GetHashCode()
			{
				return FileName.GetHashCode();
			}
		}
	}
}
