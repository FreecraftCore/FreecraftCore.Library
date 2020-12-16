using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.CMSG_MOVE_SET_FLY)]
	public sealed partial class CMSG_MOVE_SET_FLY_Payload : GamePacketPayload, IPlayerMovementPayload<MovementInfo, MovementFlag, PackedGuid>
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

		public CMSG_MOVE_SET_FLY_Payload([NotNull] PackedGuid movementGuid, [NotNull] MovementInfo moveInfo)
			: this()
		{
			MovementGuid = movementGuid ?? throw new ArgumentNullException(nameof(movementGuid));
		}

		public CMSG_MOVE_SET_FLY_Payload()
			: base(NetworkOperationCode.CMSG_MOVE_SET_FLY)
		{

		}
	}
}
