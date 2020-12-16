using System;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.CMSG_PLAYER_LOGIN)]
	[ProtocolGrouping(ProtocolCode.Game)] //TODO: Change this protocol to something more specific
	public partial class CharacterLoginRequest : GamePacketPayload
	{
		/// <inheritdoc />
		public override bool isValid { get; } = true; //TODO: When rules/data validation engine is written implement

		[WireMember(1)]
		public ObjectGuid CharacterGuid { get; internal set; }

		public CharacterLoginRequest([NotNull] ObjectGuid characterGuid)
			: this()
		{
			if (characterGuid == null) throw new ArgumentNullException(nameof(characterGuid));

			CharacterGuid = characterGuid;
		}

		public CharacterLoginRequest()
			: base(NetworkOperationCode.CMSG_PLAYER_LOGIN)
		{
			//serializer ctor
		}
	}
}
