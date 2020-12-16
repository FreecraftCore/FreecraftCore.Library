using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	/// <summary>
	/// Empty request query payload send to the server
	/// to request the absolute timestamp.
	/// Server should return with: <see cref="SMSG_QUERY_TIME_RESPONSE_Payload"/>
	/// </summary>
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.CMSG_QUERY_TIME)]
	public sealed partial class CMSG_QUERY_TIME_Payload : GamePacketPayload
	{
		/// <summary>
		/// Creates a new time query request.
		/// </summary>
		public CMSG_QUERY_TIME_Payload()
			: base(NetworkOperationCode.CMSG_QUERY_TIME)
		{
			
		}
	}
}
