using System;
using FreecraftCore.Serializer;
using GladNet;

namespace FreecraftCore
{
	[WireDataContract]
	public class OutgoingClientPacketHeader : IGamePacketHeader, IPacketHeader
	{
		//Header only contains 2 byte (short) packet size and 4 byte opcode
		/// <inheritdoc />
		public int HeaderSize { get; } = 6;

		//Client sends a bigendian ushort representation of the
		//Packet size which is 4 bytes (from WoW header) + Payload.Length
		[ReverseData] //makes bigendian
		[WireMember(1)]
		internal ushort SerializedPacketSize { get; set; }

		/// <inheritdoc />
		public int PacketSize => SerializedPacketSize;

		/// <summary>
		/// The operation code of the packet
		/// </summary>
		[WireMember(2)]
		public NetworkOperationCode OperationCode { get; internal set; }

		//This is an unknown chunk of data
		//Trinitycore has the recieval being a 32bit operation code
		//But it's more likely the first 2 bytes are the little endian ordered opcode
		//and these 2 bytes likely represent something different

		[WireMember(3)]
		internal short unknownBytes = 0;

		/// <inheritdoc />
		public int PayloadSize => PacketSize - 4;

		/// <inheritdoc />
		public bool isValid => true;

		/// <summary>
		/// Initializes a new packet header with a PacketSize of <see cref="PayloadSize"/> + 4 bytes.
		/// DO NOT provide the payloadsize with the opcode. Remove the opcode length from the payloadsize
		/// before providing it as a paremeters.
		/// The header 
		/// </summary>
		/// <param name="payloadSize"></param>
		/// <param name="operationCode"></param>
		public OutgoingClientPacketHeader(int payloadSize, NetworkOperationCode operationCode)
		{
			if (!Enum.IsDefined(typeof(NetworkOperationCode), operationCode))
				throw new ArgumentOutOfRangeException(nameof(operationCode), "Value should be defined in the NetworkOperationCode enum.");

			OperationCode = operationCode;
			SerializedPacketSize = (ushort)(payloadSize + 4);
		}

		public OutgoingClientPacketHeader()
		{
				
		}
	}
}
