using FreecraftCore.Serializer;

namespace FreecraftCore
{
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.CMSG_PING)]
	public sealed partial class PingRequest : GamePacketPayload
	{
		/// <inheritdoc />
		public override bool isValid => true;

		[WireMember(1)]
		public uint Ping { get; internal set; }

		[WireMember(2)]
		public uint Latency { get; internal set; }

		public PingRequest(uint ping, uint latency)
			: this()
		{
			Ping = ping;
			Latency = latency;
		}

		/// <summary>
		/// Serializer ctor.
		/// </summary>
		public PingRequest()
			: base(NetworkOperationCode.CMSG_PING)
		{
			
		}
	}
}
