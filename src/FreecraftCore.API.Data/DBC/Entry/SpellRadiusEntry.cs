using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using FreecraftCore.Serializer;
using Newtonsoft.Json;

namespace FreecraftCore
{
	//Referenced by Spell.dbc
	[DBC]
	[Table("SpellRadius")]
	[JsonObject]
	[WireDataContract]
	public class SpellRadiusEntry : IDBCEntryIdentifiable
	{
		/// <inheritdoc />
		[NotMapped]
		[JsonIgnore]
		public int EntryId => SpellRadiusId;

		[Key]
		[WireMember(1)]
		public int SpellRadiusId { get; internal set; }

		[WireMember(2)]
		public float Radius { get; internal set; }

		[WireMember(3)]
		public int Zero { get; internal set; }

		[WireMember(4)]
		public float Radius2 { get; internal set; }

		/// <inheritdoc />
		public SpellRadiusEntry(int spellRadiusId, float radius, int zero, float radius2)
		{
			SpellRadiusId = spellRadiusId;
			Radius = radius;
			Zero = zero;
			Radius2 = radius2;
		}

		public SpellRadiusEntry()
		{
			
		}
	}
}
