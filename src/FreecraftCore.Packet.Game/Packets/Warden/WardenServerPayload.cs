namespace FreecraftCore
{
	/// <summary>
	/// Base contract for all Warden payloads sent by the server.
	/// Sent with <see cref="NetworkOperationCode.SMSG_WARDEN_DATA"/>.
	/// </summary>
	/*[GamePayloadOperationCode(NetworkOperationCode.SMSG_WARDEN_DATA)]
	[WireDataContract(WireDataContractAttribute.KeyType.Byte, InformationHandlingFlags.DontConsumeRead)] //don't consume type information
	public abstract class WardenServerPayload : GamePacketPayload
	{
		[DontWrite] //don't write; it's from type information
		[WireMember(1)]
		public WardenSubOperationCodeServer SubOperationCode { get; internal set; }

		[ReadToEnd]
		[WireMember(2)]
		public byte[] Data { get; internal set; }

		protected WardenServerPayload()
			: base(NetworkOperationCode.SMSG_WARDEN_DATA)
		{
			
		}
	}*/
}
