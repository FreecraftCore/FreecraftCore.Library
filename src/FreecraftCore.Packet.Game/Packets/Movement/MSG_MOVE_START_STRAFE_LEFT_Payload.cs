using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.MSG_MOVE_START_STRAFE_LEFT)]
	public sealed partial class MSG_MOVE_START_STRAFE_LEFT_Payload : GamePacketPayload, IPlayerMovementPayload<MovementInfo, MovementFlag, PackedGuid>
	{
		//Not optional, always sent in 3.3.5
		/// <inheritdoc />
		[WireMember(1)]
		public PackedGuid MovementGuid { get; internal set; }

		/// <summary>
		/// The movement information.
		/// </summary>
		[WireMember(2)]
		public MovementInfo MoveInfo { get; internal set; }

		public MSG_MOVE_START_STRAFE_LEFT_Payload([NotNull] PackedGuid movementGuid, [NotNull] MovementInfo moveInfo)
			: this()
		{
			MovementGuid = movementGuid ?? throw new ArgumentNullException(nameof(movementGuid)); MoveInfo = moveInfo ?? throw new ArgumentNullException(nameof(moveInfo));
		}

		public MSG_MOVE_START_STRAFE_LEFT_Payload()
			: base(NetworkOperationCode.MSG_MOVE_START_STRAFE_LEFT)
		{

		}
	}
}
