using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.SMSG_DESTROY_OBJECT)]
	public sealed partial class SMSG_DESTROY_OBJECT_Payload : GamePacketPayload
	{
		[WireMember(1)]
		public ObjectGuid DestroyedObject { get; internal set; }

		[WireMember(2)]
		public bool IsForDeath { get; internal set; }

		/// <inheritdoc />
		public SMSG_DESTROY_OBJECT_Payload([NotNull] ObjectGuid destroyedObject, bool isForDeath)
			: this()
		{
			DestroyedObject = destroyedObject ?? throw new ArgumentNullException(nameof(destroyedObject));
			IsForDeath = isForDeath;
		}

		public SMSG_DESTROY_OBJECT_Payload()
			: base(NetworkOperationCode.SMSG_DESTROY_OBJECT)
		{
			
		}
	}
}
