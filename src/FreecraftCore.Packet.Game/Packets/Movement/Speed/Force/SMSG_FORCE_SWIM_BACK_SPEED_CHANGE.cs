using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace FreecraftCore
{
	/// <summary>
	/// Packet payload structure for the <see cref="NetworkOperationCode"/> SMSG_FORCE_SWIM_BACK_SPEED_CHANGE.
	/// </summary>
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.SMSG_FORCE_SWIM_BACK_SPEED_CHANGE)]
	public sealed partial class SMSG_FORCE_SWIM_BACK_SPEED_CHANGE_Payload : GamePacketPayload, IMovementSpeedChangePayload
	{
		[WireMember(1)]
		public PackedGuid Target { get; internal set; }

		/// <summary>
		/// Movement counter. Unimplemented at the moment! NUM_PMOVE_EVTS = 0x39Z.
		/// </summary>
		[WireMember(2)]
		public int MovementCounter { get; internal set; }

		[JsonIgnore]
		[NotMapped]
		public UnitMoveType MoveType => UnitMoveType.MOVE_SWIM_BACK;

		[WireMember(3)]
		public float Speed { get; internal set; }

		/// <summary>
		/// Default Serializer Ctor.
		/// </summary>
		public SMSG_FORCE_SWIM_BACK_SPEED_CHANGE_Payload()
			: base(NetworkOperationCode.SMSG_FORCE_SWIM_BACK_SPEED_CHANGE)
		{

		}
	}
}
