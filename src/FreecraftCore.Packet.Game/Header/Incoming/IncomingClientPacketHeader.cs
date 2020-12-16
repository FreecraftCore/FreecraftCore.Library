using System.Runtime.CompilerServices;
using FreecraftCore.Serializer;
using GladNet;
using JetBrains.Annotations;

namespace FreecraftCore
{
	/// <summary>
	/// The header for packets coming into the client.
	/// </summary>
	[DefaultChild(typeof(IncomingClientSmallPacketHeader))] //if it doesn't contain the 0x80 flag it is a small packet
	[WireDataContractBaseType(1, typeof(IncomingClientLargePacketHeader))] //Jackpoz bot shows that if the first byte has a 0x80 flag then it is a big packet
	[WireDataContract(PrimitiveSizeType.Bit)] //Jackpoz shows that first byte indicates length size.
	public abstract partial class IncomingClientPacketHeader : IGamePacketHeader, ISerializationEventListener, IPacketHeader
	{
		/// <inheritdoc />
		public abstract int HeaderSize { get; }

		//Have to add this for GladNet3 compatibility
		/// <inheritdoc />
		public int PacketSize => PayloadSize + HeaderSize;

		/// <inheritdoc />
		public int PayloadSize { get; private set; }

		/// <inheritdoc />
		public abstract NetworkOperationCode OperationCode { get; internal set; }

		protected IncomingClientPacketHeader()
		{

		}

		/// <summary>
		/// Computes the payload size.
		/// </summary>
		/// <returns>Returns an integer size for the payload.</returns>
		[Pure]
		protected abstract int ComputePayloadSize();

		public void OnBeforeSerialization()
		{
			//Don't need to do anything here
		}

		public void OnAfterDeserialization()
		{
			PayloadSize = ComputePayloadSize();
		}

		/// <summary>
		/// Encodes the size variable-length.
		/// The size SHOULD include the 2 byte size of the OpCode. It is not assumed.
		/// Without using that in the size the size will be invalid.
		/// </summary>
		/// <param name="size">The size.</param>
		/// <returns>Variable length encoded size.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte[] EncodePacketSize(int size)
		{
			if(IsLargePacketSize(size))
				return new byte[3] {(byte)(0x80 | (0xFF & (size >> 16))), (byte)(0xFF & (size >> 8)), (byte)(0xFF & size)};
			else
				return new byte[2] { (byte)(0xFF & (size >> 8)), (byte)(0xFF & size) };
		}

		//From trinitycore ServerPktHeader
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool IsLargePacketSize(int size)
		{
			return size > 0x7FFF;
		}

		/// <inheritdoc />
		public abstract bool isValid { get; }
	}
}
