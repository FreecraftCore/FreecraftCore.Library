using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	[WireDataContract]
	public sealed class StartSpellCastData : SpellCastData
	{
		public override bool HasHitInformation => false;

		public StartSpellCastData(PackedGuid spellSource, PackedGuid spellTarget, byte spellCastCount, int spellId, SpellCastFlag castFlags, uint timeDiff, ObjectGuid[] hitTargets, SpellMissInfo[] spellMisses, SpellTargetInfo targetInfo, int powerValue, AdjustableSpellMissleInfo optionalAdjustableMissle, AmmoInfo amunitionInformation, ulong optionalVisualChainData)
			: base(spellSource, spellTarget, spellCastCount, spellId, castFlags, timeDiff, hitTargets, spellMisses, targetInfo, powerValue, optionalAdjustableMissle, amunitionInformation, optionalVisualChainData)
		{

		}

		/// <summary>
		/// Serializer ctor.
		/// </summary>
		public StartSpellCastData()
		{
			
		}
	}
}
