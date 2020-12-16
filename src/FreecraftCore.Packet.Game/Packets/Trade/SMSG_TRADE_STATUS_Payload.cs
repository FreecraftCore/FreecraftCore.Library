using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.SMSG_TRADE_STATUS)]
	public sealed partial class SMSG_TRADE_STATUS_Payload : GamePacketPayload
	{
		[WireMember(1)]
		public TradeStatus Status { get; internal set; }

		/// <inheritdoc />
		public SMSG_TRADE_STATUS_Payload(TradeStatus status)
			: this()
		{
			if(!Enum.IsDefined(typeof(TradeStatus), status)) throw new InvalidEnumArgumentException(nameof(status), (int)status, typeof(TradeStatus));

			Status = status;
		}

		/// <summary>
		/// Serializer ctor.
		/// </summary>
		public SMSG_TRADE_STATUS_Payload()
			: base(NetworkOperationCode.SMSG_TRADE_STATUS)
		{

		}
	}
}
