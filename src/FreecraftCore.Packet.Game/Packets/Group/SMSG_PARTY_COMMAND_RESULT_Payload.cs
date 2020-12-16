using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.SMSG_PARTY_COMMAND_RESULT)]
	public sealed partial class SMSG_PARTY_COMMAND_RESULT_Payload : GamePacketPayload
	{
		[WireMember(1)]
		public PartyOperation Operation { get; internal set; }

		[WireMember(2)]
		public string PlayerName { get; internal set; }

		[WireMember(3)]
		public PartyResult Result { get; internal set; }

		/// <summary>
		/// Indicates if it the command was successful.
		/// </summary>
		public bool isSuccessful => Result == PartyResult.ERR_PARTY_RESULT_OK;

		//WorldSession::SendPartyResult(PartyOperation operation, const std::string& member, PartyResult res, uint32 val /* = 0 */)
		//But VAL never used?!
		[WireMember(4)]
		internal int Unk1 { get; set; } //TC calls this Val.

		/// <summary>
		/// Serializer ctor.
		/// </summary>
		public SMSG_PARTY_COMMAND_RESULT_Payload()
			: base(NetworkOperationCode.SMSG_PARTY_COMMAND_RESULT)
		{
			
		}
	}
}
