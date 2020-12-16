using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	/// <summary>
	/// Unusued!
	/// Packet payload structure for the <see cref="NetworkOperationCode"/> CMSG_GUILD_CREATE.
	/// </summary>
	[Obsolete("TrinityCore does not implement this packet.")]
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.CMSG_GUILD_CREATE)]
	public sealed partial class CMSG_GUILD_CREATE_Payload : GamePacketPayload
	{
		[Encoding(EncodingType.ASCII)]
		[WireMember(1)]
		public string GuildName { get; internal set; }

		public CMSG_GUILD_CREATE_Payload([NotNull] string guildName)
			: this()
		{
			if (string.IsNullOrWhiteSpace(guildName)) throw new ArgumentException("Value cannot be null or whitespace.", nameof(guildName));

			GuildName = guildName;
		}

		/// <summary>
		/// Default Serializer Ctor.
		/// </summary>
		public CMSG_GUILD_CREATE_Payload()
			: base(NetworkOperationCode.CMSG_GUILD_CREATE)
		{

		}
	}
}
