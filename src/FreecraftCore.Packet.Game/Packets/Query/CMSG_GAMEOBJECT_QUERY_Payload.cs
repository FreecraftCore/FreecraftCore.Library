using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.CMSG_GAMEOBJECT_QUERY)]
	public sealed partial class CMSG_GAMEOBJECT_QUERY_Payload : GamePacketPayload, IQueryRequestPayload
	{
		/// <inheritdoc />
		[WireMember(1)]
		public int QueryId { get; internal set; }

		/// <inheritdoc />
		[WireMember(2)]
		public ObjectGuid QueryGuid { get; internal set; } = ObjectGuid.Empty;

		/// <inheritdoc />
		public CMSG_GAMEOBJECT_QUERY_Payload(int gameObjectId)
			: this()
		{
			QueryId = gameObjectId;
		}

		public CMSG_GAMEOBJECT_QUERY_Payload()
			: base(NetworkOperationCode.CMSG_GAMEOBJECT_QUERY)
		{
			
		}
	}
}
