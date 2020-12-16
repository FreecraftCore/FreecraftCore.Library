using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.SMSG_GAMEOBJECT_QUERY_RESPONSE)]
	public sealed partial class SMSG_GAMEOBJECT_QUERY_RESPONSE_Payload : GamePacketPayload, IQueryResponsePayload<GameObjectQueryResponseInfo>
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
		public GameObjectQueryResponseInfo Result { get; internal set; }

		/// <inheritdoc />
		public SMSG_GAMEOBJECT_QUERY_RESPONSE_Payload(int queryId, [NotNull] GameObjectQueryResponseInfo result)
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
		public SMSG_GAMEOBJECT_QUERY_RESPONSE_Payload(uint queryId)
			: this()
		{
			PackedResponseId = queryId & 0x80000000;
		}

		public SMSG_GAMEOBJECT_QUERY_RESPONSE_Payload()
			: base(NetworkOperationCode.SMSG_GAMEOBJECT_QUERY_RESPONSE)
		{
			
		}
	}
}
