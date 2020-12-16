using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.SMSG_SPELL_START)]
	public sealed partial class SMSG_SPELL_START_Payload : GamePacketPayload
	{
		[WireMember(1)]
		public StartSpellCastData CastData { get; internal set; }

		public SMSG_SPELL_START_Payload([NotNull] StartSpellCastData castData)
			: this()
		{
			CastData = castData ?? throw new ArgumentNullException(nameof(castData));
		}

		public SMSG_SPELL_START_Payload()
			: base(NetworkOperationCode.SMSG_SPELL_START)
		{
			
		}
	}
}
