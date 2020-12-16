using FreecraftCore.Serializer;

namespace FreecraftCore
{
	/// <summary>
	/// Response to a <see cref="NetworkOperationCode.CMSG_PING"/>.
	/// </summary>
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.SMSG_PONG)]
	public sealed partial class PongResponse : GamePacketPayload
	{
		/// <inheritdoc />
		public override bool isValid => true;

		[WireMember(1)]
		public uint Ping { get; internal set; }

		public PongResponse(uint ping)
			: this()
		{
			Ping = ping;
		}

		public PongResponse()
			: base(NetworkOperationCode.SMSG_PONG)
		{
			
		}
	}
}
