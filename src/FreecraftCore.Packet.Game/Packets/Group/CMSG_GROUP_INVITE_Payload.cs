using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.CMSG_GROUP_INVITE)]
	public sealed partial class CMSG_GROUP_INVITE_Payload : GamePacketPayload
	{
		//For some reason Blizzard ONLY supports the option to invite based on string
		//I think that's silly
		[WireMember(1)]
		public string PlayerToInvite { get; internal set; }

		//TC just discards this.
		[WireMember(2)]
		internal int Unk1 { get; set; }

		/// <inheritdoc />
		public CMSG_GROUP_INVITE_Payload([NotNull] string playerToInvite)
			: this()
		{
			if(string.IsNullOrWhiteSpace(playerToInvite)) throw new ArgumentException("Value cannot be null or whitespace.", nameof(playerToInvite));

			PlayerToInvite = playerToInvite;
		}

		/// <summary>
		/// Serializer ctor.
		/// </summary>
		public CMSG_GROUP_INVITE_Payload()
			: base(NetworkOperationCode.CMSG_GROUP_INVITE)
		{
			
		}
	}
}
