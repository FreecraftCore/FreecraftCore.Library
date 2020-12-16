using FreecraftCore.Serializer;

namespace FreecraftCore
{
	/// <summary>
	/// Base contract for all Warden payloads sent by the server.
	/// Sent with <see cref="NetworkOperationCode.SMSG_WARDEN_DATA"/>.
	/// </summary>
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.SMSG_WARDEN_DATA)]
	public partial class WardenDataEvent : GamePacketPayload
	{
		[ReadToEnd]
		[WireMember(1)]
		public byte[] Data { get; internal set; }

		/// <inheritdoc />
		public override bool isValid => true;

		public WardenDataEvent()
			: base(NetworkOperationCode.SMSG_WARDEN_DATA)
		{
			
		}
	}
}
