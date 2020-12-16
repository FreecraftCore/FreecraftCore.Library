using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	//Not sent by 1.12.1 servers
	/// <summary>
	/// Some sort of weird dance studio packet or something?
	/// It is sent when a player is logging into the world.
	/// </summary>
	[GamePayloadOperationCode(NetworkOperationCode.SMSG_LEARNED_DANCE_MOVES)]
	[WireDataContract]
	public sealed partial class SMSG_LEARNED_DANCE_MOVES_PAYLOAD : GamePacketPayload
	{
		//TODO: What is this? Was this ever used...?
		[WireMember(1)]
		public int Unk1 { get; internal set; } = 0;

		[WireMember(2)]
		public int Unk2 { get; internal set; } = 0;

		/// <summary>
		/// Defualt ctor. Sets all to 0.
		/// Sent by Trinitycore with those values.
		/// </summary>
		public SMSG_LEARNED_DANCE_MOVES_PAYLOAD()
			: base(NetworkOperationCode.SMSG_LEARNED_DANCE_MOVES)
		{
			
		}
	}
}
