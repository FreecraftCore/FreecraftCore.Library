using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.CMSG_MOVE_FALL_RESET)]
	public sealed class CMSG_MOVE_FALL_RESET_Payload_Vanilla : GamePacketPayload, IPlayerMovementPayload<MovementInfo_Vanilla, MovementFlags_Vanilla, PackedGuid>
	{
		/// <summary>
		/// Indicates if it has a packed guid.
		/// Only servers should send guid in 1.12.1
		/// </summary>
		public bool HasGuid { get; } = true;

		/// <inheritdoc />
		[Optional(nameof(HasGuid))]
		[WireMember(1)]
		public PackedGuid MovementGuid { get; internal set; }

		/// <summary>
		/// The movement information.
		/// </summary>
		[WireMember(2)]
		public MovementInfo_Vanilla MoveInfo { get; internal set; }

		public CMSG_MOVE_FALL_RESET_Payload_Vanilla([NotNull] MovementInfo_Vanilla moveInfo)
		{
			MoveInfo = moveInfo ?? throw new ArgumentNullException(nameof(moveInfo));
			HasGuid = false;
		}

		/// <inheritdoc />
		public CMSG_MOVE_FALL_RESET_Payload_Vanilla([NotNull] PackedGuid movementGuid, [NotNull] MovementInfo_Vanilla moveInfo)
		{
			MovementGuid = movementGuid ?? throw new ArgumentNullException(nameof(movementGuid));
			MoveInfo = moveInfo ?? throw new ArgumentNullException(nameof(moveInfo));
		}

		protected CMSG_MOVE_FALL_RESET_Payload_Vanilla()
		{

		}
	}
}
