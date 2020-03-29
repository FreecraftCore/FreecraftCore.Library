﻿using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	[WireDataContract]
	public sealed class AmmoInfo
	{
		/// <summary>
		/// The display ID of the ammo being used.
		/// </summary>
		[WireMember(1)]
		public uint AmmoDisplayId { get; }

		[WireMember(2)]
		public uint AmmoInventoryType { get; }

		public AmmoInfo(uint ammoDisplayId, uint ammoInventoryType)
		{
			AmmoDisplayId = ammoDisplayId;
			AmmoInventoryType = ammoInventoryType;
		}

		protected AmmoInfo()
		{
			
		}
	}
}
