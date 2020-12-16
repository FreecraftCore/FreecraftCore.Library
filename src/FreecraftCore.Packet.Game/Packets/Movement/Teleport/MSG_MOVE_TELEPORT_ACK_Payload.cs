using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	/// <summary>
	/// Packet payload structure for the <see cref="NetworkOperationCode"/> MSG_MOVE_TELEPORT_ACK.
	/// </summary>
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.MSG_MOVE_TELEPORT_ACK)]
	public sealed partial class MSG_MOVE_TELEPORT_ACK_Payload : GamePacketPayload, IPlayerMovementPayload<MovementInfo, MovementFlag, PackedGuid>
	{
		/// <inheritdoc />
		[WireMember(1)]
		public PackedGuid MovementGuid { get; internal set; }

		//TrinityCore does not really handle this.
		[WireMember(2)]
		public int SequenceCounter { get; internal set; }

		/// <inheritdoc />
		[WireMember(3)]
		public MovementInfo MoveInfo { get; internal set; }

		public MSG_MOVE_TELEPORT_ACK_Payload([NotNull] PackedGuid movementGuid, int sequenceCounter, [NotNull] MovementInfo moveInfo)
			: this()
		{
			MovementGuid = movementGuid ?? throw new ArgumentNullException(nameof(movementGuid));
			SequenceCounter = sequenceCounter;
			MoveInfo = moveInfo ?? throw new ArgumentNullException(nameof(moveInfo));
		}

		/// <summary>
		/// Default Serializer Ctor.
		/// </summary>
		public MSG_MOVE_TELEPORT_ACK_Payload()
			: base(NetworkOperationCode.MSG_MOVE_TELEPORT_ACK)
		{

		}
	}
}
