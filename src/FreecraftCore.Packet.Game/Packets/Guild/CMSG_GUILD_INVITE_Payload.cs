using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	/// <summary>
	/// Packet payload structure for the <see cref="NetworkOperationCode"/> CMSG_GUILD_INVITE.
	/// </summary>
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.CMSG_GUILD_INVITE)]
	public sealed partial class CMSG_GUILD_INVITE_Payload : GamePacketPayload
	{
		[Encoding(EncodingType.ASCII)]
		[WireMember(1)]
		public string PlayerToInviteName { get; internal set; }

		public CMSG_GUILD_INVITE_Payload([NotNull] string playerToInviteName)
			: this()
		{
			if (string.IsNullOrWhiteSpace(playerToInviteName)) throw new ArgumentException("Value cannot be null or whitespace.", nameof(playerToInviteName));

			PlayerToInviteName = playerToInviteName;
		}

		/// <summary>
		/// Default Serializer Ctor.
		/// </summary>
		public CMSG_GUILD_INVITE_Payload()
			: base(NetworkOperationCode.CMSG_GUILD_INVITE)
		{

		}
	}
}
