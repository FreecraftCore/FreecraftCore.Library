using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	/// <summary>
	/// Packet payload structure for the <see cref="NetworkOperationCode"/> MSG_MOVE_TELEPORT.
	/// </summary>
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.MSG_MOVE_TELEPORT)]
	public sealed partial class MSG_MOVE_TELEPORT_Payload : GamePacketPayload, IPlayerMovementPayload<MovementInfo, MovementFlag, PackedGuid>
	{
		/// <inheritdoc />
		[WireMember(1)]
		public PackedGuid MovementGuid { get; internal set; }

		/// <inheritdoc />
		[WireMember(2)]
		public MovementInfo MoveInfo { get; internal set; }

		public MSG_MOVE_TELEPORT_Payload([NotNull] PackedGuid movementGuid, int sequenceCounter, [NotNull] MovementInfo moveInfo)
			: this()
		{
			MovementGuid = movementGuid ?? throw new ArgumentNullException(nameof(movementGuid));
			MoveInfo = moveInfo ?? throw new ArgumentNullException(nameof(moveInfo));
		}
		/// <summary>
		/// Default Serializer Ctor.
		/// </summary>
		public MSG_MOVE_TELEPORT_Payload()
			: base(NetworkOperationCode.MSG_MOVE_TELEPORT)
		{

		}
	}
}
