using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	/// <summary>
	/// Server message sent to the client to start a time sync exchange.
	/// </summary>
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.CMSG_TIME_SYNC_RESP)]
	public sealed partial class CMSG_TIME_SYNC_RESP_Payload : GamePacketPayload
	{
		/// <summary>
		/// Represents the counter/index for which sync request
		/// this response packet is responding to.
		/// </summary>
		[WireMember(1)]
		public int SynchronizationCounter { get; internal set; }

		/// <summary>
		/// Represents the time at which the client has handled
		/// the matching <see cref="SMSG_TIME_SYNC_REQ_Payload"/>.
		/// Gets the number of milliseconds elapsed since the system (client) started.
		/// </summary>
		[WireMember(2)]
		public uint ClientTimestamp { get; internal set; }

		public CMSG_TIME_SYNC_RESP_Payload(int synchronizationCounter, uint clientTimestamp)
			: this()
		{
			if (synchronizationCounter < 0) throw new ArgumentOutOfRangeException(nameof(synchronizationCounter));
			if (clientTimestamp == 0) throw new ArgumentOutOfRangeException(nameof(clientTimestamp));

			SynchronizationCounter = synchronizationCounter;
			ClientTimestamp = clientTimestamp;
		}

		/// <summary>
		/// Serializer ctor.
		/// </summary>
		public CMSG_TIME_SYNC_RESP_Payload()
			: base(NetworkOperationCode.CMSG_TIME_SYNC_RESP)
		{

		}
	}
}
