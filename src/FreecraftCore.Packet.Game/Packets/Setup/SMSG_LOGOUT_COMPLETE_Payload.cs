using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.SMSG_LOGOUT_COMPLETE)]
	public sealed partial class SMSG_LOGOUT_COMPLETE_Payload : GamePacketPayload
	{
		/// <summary>
		/// Serializer ctor.
		/// </summary>
		public SMSG_LOGOUT_COMPLETE_Payload()
			: base(NetworkOperationCode.SMSG_LOGOUT_COMPLETE)
		{
			
		}
	}
}
