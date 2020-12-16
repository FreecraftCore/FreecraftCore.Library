using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.SMSG_LOGOUT_RESPONSE)]
	public sealed partial class SMSG_LOGOUT_RESPONSE_Payload : GamePacketPayload
	{
		[WireMember(1)]
		public LogoutResultCode Result { get; internal set; }

		[WireMember(2)]
		public bool IsInstant { get; internal set; }

		public SMSG_LOGOUT_RESPONSE_Payload(bool isInstant)
			: this()
		{
			Result = LogoutResultCode.Success;
			IsInstant = isInstant;
		}

		public SMSG_LOGOUT_RESPONSE_Payload(LogoutResultCode result)
			: this()
		{
			if (!Enum.IsDefined(typeof(LogoutResultCode), result)) throw new InvalidEnumArgumentException(nameof(result), (int) result, typeof(LogoutResultCode));

			Result = result;
			IsInstant = false;
		}

		/// <summary>
		/// Serializer ctor.
		/// </summary>
		public SMSG_LOGOUT_RESPONSE_Payload()
			: base(NetworkOperationCode.SMSG_LOGOUT_RESPONSE)
		{
			
		}
	}
}
