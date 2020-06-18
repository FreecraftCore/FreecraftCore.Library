﻿using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	/// <summary>
	/// Packet sent when a transfer from one map to another map take place.
	/// </summary>
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.SMSG_TRANSFER_PENDING)]
	public sealed class SMSG_TRANSFER_PENDING_Payload : GamePacketPayload
	{
		[WireMember(1)]
		public int MapId { get; internal set; }
		
		//There is also a position here if we're on a transport.

		public SMSG_TRANSFER_PENDING_Payload(int mapId)
		{
			//Blizzlike has map ID 0.
			if (mapId < 0) throw new ArgumentOutOfRangeException(nameof(mapId));

			MapId = mapId;
		}

		/// <summary>
		/// Serializer ctor.
		/// </summary>
		internal SMSG_TRANSFER_PENDING_Payload()
		{

		}
	}
}