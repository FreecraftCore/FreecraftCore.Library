using System;
using System.Collections.Generic;
using System.Text;
using JetBrains.Annotations;

namespace FreecraftCore
{
	public static class MovementPacketExtensions
	{
		/// <summary>
		/// Indicates if the packet is a <see cref="IPlayerMovementPayload{TMoveInfoType,TMoveFlagsType,TGUIDType}"/> packet.
		/// </summary>
		/// <param name="payload"></param>
		/// <returns></returns>
		public static bool IsMovementPacket([NotNull] this GamePacketPayload payload)
		{
			if (payload == null) throw new ArgumentNullException(nameof(payload));

			switch (payload.OperationCode)
			{
				case NetworkOperationCode.CMSG_MOVE_FALL_RESET:
				case NetworkOperationCode.CMSG_MOVE_SET_FLY:
				case NetworkOperationCode.MSG_MOVE_FALL_LAND:
				case NetworkOperationCode.MSG_MOVE_HEARTBEAT:
				case NetworkOperationCode.MSG_MOVE_JUMP:
				case NetworkOperationCode.MSG_MOVE_SET_FACING:
				case NetworkOperationCode.MSG_MOVE_SET_PITCH:
				case NetworkOperationCode.MSG_MOVE_SET_RUN_MODE:
				case NetworkOperationCode.MSG_MOVE_SET_WALK_MODE:
				case NetworkOperationCode.MSG_MOVE_START_ASCEND:
				case NetworkOperationCode.MSG_MOVE_START_BACKWARD:
				case NetworkOperationCode.MSG_MOVE_START_DESCEND:
				case NetworkOperationCode.MSG_MOVE_START_FORWARD:
				case NetworkOperationCode.MSG_MOVE_START_PITCH_DOWN:
				case NetworkOperationCode.MSG_MOVE_START_PITCH_UP:
				case NetworkOperationCode.MSG_MOVE_START_STRAFE_LEFT:
				case NetworkOperationCode.MSG_MOVE_START_STRAFE_RIGHT:
				case NetworkOperationCode.MSG_MOVE_START_SWIM:
				case NetworkOperationCode.MSG_MOVE_START_TURN_LEFT:
				case NetworkOperationCode.MSG_MOVE_START_TURN_RIGHT:
				case NetworkOperationCode.MSG_MOVE_STOP_ASCEND:
				case NetworkOperationCode.MSG_MOVE_STOP:
				case NetworkOperationCode.MSG_MOVE_STOP_STRAFE:
				case NetworkOperationCode.MSG_MOVE_STOP_SWIM:
				case NetworkOperationCode.MSG_MOVE_STOP_TURN:
					return true;
				default:
					return false;
			}
		}
	}
}
