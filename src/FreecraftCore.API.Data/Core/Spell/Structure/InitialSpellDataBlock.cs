using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	[WireDataContract]
	public sealed class InitialSpellDataBlock<TSpellType>
		where TSpellType : struct
	{
		//TODO:W hat is this?
		//TC always sets this to 0.
		/// <summary>
		/// UNK
		/// </summary>
		[WireMember(1)]
		public byte UnkByte { get; internal set; } = 0;

		//TODO: Hide behind readonly collection.
		//TC sends this as a short prefixed array
		/// <summary>
		/// Array of spell ids sent as the inital spells
		/// </summary>
		[SendSize(PrimitiveSizeType.UInt16)]
		[WireMember(2)]
		public InitialSpellData<TSpellType>[] SpellIds { get; internal set; }

		/// <summary>
		/// Spell cooldowns.
		/// </summary>
		[SendSize(PrimitiveSizeType.UInt16)]
		[WireMember(3)]
		public InitialSpellCooldown<TSpellType>[] SpellCooldowns { get; internal set; }

		//TODO: Can cooldown be null?
		/// <inheritdoc />
		public InitialSpellDataBlock([NotNull] InitialSpellData<TSpellType>[] spellIds, InitialSpellCooldown<TSpellType>[] spellCooldowns)
		{
			SpellIds = spellIds ?? throw new ArgumentNullException(nameof(spellIds));
			SpellCooldowns = spellCooldowns;
		}

		public InitialSpellDataBlock([NotNull] InitialSpellData<TSpellType>[] spellIds)
		{
			SpellIds = spellIds ?? throw new ArgumentNullException(nameof(spellIds));
			SpellCooldowns = Array.Empty<InitialSpellCooldown<TSpellType>>();
		}

		public InitialSpellDataBlock()
		{
			
		}
	}
}
