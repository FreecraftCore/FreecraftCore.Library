using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	[WireDataContract]
	public sealed class ItemDamageDefinition
	{
		[WireMember(1)]
		public int DamageMinimum { get; internal set; }

		[WireMember(2)]
		public int DamageMaximum { get; internal set; }

		//TODO: Find/create enum for this
		[WireMember(3)]
		public int ResistId { get; internal set; }

		/// <inheritdoc />
		public ItemDamageDefinition(int damageMinimum, int damageMaximum, int resistId)
		{
			DamageMinimum = damageMinimum;
			DamageMaximum = damageMaximum;
			ResistId = resistId;
		}

		public ItemDamageDefinition()
		{
			
		}
	}
}
