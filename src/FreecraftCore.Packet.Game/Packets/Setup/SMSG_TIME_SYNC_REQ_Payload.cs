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
	[GamePayloadOperationCode(NetworkOperationCode.SMSG_TIME_SYNC_REQ)]
	public sealed partial class SMSG_TIME_SYNC_REQ_Payload : GamePacketPayload
	{
		/// <summary>
		/// Represents the counter for how many
		/// times the client has sync'd.
		/// Incremented each time a sync is sent.
		/// </summary>
		[WireMember(1)]
		public int SynchronizationCounter { get; internal set; }

		public SMSG_TIME_SYNC_REQ_Payload(int synchronizationCounter)
			: this()
		{
			if (synchronizationCounter < 0) throw new ArgumentOutOfRangeException(nameof(synchronizationCounter));

			SynchronizationCounter = synchronizationCounter;
		}

		/// <summary>
		/// Serializer ctor.
		/// </summary>
		public SMSG_TIME_SYNC_REQ_Payload()
			: base(NetworkOperationCode.SMSG_TIME_SYNC_REQ)
		{
			
		}
	}
}
