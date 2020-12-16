using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	//TODO: Renable serialization attributes when a vanilla version is created.
	//Slightly different in 1.12.1, Mangos makes a mention of a GUID sent too.
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.CMSG_ITEM_QUERY_SINGLE)]
	public sealed partial class CMSG_ITEM_QUERY_SINGLE_Payload : GamePacketPayload, IQueryRequestPayload
	{
		/// <summary>
		/// The item ID this query is for.
		/// </summary>
		[WireMember(1)]
		public int QueryId { get; internal set; }

		/// <inheritdoc />
		[WireMember(2)]
		public ObjectGuid QueryGuid { get; internal set; }

		/// <inheritdoc />
		public CMSG_ITEM_QUERY_SINGLE_Payload(int itemId)
			: this()
		{
			QueryId = itemId;
		}

		/// <summary>
		/// Serializer ctor.
		/// </summary>
		public CMSG_ITEM_QUERY_SINGLE_Payload()
			: base(NetworkOperationCode.CMSG_ITEM_QUERY_SINGLE)
		{
			
		}
	}
}
