using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	//Opcode/Packet not sent by 1.12.1
	//Sent during the initial before join map on Trinityocre.
	/// <summary>
	/// Server sends this during pre-map join.
	/// 1.12.1 doesn't send this packet at all.
	/// </summary>
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.SMSG_INSTANCE_DIFFICULTY)]
	public sealed partial class SMSG_INSTANCE_DIFFICULTY_PAYLOAD : GamePacketPayload
	{
		//TODO: Refactory and extract
		//From Trinitycore
		public enum Difficulty : int
		{
			REGULAR_DIFFICULTY = 0,

			DUNGEON_DIFFICULTY_NORMAL = 0,
			DUNGEON_DIFFICULTY_HEROIC = 1,
			DUNGEON_DIFFICULTY_EPIC = 2,

			RAID_DIFFICULTY_10MAN_NORMAL = 0,
			RAID_DIFFICULTY_25MAN_NORMAL = 1,
			RAID_DIFFICULTY_10MAN_HEROIC = 2,
			RAID_DIFFICULTY_25MAN_HEROIC = 3
		}

		/// <summary>
		/// Difficulty of the map.
		/// </summary>
		[WireMember(1)]
		public Difficulty MapDifficulty { get; internal set; } = Difficulty.REGULAR_DIFFICULTY;

		/// <summary>
		/// TODO: What and how does this work?
		/// </summary>
		[WireMember(2)]
		public int MapFlags { get; internal set; } = 0;

		/// <summary>
		/// Creates a normal map.
		/// (For testing purposes. Don't call in prod)
		/// </summary>
		public SMSG_INSTANCE_DIFFICULTY_PAYLOAD()
			: base(NetworkOperationCode.SMSG_INSTANCE_DIFFICULTY)
		{
			
		}
	}
}
