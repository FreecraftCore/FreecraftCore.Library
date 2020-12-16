using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	//TODO: This is not fully implemented.
	/// <summary>
	/// Send during initial before joining map on
	/// Trinitycore. Before player is joined into the world.
	/// </summary>
	[GamePayloadOperationCode(NetworkOperationCode.SMSG_CONTACT_LIST)]
	[WireDataContract]
    public sealed partial class SMSG_CONTACT_LIST_PAYLOAD : GamePacketPayload
	{
		//TODO: Extract
		[WireDataContract]
		public enum SocialFlag : int
		{
			SOCIAL_FLAG_FRIEND = 0x01,
			SOCIAL_FLAG_IGNORED = 0x02,
			SOCIAL_FLAG_MUTED = 0x04,                          // guessed
			SOCIAL_FLAG_UNK = 0x08,                          // Unknown - does not appear to be RaF

			SOCIAL_FLAG_ALL = SOCIAL_FLAG_FRIEND | SOCIAL_FLAG_IGNORED | SOCIAL_FLAG_MUTED
		}

		/// <summary>
		/// TODO: Implement flags enumeration for social type
		/// </summary>
		[WireMember(1)]
		public SocialFlag Flags { get; internal set; } = SocialFlag.SOCIAL_FLAG_ALL;

		/// <summary>
		/// TODO: Implement the actual friends data
		/// </summary>
		[ReadToEnd]
		[WireMember(2)]
		public byte[] Data { get; internal set; } = new byte[4]; //TODO: Don't autoset like this

		/// <summary>
		/// Creates an empty friends list packet.
		/// </summary>
		public SMSG_CONTACT_LIST_PAYLOAD()
			: base(NetworkOperationCode.SMSG_CONTACT_LIST)
		{
			
		}
    }
}
