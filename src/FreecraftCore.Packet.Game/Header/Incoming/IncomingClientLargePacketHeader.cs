using System;
using System.Runtime.CompilerServices;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	/// <summary>
	/// Large packet header.
	/// </summary>
	[WireDataContract]
	public partial class IncomingClientLargePacketHeader : IncomingClientPacketHeader
	{
		//[a][bb]
		//See: https://github.com/FreecraftCore/FreecraftCore/blob/master/docs/WorldHeader.md
		[KnownSize(3)]
		[WireMember(1)]
		internal byte[] encodedSizeBytes;

		//[cc]
		//See: https://github.com/FreecraftCore/FreecraftCore/blob/master/docs/WorldHeader.md
		/// <inheritdoc />
		[WireMember(2)] //after the 3 bytes of encoded size
		public override NetworkOperationCode OperationCode { get; internal set; }

		//Should be the size of the encoded size in bytes (3) and the OpCode (2)
		/// <inheritdoc />
		public override int HeaderSize { get; } = 3 + sizeof(NetworkOperationCode);

		/// <inheritdoc />
		protected override int ComputePayloadSize()
		{
			if (encodedSizeBytes == null)
				throw new InvalidOperationException($"{nameof(IncomingClientLargePacketHeader)} did not contain any encoded bytes.");

			//See: https://github.com/FreecraftCore/FreecraftCore/blob/master/docs/WorldHeader.md
			return DecodePayloadSize(encodedSizeBytes);
		}

		/// <summary>
		/// Decodes the 3 byte array for size
		/// </summary>
		/// <param name="bytes"></param>
		/// <returns></returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int DecodePayloadSize(byte[] bytes)
		{
			return DecodePacketSize(bytes) - sizeof(NetworkOperationCode);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int DecodePacketSize(byte[] bytes)
		{
			return (int)(((((uint)bytes[0]) & 0x7F) << 16) | (((uint)bytes[1]) << 8) | bytes[2]);
		}

		/// <summary>
		/// Decodes the 3 byte array for size.
		/// The first byte being seperated as it what was decided what packet
		/// type to use.
		/// </summary>
		/// <param name="firstByte"></param>
		/// <param name="followingBytes"></param>
		/// <returns></returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int DecodePayloadSize(byte firstByte, byte[] followingBytes)
		{
			//We assume correct parameters for performance sake.
			return DecodePacketSize(firstByte, followingBytes) - sizeof(NetworkOperationCode);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int DecodePacketSize(byte firstByte, byte[] followingBytes)
		{
			//(int)(((((uint)data[0]) & 0x7F) << 16) | (((uint)data[1]) << 8) | data[2])
			return (int)(((((uint)firstByte) & 0x7F) << 16) | (((uint)followingBytes[0]) << 8) | followingBytes[1]);
		}

		//Just check the validity of the encoded size bytes.
		/// <inheritdoc />
		public override bool isValid => encodedSizeBytes != null && encodedSizeBytes.Length == HeaderSize;

		public IncomingClientLargePacketHeader()
		{
			
		}

		
	}
}
