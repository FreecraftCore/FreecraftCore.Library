﻿using FreecraftCore.Serializer;

namespace FreecraftCore
{
	/// <summary>
	/// Sent by the connecting user during character list.
	/// Sent with <see cref="NetworkOperationCode.CMSG_REALM_SPLIT"/>.
	/// </summary>
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.CMSG_REALM_SPLIT)]
	public sealed class RealmSplitRequest : GamePacketPayload
	{
		/// <inheritdoc />
		public override bool isValid => true;

		[ReadToEnd]
		[WireMember(1)]
		public byte[] Data { get; }

		public RealmSplitRequest()
		{
			
		}
	}
}
