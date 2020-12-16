using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.MSG_SET_DUNGEON_DIFFICULTY)]
	public sealed partial class MSG_SET_DUNGEON_DIFFICULTY : GamePacketPayload
	{
		[WireMember(1)]
		public SMSG_INSTANCE_DIFFICULTY_PAYLOAD.Difficulty DungeonDifficulty { get; internal set; } = SMSG_INSTANCE_DIFFICULTY_PAYLOAD.Difficulty.REGULAR_DIFFICULTY;

		/// <summary>
		/// Unknown. TC sets this to 0x00000001.
		/// </summary>
		[WireMember(2)]
		public int Unk { get; internal set; } = 0x00000001;

		[WireMember(3)]
		internal int InGroupSerializedField { get; set; } = 0;

		/// <summary>
		/// Indicates if in a group.
		/// </summary>
		public bool InGroup => InGroupSerializedField != 0;

		//TODO: Real ctor

		/// <summary>
		/// Creates a default/test message instance.
		/// </summary>
		public MSG_SET_DUNGEON_DIFFICULTY()
			: base(NetworkOperationCode.MSG_SET_DUNGEON_DIFFICULTY)
		{
			
		}
	}
}
