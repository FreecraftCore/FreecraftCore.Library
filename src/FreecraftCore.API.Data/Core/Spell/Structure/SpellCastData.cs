using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	[WireDataContract]
	public class SpellCastData : ITemporallyUniqueSpellDataIdentifiable
	{
		//TODO: Are these named right??
		[WireMember(1)]
		public PackedGuid SpellSource { get; internal set; }

		[WireMember(2)]
		public PackedGuid SpellTarget { get; internal set; }

		/// <summary>
		/// Represents a unique bit incremented each time a WoW client sends a spell cast request.
		/// This does not reset when switching characters or even logging out.
		/// It could be used in combination with <see cref="SpellId"/> to build a 64bit-ish temporally unique key for the spell cast.
		/// </summary>
		[WireMember(3)]
		public byte SpellCastCount { get; internal set; }

		[WireMember(4)]
		public int SpellId { get; internal set; }

		[WireMember(5)]
		public SpellCastFlag CastFlags { get; internal set; }

		/// <summary>
		/// The time since the server started.
		/// </summary>
		[WireMember(6)]
		public uint TimeDiff { get; internal set; }

		[NotMapped]
		public virtual bool HasHitInformation { get; } = true;

		//Spell targets written now.
		//Targets are sent byte prefixed
		//Both a miss and hit block
		[Optional(nameof(HasHitInformation))]
		[SendSize(PrimitiveSizeType.Byte)]
		[WireMember(7)]
		public ObjectGuid[] HitTargets { get; internal set; }

		[Optional(nameof(HasHitInformation))]
		[SendSize(PrimitiveSizeType.Byte)]
		[WireMember(8)]
		public SpellMissInfo[] SpellMisses { get; internal set; }

		[WireMember(9)]
		public SpellTargetInfo TargetInfo { get; internal set; }

		//TODO: Implement CAST_FLAG_RUNE_LIST for DK stuff
		//Now this is some data optional
		//to the cast flags

		public bool HasPowerInformation => CastFlags.HasFlag(SpellCastFlag.CAST_FLAG_POWER_LEFT_SELF);

		public bool HasAdjustableMissle => CastFlags.HasFlag(SpellCastFlag.CAST_FLAG_ADJUST_MISSILE);

		public bool HasAmmo => CastFlags.HasFlag(SpellCastFlag.CAST_FLAG_AMMO);

		public bool HasVisualChainData => CastFlags.HasFlag(SpellCastFlag.CAST_FLAG_VISUAL_CHAIN);

		public bool HasTargetUnknownByte => TargetInfo != null && TargetInfo.HasTransportDestinationLocation;

		[Optional(nameof(HasPowerInformation))]
		[WireMember(10)]
		public int PowerValue { get; internal set; }

		[Optional(nameof(HasAdjustableMissle))]
		[WireMember(11)]
		public AdjustableSpellMissleInfo OptionalAdjustableMissle { get; internal set; }

		[Optional(nameof(HasAmmo))]
		[WireMember(12)]
		public AmmoInfo AmunitionInformation { get; internal set; }

		//TODO: What is this?
		[Optional(nameof(HasVisualChainData))]
		[WireMember(13)]
		public ulong OptionalVisualChainData { get; internal set; }

		[Optional(nameof(HasTargetUnknownByte))]
		[WireMember(14)]
		public byte UnkownTargetDestByte { get; internal set; } = 0; //TC always uses 0

		public SpellCastData(PackedGuid spellSource, PackedGuid spellTarget, byte spellCastCount, int spellId, SpellCastFlag castFlags, uint timeDiff, ObjectGuid[] hitTargets, SpellMissInfo[] spellMisses, SpellTargetInfo targetInfo, int powerValue, AdjustableSpellMissleInfo optionalAdjustableMissle, AmmoInfo amunitionInformation, ulong optionalVisualChainData)
		{
			SpellSource = spellSource;
			SpellTarget = spellTarget;
			SpellCastCount = spellCastCount;
			SpellId = spellId;
			CastFlags = castFlags;
			TimeDiff = timeDiff;
			HitTargets = hitTargets;
			SpellMisses = spellMisses;
			TargetInfo = targetInfo;
			PowerValue = powerValue;
			OptionalAdjustableMissle = optionalAdjustableMissle;
			AmunitionInformation = amunitionInformation;
			OptionalVisualChainData = optionalVisualChainData;
		}

		/// <summary>
		/// Serializer ctor.
		/// </summary>
		public SpellCastData()
		{
			
		}
	}
}
