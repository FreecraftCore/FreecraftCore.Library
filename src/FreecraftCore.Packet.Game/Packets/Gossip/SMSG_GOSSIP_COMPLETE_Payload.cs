using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	/// <summary>
	/// Packet payload structure for the <see cref="NetworkOperationCode"/> SMSG_GOSSIP_COMPLETE.
	/// </summary>
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.SMSG_GOSSIP_COMPLETE)]
	public sealed partial class SMSG_GOSSIP_COMPLETE_Payload : GamePacketPayload
	{
		//Just a command opcode. Contains no actual data.
		/// <summary>
		/// Default Serializer Ctor.
		/// </summary>
		public SMSG_GOSSIP_COMPLETE_Payload()
			: base(NetworkOperationCode.SMSG_GOSSIP_COMPLETE)
		{

		}
	}
}
