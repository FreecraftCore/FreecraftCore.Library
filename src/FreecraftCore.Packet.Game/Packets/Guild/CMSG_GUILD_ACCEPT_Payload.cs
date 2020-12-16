using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	/// <summary>
	/// Packet payload structure for the <see cref="NetworkOperationCode"/> CMSG_GUILD_ACCEPT.
	/// </summary>
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.CMSG_GUILD_ACCEPT)]
	public sealed partial class CMSG_GUILD_ACCEPT_Payload : GamePacketPayload
	{
		//Packet is EMPTY, just means accept.

		/// <summary>
		/// Default Serializer Ctor.
		/// </summary>
		public CMSG_GUILD_ACCEPT_Payload()
			: base(NetworkOperationCode.CMSG_GUILD_ACCEPT)
		{

		}
	}
}
