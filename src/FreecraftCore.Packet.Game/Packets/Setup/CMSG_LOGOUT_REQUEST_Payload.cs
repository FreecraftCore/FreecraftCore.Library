using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.CMSG_LOGOUT_REQUEST)]
	public sealed partial class CMSG_LOGOUT_REQUEST_Payload : GamePacketPayload
	{
		/// <summary>
		/// Creates a new request to logout.
		/// </summary>
		public CMSG_LOGOUT_REQUEST_Payload()
			: base(NetworkOperationCode.CMSG_LOGOUT_REQUEST)
		{
			
		}
	}
}
