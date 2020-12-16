using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	//1.12.1 sends approximately the same packet but without daily quest time.
	/// <summary>
	/// Server response to <see cref="NetworkOperationCode.CMSG_QUERY_TIME"/>.
	/// </summary>
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.SMSG_QUERY_TIME_RESPONSE)]
	public partial class SMSG_QUERY_TIME_RESPONSE_Payload : GamePacketPayload
	{
		/// <summary>
		/// The current time.
		/// This is effectively the Unix Timestamp.
		/// The current calendar time (seconds since Jan 1, 1970).
		/// See: https://stackoverflow.com/questions/7550269/what-is-timenull-in-c#.
		/// </summary>
		[WireMember(1)]
		public uint CurrentTime { get; internal set; }

		/// <summary>
		/// The time remaining between the current time and the
		/// daily quest reset.
		/// </summary>
		[WireMember(2)]
		public uint DailyQuestTime { get; internal set; }

		/// <inheritdoc />
		public SMSG_QUERY_TIME_RESPONSE_Payload(uint currentTime, uint dailyQuestTime)
			: this()
		{
			CurrentTime = currentTime;
			DailyQuestTime = dailyQuestTime;
		}

		/// <summary>
		/// Creates a default time response payload
		/// with the current time.
		/// </summary>
		public SMSG_QUERY_TIME_RESPONSE_Payload()
			: base(NetworkOperationCode.SMSG_QUERY_TIME_RESPONSE)
		{
			
		}
	}
}
