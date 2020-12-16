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
	/// Packet payload structure for the <see cref="NetworkOperationCode"/> MSG_MOVE_SET_FLIGHT_BACK_SPEED.
	/// </summary>
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.MSG_MOVE_SET_FLIGHT_BACK_SPEED)]
	public sealed partial class MSG_MOVE_SET_FLIGHT_BACK_SPEED_Payload : GamePacketPayload, IMovementSpeedChangeOtherPayload
	{
		/// <inheritdoc />
		[WireMember(1)]
		public PackedGuid Target { get; internal set; }

		/// <inheritdoc />
		[WireMember(2)]
		public MovementInfo MovementInformation { get; internal set; }

		/// <inheritdoc />
		[JsonIgnore]
		[NotMapped]
		public UnitMoveType MoveType => UnitMoveType.MOVE_FLIGHT_BACK;

		/// <inheritdoc />
		[WireMember(3)]
		public float Speed { get; internal set; }

		/// <summary>
		/// Default Serializer Ctor.
		/// </summary>
		public MSG_MOVE_SET_FLIGHT_BACK_SPEED_Payload()
			: base(NetworkOperationCode.MSG_MOVE_SET_FLIGHT_BACK_SPEED)
		{

		}
	}
}
