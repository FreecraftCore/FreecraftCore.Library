using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.SMSG_ITEM_QUERY_SINGLE_RESPONSE)]
	public sealed partial class SMSG_ITEM_QUERY_SINGLE_RESPONSE_Payload : GamePacketPayload, IQueryResponsePayload<ItemQueryResponseInfo>
	{
		[WireMember(1)]
		internal uint PackedResponseId { get; set; }

		/// <inheritdoc />
		public int QueryId => (int)(PackedResponseId & ~0x80000000);

		/// <summary>
		/// Indicates if the query was successful.
		/// </summary>
		public bool IsSuccessful => (PackedResponseId & 0x80000000) == 0;

		[Optional(nameof(IsSuccessful))]
		[WireMember(2)]
		public ItemQueryResponseInfo Result { get; internal set; }

		/// <inheritdoc />
		public SMSG_ITEM_QUERY_SINGLE_RESPONSE_Payload(int queryId, [NotNull] ItemQueryResponseInfo result)
			: this()
		{
			//No bitwise math needed since success if 0x0
			PackedResponseId = (uint)queryId;
			Result = result ?? throw new ArgumentNullException(nameof(result));
		}

		/// <summary>
		/// Creates a failing response.
		/// </summary>
		/// <param name="queryId">The query id.</param>
		public SMSG_ITEM_QUERY_SINGLE_RESPONSE_Payload(uint queryId)
			: this()
		{
			PackedResponseId = queryId & 0x80000000;
		}

		public SMSG_ITEM_QUERY_SINGLE_RESPONSE_Payload()
			: base(NetworkOperationCode.SMSG_ITEM_QUERY_SINGLE_RESPONSE)
		{
			
		}
	}
}
