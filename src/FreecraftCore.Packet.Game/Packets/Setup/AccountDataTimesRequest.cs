using FreecraftCore.Serializer;

namespace FreecraftCore
{
	/// <summary>
	/// Sent by the connecting user during the character list.
	/// Sent with <see cref="NetworkOperationCode.CMSG_READY_FOR_ACCOUNT_DATA_TIMES"/>.
	/// </summary>
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.CMSG_READY_FOR_ACCOUNT_DATA_TIMES)]
	public sealed partial class AccountDataTimesRequest : GamePacketPayload
	{
		/// <inheritdoc />
		public override bool isValid => true;

		[ReadToEnd]
		[WireMember(1)]
		public byte[] Data { get; internal set; }

		public AccountDataTimesRequest()
			: base(NetworkOperationCode.CMSG_READY_FOR_ACCOUNT_DATA_TIMES)
		{
			
		}
	}
}
