using FreecraftCore.Serializer;

namespace FreecraftCore
{
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.CMSG_CHAR_ENUM)]
	[ProtocolGrouping(ProtocolCode.Game)] //TODO: Change this protocol to something more specific
	public partial class CharacterListRequest : GamePacketPayload
	{
		/// <inheritdoc />
		public override bool isValid { get; } = true; //TODO: When rules/data validation engine is written implement

		public CharacterListRequest()
			: base(NetworkOperationCode.CMSG_CHAR_ENUM)
		{
			//We don't send any data
		}
	}
}
