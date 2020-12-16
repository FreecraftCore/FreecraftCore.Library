using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.CMSG_GROUP_ACCEPT)]
	public sealed partial class CMSG_GROUP_ACCEPT_Payload : GamePacketPayload
	{
		[WireMember(1)]
		internal int Unk1 { get; set; }

		/// <summary>
		/// This just sends an "empty" group accept packet.
		/// (Not really empty, unknown Data within it.)
		/// </summary>
		public CMSG_GROUP_ACCEPT_Payload()
			: base(NetworkOperationCode.CMSG_GROUP_ACCEPT)
		{

		}
	}
}
