using System.Collections.Generic;
using System.Linq;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	//TODO: Namequeries don't work for 1.12.1... not really for 3.3.5 either
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.SMSG_NAME_QUERY_RESPONSE)]
	[ProtocolGrouping(ProtocolCode.Game)] //TODO: Change this protocol to something more specific
	public partial class SMSG_NAME_QUERY_RESPONSE_Payload : GamePacketPayload
	{
		/// <summary>
		/// Enumeration of response codes for
		/// the name query response.
		/// </summary>
		public enum NameQueryResponseCode : byte
		{
			Success = 0,
			Failure = 1
		}

		//On 1.12.1 they don't send this object guid packed.
		/// <summary>
		/// The GUID requested in the name query request.
		/// </summary>
		[WireMember(1)]
		public PackedGuid RequestedGuid { get; internal set; }

		//TC sends this as a byte
		/// <summary>
		/// Indicates the result of the response.
		/// If successful then the name query response
		/// will contain information about the queried unit.
		/// </summary>
		[WireMember(2)]
		public NameQueryResponseCode ResponseCode { get; internal set; }

		/// <summary>
		/// Indicates if the response is successful.
		/// </summary>
		public bool IsSuccessful => ResponseCode == NameQueryResponseCode.Success;

		/// <summary>
		/// The name query result.
		/// </summary>
		[Optional(nameof(IsSuccessful))]
		[WireMember(3)]
		public NameQueryResult Result { get; internal set; }

		//TODO: Documentat overloads
		/// <inheritdoc />
		public SMSG_NAME_QUERY_RESPONSE_Payload(PackedGuid requestedGuid, NameQueryResponseCode responseCode, NameQueryResult result)
			: this()
		{
			RequestedGuid = requestedGuid;
			ResponseCode = responseCode;
			Result = result;
		}

		/// <inheritdoc />
		public SMSG_NAME_QUERY_RESPONSE_Payload(PackedGuid requestedGuid, NameQueryResponseCode responseCode)
			: this()
		{
			RequestedGuid = requestedGuid;
			ResponseCode = responseCode;
		}

		/// <inheritdoc />
		public SMSG_NAME_QUERY_RESPONSE_Payload(PackedGuid requestedGuid, NameQueryResult result)
			: this()
		{
			RequestedGuid = requestedGuid;
			ResponseCode = NameQueryResponseCode.Success;
			Result = result;
		}

		/// <inheritdoc />
		public SMSG_NAME_QUERY_RESPONSE_Payload(PackedGuid requestedGuid)
			: this()
		{
			RequestedGuid = requestedGuid;
			ResponseCode = NameQueryResponseCode.Failure;
		}

		/// <summary>
		/// Serializer ctor.
		/// </summary>
		public SMSG_NAME_QUERY_RESPONSE_Payload()
			: base(NetworkOperationCode.SMSG_NAME_QUERY_RESPONSE)
		{
			
		}
	}
}
