using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.CMSG_AREATRIGGER)]
	public sealed partial class CMSG_AREATRIGGER_Payload : GamePacketPayload
	{
		/// <summary>
		/// The ID of the <see cref="AreaTriggerEntry"/>.
		/// </summary>
		[WireMember(1)]
		public int AreaTriggerId { get; internal set; }

		public CMSG_AREATRIGGER_Payload(int areaTriggerId)
			: this()
		{
			if (areaTriggerId <= 0) throw new ArgumentOutOfRangeException(nameof(areaTriggerId));

			AreaTriggerId = areaTriggerId;
		}

		public CMSG_AREATRIGGER_Payload()
			: base(NetworkOperationCode.CMSG_AREATRIGGER)
		{
			
		}
	}
}
