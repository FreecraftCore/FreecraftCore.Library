using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	[WireDataContract]
	public sealed class StatInfo
	{
		[WireMember(1)]
		public ItemModType StatType { get; internal set; }

		public int StatValue { get; }

		/// <inheritdoc />
		public StatInfo(ItemModType statType, int statValue)
		{
			if(!Enum.IsDefined(typeof(ItemModType), statType)) throw new InvalidEnumArgumentException(nameof(statType), (int)statType, typeof(ItemModType));

			StatType = statType;
			StatValue = statValue;
		}

		/// <summary>
		/// Serializer ctor.
		/// </summary>
		public StatInfo()
		{
			
		}
	}
}
