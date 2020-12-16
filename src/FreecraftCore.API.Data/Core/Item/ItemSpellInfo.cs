using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	[WireDataContract]
	public sealed class ItemSpellInfo
	{
		[WireMember(1)]
		public int SpellId { get; internal set; }

		[WireMember(2)]
		public int SpellTrigger { get; internal set; }

		//TODO: Why does TC set this negative?
		[WireMember(3)]
		public uint SpellCharges { get; internal set; }

		[WireMember(4)]
		public uint SpellCooldown { get; internal set; }

		[WireMember(5)]
		public uint SpellCategory { get; internal set; }

		[WireMember(6)]
		public uint SpellCategoryCooldown { get; internal set; }

		/// <inheritdoc />
		public ItemSpellInfo(int spellId, int spellTrigger, uint spellCharges, uint spellCooldown, uint spellCategory, uint spellCategoryCooldown)
		{
			SpellId = spellId;
			SpellTrigger = spellTrigger;
			SpellCharges = spellCharges;
			SpellCooldown = spellCooldown;
			SpellCategory = spellCategory;
			SpellCategoryCooldown = spellCategoryCooldown;
		}

		public ItemSpellInfo()
		{
			
		}
	}
}
