using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using FreecraftCore.Serializer;
using Newtonsoft.Json;

namespace FreecraftCore
{
	//Referenced in Spell.dbc as CastingTimeIndex
	[DBC]
	[JsonObject]
	[WireDataContract]
	[Table("SpellCastTimes")]
	public class SpellCastTimesEntry : IDBCEntryIdentifiable
	{
		/// <inheritdoc />
		[JsonIgnore]
		[NotMapped]
		public int EntryId => SpellCastTimeId;

		[Key]
		[WireMember(1)]
		public int SpellCastTimeId { get; internal set; }

		[WireMember(2)]
		public uint CastTime { get; internal set; }

		//No spell in TC Spell_Dbc table actually references a an index that has
		//a value other than 0 in this. This is probably not a float nor useful.
		//Maybe it meant something in pre-3.3.5?
		//TODO: Conflicting Spellwork/TC/WoWDevWiki information on if this is float or uint
		[WireMember(3)]
		public int CastTimePerLevel { get; internal set; }

		[WireMember(4)]
		public uint MinCastTime { get; internal set; }

		/// <inheritdoc />
		public SpellCastTimesEntry(int spellCastTimeId, uint castTime, int castTimePerLevel, uint minCastTime)
		{
			if(spellCastTimeId < 0) throw new ArgumentOutOfRangeException(nameof(spellCastTimeId));

			SpellCastTimeId = spellCastTimeId;
			CastTime = castTime;
			CastTimePerLevel = castTimePerLevel;
			MinCastTime = minCastTime;
		}

		/// <summary>
		/// Serializer ctor
		/// </summary>
		public SpellCastTimesEntry()
		{
			
		}
	}

}
