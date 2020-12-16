using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.CMSG_CAST_SPELL)]
	public sealed partial class CMSG_CAST_SPELL_Payload : GamePacketPayload
	{
		[WireMember(1)]
		public byte CastCount { get; internal set; }

		[WireMember(2)]
		public int SpellId { get; internal set; }

		//TODO: Enumerate this, 0x02 seems to be some sort of projectile thingy.
		[WireMember(3)]
		public byte CastFlags { get; internal set; }

		[WireMember(4)]
		public SpellTargetInfo TargetInformation { get; internal set; }

		//TODO: If CastFlags is 0x02 then there is some projectile information and maybe even MovementData.

		public CMSG_CAST_SPELL_Payload(byte castCount, int spellId, SpellTargetInfo targetInformation)
			: this()
		{
			CastCount = castCount;
			SpellId = spellId;
			CastFlags = 0; //TODO: Expose CastFlags for 0x02 projectile stuff.
			TargetInformation = targetInformation;
		}

		/// <summary>
		/// Serializer ctor.
		/// </summary>
		public CMSG_CAST_SPELL_Payload()
			: base(NetworkOperationCode.CMSG_CAST_SPELL)
		{
			
		}
	}
}
