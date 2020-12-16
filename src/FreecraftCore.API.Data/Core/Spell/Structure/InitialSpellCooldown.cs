using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	[WireDataContract]
	public sealed class InitialSpellCooldown<TSpellIdType>
		where TSpellIdType : struct
	{
		[WireMember(1)]
		public TSpellIdType SpellId { get; internal set; }

		[WireMember(2)]
		public short ItemId { get; internal set; }

		[WireMember(3)]
		public short CategoryId { get; internal set; }

		[WireMember(4)]
		public uint SpellCooldown { get; internal set; }

		[WireMember(5)]
		public uint CategoryCooldown { get; internal set; }

		public bool IsInfiteCooldown => SpellCooldown == 1 && CategoryCooldown == 0x80000000;

		/// <inheritdoc />
		public InitialSpellCooldown(TSpellIdType spellId, short itemId, short categoryId, uint spellCooldown, uint categoryCooldown)
		{
			SpellId = spellId;
			ItemId = itemId;
			CategoryId = categoryId;
			SpellCooldown = spellCooldown;
			CategoryCooldown = categoryCooldown;
		}

		public InitialSpellCooldown()
		{

		}
	}
}
