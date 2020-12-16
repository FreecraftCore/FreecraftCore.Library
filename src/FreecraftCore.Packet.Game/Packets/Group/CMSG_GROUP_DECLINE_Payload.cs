using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.CMSG_GROUP_DECLINE)]
	public sealed partial class CMSG_GROUP_DECLINE_Payload : GamePacketPayload
	{
		/// <summary>
		/// This just sends an empty group decline packet.
		/// </summary>
		public CMSG_GROUP_DECLINE_Payload()
			: base(NetworkOperationCode.CMSG_GROUP_DECLINE)
		{

		}
	}
}
