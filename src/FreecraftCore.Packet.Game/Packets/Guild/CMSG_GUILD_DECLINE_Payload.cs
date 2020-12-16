using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	/// <summary>
	/// Packet payload structure for the <see cref="NetworkOperationCode"/> CMSG_GUILD_DECLINE.
	/// </summary>
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.CMSG_GUILD_DECLINE)]
	public sealed partial class CMSG_GUILD_DECLINE_Payload : GamePacketPayload
	{
		//Empty, just means it's declined.

		/// <summary>
		/// Default Serializer Ctor.
		/// </summary>
		public CMSG_GUILD_DECLINE_Payload()
			: base(NetworkOperationCode.CMSG_GUILD_DECLINE)
		{

		}
	}
}
