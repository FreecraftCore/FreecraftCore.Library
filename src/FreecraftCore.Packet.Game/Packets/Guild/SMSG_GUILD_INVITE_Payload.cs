using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	/// <summary>
	/// Packet payload structure for the <see cref="NetworkOperationCode"/> SMSG_GUILD_INVITE.
	/// </summary>
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.SMSG_GUILD_INVITE)]
	public sealed partial class SMSG_GUILD_INVITE_Payload : GamePacketPayload
	{
		[Encoding(EncodingType.ASCII)]
		[WireMember(1)]
		public string InvitingPlayerName { get; internal set; }

		[Encoding(EncodingType.ASCII)]
		[WireMember(2)]
		public string GuildName { get; internal set; }

		public SMSG_GUILD_INVITE_Payload([NotNull] string invitingPlayerName, [NotNull] string guildName)
			: this()
		{
			if (string.IsNullOrWhiteSpace(invitingPlayerName)) throw new ArgumentException("Value cannot be null or whitespace.", nameof(invitingPlayerName));
			if (string.IsNullOrWhiteSpace(guildName)) throw new ArgumentException("Value cannot be null or whitespace.", nameof(guildName));

			InvitingPlayerName = invitingPlayerName;
			GuildName = guildName;
		}

		/// <summary>
		/// Default Serializer Ctor.
		/// </summary>
		public SMSG_GUILD_INVITE_Payload()
			: base(NetworkOperationCode.SMSG_GUILD_INVITE)
		{

		}
	}
}
