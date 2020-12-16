using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	[WireDataContract]
	public sealed class SpellFailureData : ITemporallyUniqueSpellDataIdentifiable
	{
		/// <summary>
		/// The packed caster <see cref="ObjectGuid"/>.
		/// </summary>
		[WireMember(1)]
		public PackedGuid Caster { get; internal set; }

		/// <summary>
		/// Represents a unique bit incremented each time a WoW client sends a spell cast request.
		/// This does not reset when switching characters or even logging out.
		/// It could be used in combination with <see cref="ITemporallyUniqueSpellDataIdentifiable.SpellId"/> to build a 64bit-ish temporally unique key for the spell cast.
		/// </summary>
		[WireMember(2)]
		public byte SpellCastCount { get; internal set; }

		/// <summary>
		/// The spell id.
		/// </summary>
		[WireMember(3)]
		public int SpellId { get; internal set; }

		/// <summary>
		/// TODO: What is this, TC always sends 0.
		/// </summary>
		[WireMember(4)]
		public byte Result { get; internal set; }

		public SpellFailureData([NotNull] PackedGuid caster, byte spellCastCount, int spellId, byte result)
		{
			if (spellId <= 0) throw new ArgumentOutOfRangeException(nameof(spellId));
			Caster = caster ?? throw new ArgumentNullException(nameof(caster));
			SpellCastCount = spellCastCount;
			SpellId = spellId;
			Result = result;
		}

		/// <summary>
		/// Serializer ctor.
		/// </summary>
		public SpellFailureData()
		{
			
		}
	}
}
