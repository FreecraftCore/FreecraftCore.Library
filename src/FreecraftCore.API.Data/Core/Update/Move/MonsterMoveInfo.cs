using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	[WireDataContract]
	public sealed class MonsterMoveInfo
	{
		/// <summary>
		/// The movement type.
		/// </summary>
		[WireMember(1)]
		public MonsterMoveType MoveType { get; internal set; }

		public bool HasFinalOrientation => MoveType == MonsterMoveType.MonsterMoveFacingAngle;
		public bool HasFinalTarget => MoveType == MonsterMoveType.MonsterMoveFacingTarget;
		public bool HasFinalPoint => MoveType == MonsterMoveType.MonsterMoveFacingSpot;

		/// <summary>
		/// Optional: Exists if <see cref="MonsterMoveType.MonsterMoveFacingTarget"/> is set.
		/// </summary>
		[Optional(nameof(HasFinalTarget))]
		[WireMember(2)]
		public ObjectGuid FinalTarget { get; internal set; }

		/// <summary>
		/// Optional: Exists if <see cref="MonsterMoveType.MonsterMoveFacingAngle"/> is set.
		/// </summary>
		[Optional(nameof(HasFinalOrientation))]
		[WireMember(3)]
		public float FinalOrientation { get; internal set; }

		/// <summary>
		/// Optional: Exists if <see cref="MonsterMoveType.MonsterMoveFacingSpot"/> is set.
		/// </summary>
		[Optional(nameof(HasFinalPoint))]
		[WireMember(4)]
		public Vector3<float> FinalPoint { get; internal set; }

		//TODO: Add valid ctors.
		/// <inheritdoc />
		public MonsterMoveInfo(MonsterMoveType moveType, ObjectGuid finalTarget, float finalOrientation, Vector3<float> finalPoint)
		{
			MoveType = moveType;
			FinalTarget = finalTarget;
			FinalOrientation = finalOrientation;
			FinalPoint = finalPoint;
		}

		/// <summary>
		/// Serializer ctor.
		/// </summary>
		public MonsterMoveInfo()
		{
			
		}
	}
}
