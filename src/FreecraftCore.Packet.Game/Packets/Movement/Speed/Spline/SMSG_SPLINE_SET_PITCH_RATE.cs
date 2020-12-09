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
	/// Packet payload structure for the <see cref="NetworkOperationCode"/> SMSG_SPLINE_SET_PITCH_RATE.
	/// </summary>
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.SMSG_SPLINE_SET_PITCH_RATE)]
	public sealed partial class SMSG_SPLINE_SET_PITCH_RATE_Payload : GamePacketPayload, IMovementSpeedChangePayload
	{

		/// <inheritdoc />
		[WireMember(1)]
		public PackedGuid Target { get; internal set; }

		/// <inheritdoc />
		[JsonIgnore]
		[NotMapped]
		public UnitMoveType MoveType => UnitMoveType.MOVE_PITCH_RATE;

		/// <inheritdoc />
		[WireMember(2)]
		public float Speed { get; internal set; }
		/// <summary>
		/// Default Serializer Ctor.
		/// </summary>
		internal SMSG_SPLINE_SET_PITCH_RATE_Payload()
		{

		}
	}
}
