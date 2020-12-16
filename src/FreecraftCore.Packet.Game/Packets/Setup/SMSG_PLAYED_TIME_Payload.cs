using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	/// <summary>
	/// Send by the server in response to a <see cref="NetworkOperationCode.CMSG_PLAYED_TIME"/>
	/// </summary>
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.SMSG_PLAYED_TIME)]
	public sealed partial class SMSG_PLAYED_TIME_Payload : GamePacketPayload
	{
		/// <summary>
		/// The total play time for the character.
		/// </summary>
		[WireMember(1)]
		public uint TotalPlayTime { get; internal set; }
		
		/// <summary>
		/// The playtime for the character at the current level.
		/// </summary>
		[WireMember(2)]
		public uint PlaytimeAtLevel { get; internal set; }

		/// <summary>
		/// Indicates if the played time should be written to the chat
		/// frame.
		/// </summary>
		[WireMember(3)]
		public bool ShowInChatFrame { get; internal set; } = false;

		/// <inheritdoc />
		public SMSG_PLAYED_TIME_Payload(uint totalPlayTime, uint playtimeAtLevel)
			: this()
		{
			//TODO: Assert played time
			TotalPlayTime = totalPlayTime;
			PlaytimeAtLevel = playtimeAtLevel;
		}

		/// <summary>
		/// Serializer ctor.
		/// </summary>
		public SMSG_PLAYED_TIME_Payload()
			: base(NetworkOperationCode.SMSG_PLAYED_TIME)
		{
			
		}
	}
}
