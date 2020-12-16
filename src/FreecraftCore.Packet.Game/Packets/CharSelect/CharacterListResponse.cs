using System;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.SMSG_CHAR_ENUM)]
	[ProtocolGrouping(ProtocolCode.Game)] //TODO: Change this protocol to something more specific
	public partial class CharacterListResponse : GamePacketPayload
	{
		/// <inheritdoc />
		public override bool isValid { get; } = true; //TODO: Implement data validation

		[WireMember(1)]
		[SendSize(PrimitiveSizeType.Byte)] //Jackpoz's bot shows it sends count as byte
		public CharacterScreenCharacter[] Characters { get; internal set; }

		/// <inheritdoc />
		public CharacterListResponse([NotNull] CharacterScreenCharacter[] characters)
			: this()
		{
			Characters = characters ?? throw new ArgumentNullException(nameof(characters));
		}

		public CharacterListResponse()
			: base(NetworkOperationCode.SMSG_CHAR_ENUM)
		{
			//serialization ctor
		}
	}
}
