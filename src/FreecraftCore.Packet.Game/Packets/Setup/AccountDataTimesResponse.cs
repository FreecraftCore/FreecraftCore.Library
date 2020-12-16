using FreecraftCore.Serializer;

namespace FreecraftCore
{
	/// <summary>
	/// Sent to the connecting during character list
	/// in response to <see cref="NetworkOperationCode.CMSG_READY_FOR_ACCOUNT_DATA_TIMES"/>.
	/// Sent with <see cref="NetworkOperationCode.SMSG_ACCOUNT_DATA_TIMES"/>.
	/// </summary>
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.SMSG_ACCOUNT_DATA_TIMES)]
	public sealed partial class AccountDataTimesResponse : GamePacketPayload
	{
		/// <inheritdoc />
		public override bool isValid => true;

		[ReadToEnd]
		[WireMember(1)]
		public byte[] Data { get; internal set; }

		public AccountDataTimesResponse()
			: base(NetworkOperationCode.SMSG_ACCOUNT_DATA_TIMES)
		{
			
		}
	}
}
