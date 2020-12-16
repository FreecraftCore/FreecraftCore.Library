using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	/// <summary>
	/// Packet sent by the client to acknowledge a map teleport.
	/// Usually sent in response to <see cref="SMSG_NEW_WORLD_Payload"/>.
	/// </summary>
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.MSG_MOVE_WORLDPORT_ACK)]
	public sealed partial class MSG_MOVE_WORLDPORT_ACK_Payload : GamePacketPayload
	{
		/// <summary>
		/// Creates a new world port acknowledgement.
		/// </summary>
		public MSG_MOVE_WORLDPORT_ACK_Payload()
			: base(NetworkOperationCode.MSG_MOVE_WORLDPORT_ACK)
		{

		}
	}
}
