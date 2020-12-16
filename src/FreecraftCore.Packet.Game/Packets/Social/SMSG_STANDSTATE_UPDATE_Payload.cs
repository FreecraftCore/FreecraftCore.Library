using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	/// <summary>
	/// Packet payload structure for the <see cref="NetworkOperationCode"/> SMSG_STANDSTATE_UPDATE.
	/// </summary>
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.SMSG_STANDSTATE_UPDATE)]
	public sealed partial class SMSG_STANDSTATE_UPDATE_Payload : GamePacketPayload
	{
		[WireMember(1)]
		internal byte _State { get; set; }

		public UnitStandStateType State => (UnitStandStateType)_State;

		public SMSG_STANDSTATE_UPDATE_Payload(UnitStandStateType state)
			: this()
		{
			_State = (byte) state;
		}

		/// <summary>
		/// Default Serializer Ctor.
		/// </summary>
		public SMSG_STANDSTATE_UPDATE_Payload()
			: base(NetworkOperationCode.SMSG_STANDSTATE_UPDATE)
		{

		}
	}
}
