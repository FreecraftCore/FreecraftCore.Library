using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	//TODO: Standardize unit targeting packets like SELECT and USE and TARGET and etc.
	/// <summary>
	/// Opcode sent when a client attempts to interact or use a GameObject.
	/// </summary>
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.CMSG_GAMEOBJ_USE)]
	public sealed partial class CMSG_GAMEOBJ_USE_Payload : GamePacketPayload
	{
		/// <summary>
		/// The GUID of the GameObject to use.
		/// </summary>
		[WireMember(1)]
		public ObjectGuid Guid { get; internal set; }

		public CMSG_GAMEOBJ_USE_Payload([NotNull] ObjectGuid guid)
			: this()
		{
			if(guid.TypeId != EntityTypeId.TYPEID_GAMEOBJECT)
				throw new InvalidOperationException($"Cannot send {nameof(NetworkOperationCode.CMSG_GAMEOBJ_USE)} for Non-GameObject Guid: {guid}");

			Guid = guid ?? throw new ArgumentNullException(nameof(guid));
		}

		public CMSG_GAMEOBJ_USE_Payload()
			: base(NetworkOperationCode.CMSG_GAMEOBJ_USE)
		{
			
		}
	}
}
