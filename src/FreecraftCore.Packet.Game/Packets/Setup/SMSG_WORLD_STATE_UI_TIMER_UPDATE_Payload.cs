using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	//1.12.1 doesn't have this opcode.
	/// <summary>
	/// Sent to the server in an attempt to syncronize time from the 3.3.5 client.
	/// </summary>
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.SMSG_WORLD_STATE_UI_TIMER_UPDATE)]
	public sealed partial class SMSG_WORLD_STATE_UI_TIMER_UPDATE_Payload : GamePacketPayload
	{
		/// <summary>
		/// The current time.
		/// </summary>
		[WireMember(1)]
		public uint CurrentTime { get; internal set; }

		/// <inheritdoc />
		public SMSG_WORLD_STATE_UI_TIMER_UPDATE_Payload(uint currentTime)
			: this()
		{
			CurrentTime = currentTime;
		}

		/// <summary>
		/// Default creation initializes the time to current time.
		/// </summary>
		public SMSG_WORLD_STATE_UI_TIMER_UPDATE_Payload()
			: base(NetworkOperationCode.SMSG_WORLD_STATE_UI_TIMER_UPDATE)
		{
			
		}
	}
}
