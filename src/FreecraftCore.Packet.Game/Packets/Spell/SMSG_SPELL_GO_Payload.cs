using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.SMSG_SPELL_GO)]
	public sealed partial class SMSG_SPELL_GO_Payload : GamePacketPayload
	{
		[WireMember(1)]
		public SpellCastData CastData { get; internal set; }

		public SMSG_SPELL_GO_Payload([NotNull] SpellCastData castData)
			: this()
		{
			CastData = castData ?? throw new ArgumentNullException(nameof(castData));
		}

		public SMSG_SPELL_GO_Payload()
			: base(NetworkOperationCode.SMSG_SPELL_GO)
		{
			
		}
	}
}
