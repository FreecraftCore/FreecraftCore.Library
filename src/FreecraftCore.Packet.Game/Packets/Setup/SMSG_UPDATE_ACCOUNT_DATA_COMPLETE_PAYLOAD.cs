using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	/// <summary>
	/// Sent by the server once the client data is set.
	/// </summary>
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.SMSG_UPDATE_ACCOUNT_DATA_COMPLETE)]
	public sealed partial class SMSG_UPDATE_ACCOUNT_DATA_COMPLETE_PAYLOAD : GamePacketPayload
	{
		//TODO: Extract enum
		/// <summary>
		/// The account data type that completed.
		/// </summary>
		[WireMember(1)]
		public CMSG_UPDATE_ACCOUNT_DATA_PAYLOAD.AccountDataType DataType { get; internal set; }

		//TODO: Investigate
		/// <summary>
		/// Unknown data? Maybe indicates success?
		/// </summary>
		[WireMember(2)]
		internal int Unk { get; set; } = 0;

		/// <inheritdoc />
		public SMSG_UPDATE_ACCOUNT_DATA_COMPLETE_PAYLOAD(CMSG_UPDATE_ACCOUNT_DATA_PAYLOAD.AccountDataType dataType)
			: this()
		{
			DataType = dataType;
		}

		public SMSG_UPDATE_ACCOUNT_DATA_COMPLETE_PAYLOAD()
			: base(NetworkOperationCode.SMSG_UPDATE_ACCOUNT_DATA_COMPLETE)
		{
			
		}
	}
}
