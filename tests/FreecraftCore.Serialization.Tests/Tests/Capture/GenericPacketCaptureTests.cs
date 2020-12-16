using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using FreecraftCore.Serializer;
using NUnit.Framework;

namespace FreecraftCore
{
	[TestFixture]
	public abstract class GenericPacketCaptureTests<TPacketCaptureBuilder>
		where TPacketCaptureBuilder : PacketCaptureTestCaseCaptureBuilder, new()
	{
		public static SerializerService Serializer { get; protected set; } = new SerializerService();

		public static List<PacketCaptureTestEntry> TestSource { get; } = new TPacketCaptureBuilder()
			.BuildCaptureEntries(new TPacketCaptureBuilder().Expac, Serializer, new TPacketCaptureBuilder().BuildSerializableTypes())
			.ToList();

		protected GenericPacketCaptureTests()
		{
			
		}

		[Test]
		[TestCaseSource(nameof(TestSource))]
		public void Can_Deserialize_Captures_To_GamePacketPayloads(PacketCaptureTestEntry entry)
		{
			Console.WriteLine($"Entry Decompressed/Real Size: {entry.BinaryData.Length} OpCode: {entry.OpCode}");

			//arrange
			SerializerService serializer = Serializer;

			GamePacketPayload payload;

			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			//act
			try
			{
				payload = serializer.Read<GamePacketPayload>(new Span<byte>(entry.BinaryData), 0);
			}
			catch(Exception e)
			{
				Assert.Fail($"Critical failure. Cannot deserialize File: {entry.FileName} FileSize: {entry.BinaryData.Length} \n\n Exception: {e.Message} Stack: {e.StackTrace}");
				return;
			}
			finally
			{
				stopwatch.Stop();
			}

			Console.WriteLine($"Serialization time in ms: {stopwatch.ElapsedMilliseconds}");

			//assert
			Assert.NotNull(payload, $"Resulting capture capture deserialization attempt null for File: {entry.FileName}");
			//We should have deserialized it. We want to make sure the opcode matches
			Assert.AreEqual(entry.OpCode, payload.OperationCode, $"Mismatched {nameof(NetworkOperationCode)} on packet capture File: {entry.FileName}. Expected: {entry.OpCode} Was: {payload.OperationCode}");
		}

		[Test]
		[TestCaseSource(nameof(TestSource))]
		public void Can_Serialize_DeserializedDTO_To_Same_Binary_Representation(PacketCaptureTestEntry entry)
		{
			//arrange
			Console.WriteLine($"Entry Size: {entry.BinaryData.Length} OpCode: {entry.OpCode}");
			SerializerService serializer = Serializer;
			GamePacketPayload payload = serializer.Read<GamePacketPayload>(new Span<byte>(entry.BinaryData), 0);

			//act
			int offset = 0;
			Span<byte> buffer = new Span<byte>(new byte[62000]);

			try
			{
				serializer.Write(payload, buffer, ref offset);
			}
			catch (KnownIncompleteSerializationException e)
			{
				Assert.Warn($"Incomplete serialization implementation for Type: {e.Message}. Message: {e}");
				return;
			}

			//assert
			try
			{
				Assert.AreEqual(entry.BinaryData.Length, offset, $"Mismatched length on OpCode: {entry.OpCode} Type: {payload.GetType().Name}");
			}
			catch(AssertionException e)
			{
				Assert.Fail($"Failed: {e.Message} {PrintFailureBytes(entry.BinaryData, buffer.Slice(0, offset).ToArray())}");
			}
			

			for(int i = 0; i < entry.BinaryData.Length; i++)
				Assert.AreEqual(entry.BinaryData[i], buffer[i], $"Mismatched byte value at Index: {i} on OpCode: {entry.OpCode} Type: {payload.GetType().Name}");
		}

		public static string PrintFailureBytes(byte[] original, byte[] result)
		{
			return $"Original bytes: {original.Aggregate("", (s, b) => $"{s} {b:X}")} Result: {result.Aggregate("", (s, b) => $"{s} {b:X}")}";
		}
	}
}