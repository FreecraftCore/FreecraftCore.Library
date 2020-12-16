using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.SMSG_MONSTER_MOVE)]
	public sealed partial class SMSG_MONSTER_MOVE_Payload : GamePacketPayload
	{
		[WireMember(1)]
		public PackedGuid MonsterGuid { get; internal set; }

		[WireMember(2)]
		public byte Unk1 { get; internal set; } //TC says: sets/unsets MOVEMENTFLAG2_UNK7 (0x40)

		/// <summary>
		/// The initial point of the spline.
		/// </summary>
		[WireMember(3)]
		public Vector3<float> InitialMovePoint { get; internal set; }

		/// <summary>
		/// The id of the spline.
		/// </summary>
		[WireMember(4)]
		public int SplineId { get; internal set; }

		/// <summary>
		/// The movement information for the monster.
		/// If the <see cref="MonsterMoveType"/> is set to <see cref="MonsterMoveType.MonsterMoveStop"/>
		/// is set then it will NOT contain any information after the byte enum.
		/// The rest of the packet will be empty.
		/// </summary>
		[WireMember(5)]
		public MonsterMoveInfo MoveInfo { get; internal set; }

		/// <summary>
		/// Some "Move" packets are stop moves.
		/// This is will be true when it's a move packet and when it's a stop packet
		/// then it will be false. Stop packets do not have the last half of the packet included
		/// at all.
		/// </summary>
		public bool IsMovePacket => MoveInfo.MoveType != MonsterMoveType.MonsterMoveStop;

		/// <summary>
		/// Optional spline data sent if <see cref="IsMovePacket"/> is true.
		/// Meaning the monster state isn't <see cref="MonsterMoveType.MonsterMoveStop"/>.
		/// </summary>
		[Optional(nameof(IsMovePacket))]
		[WireMember(6)]
		public MonsterSplineInfo OptionalSplineInformation { get; internal set; }

		//TODO: Additional ctors
		//TODO: Validate parameters.
		/// <inheritdoc />
		public SMSG_MONSTER_MOVE_Payload(PackedGuid monsterGuid, byte unk1, Vector3<float> initialMovePoint, int splineId, MonsterMoveInfo moveInfo, MonsterSplineInfo optionalSplineInformation)
			: this()
		{
			MonsterGuid = monsterGuid;
			Unk1 = unk1;
			InitialMovePoint = initialMovePoint;
			SplineId = splineId;
			MoveInfo = moveInfo;
			OptionalSplineInformation = optionalSplineInformation;
		}

		/// <inheritdoc />
		public SMSG_MONSTER_MOVE_Payload()
			: base(NetworkOperationCode.SMSG_MONSTER_MOVE)
		{

		}
	}
}
