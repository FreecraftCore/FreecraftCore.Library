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
	/// Packet payload structure for the <see cref="NetworkOperationCode"/> SMSG_SPLINE_SET_RUN_BACK_SPEED.
	/// </summary>
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.SMSG_SPLINE_SET_RUN_BACK_SPEED)]
	public sealed partial class SMSG_SPLINE_SET_RUN_BACK_SPEED_Payload : GamePacketPayload, IMovementSpeedChangePayload
	{
		/// <inheritdoc />
		[WireMember(1)]
		public PackedGuid Target { get; internal set; }

		/// <inheritdoc />
		[JsonIgnore]
		[NotMapped]
		public UnitMoveType MoveType => UnitMoveType.MOVE_RUN_BACK;

		/// <inheritdoc />
		[WireMember(2)]
		public float Speed { get; internal set; }

		/// <summary>
		/// Default Serializer Ctor.
		/// </summary>
		internal SMSG_SPLINE_SET_RUN_BACK_SPEED_Payload()
		{

		}
	}
}
