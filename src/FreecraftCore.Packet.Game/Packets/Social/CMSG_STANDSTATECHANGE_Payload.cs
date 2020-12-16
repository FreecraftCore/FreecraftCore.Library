using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	/// <summary>
	/// Packet payload structure for the <see cref="NetworkOperationCode"/> CMSG_STANDSTATECHANGE.
	/// </summary>
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.CMSG_STANDSTATECHANGE)]
	public sealed partial class CMSG_STANDSTATECHANGE_Payload : GamePacketPayload
	{
		[WireMember(1)]
		public UnitStandStateType State { get; internal set; }

		public CMSG_STANDSTATECHANGE_Payload(UnitStandStateType state)
			: this()
		{
			if(!Enum.IsDefined(typeof(UnitStandStateType), state)) throw new InvalidEnumArgumentException(nameof(state), (int)state, typeof(UnitStandStateType));

			State = state;
		}

		/// <summary>
		/// Default Serializer Ctor.
		/// </summary>
		public CMSG_STANDSTATECHANGE_Payload()
			: base(NetworkOperationCode.CMSG_STANDSTATECHANGE)
		{

		}
	}
}
