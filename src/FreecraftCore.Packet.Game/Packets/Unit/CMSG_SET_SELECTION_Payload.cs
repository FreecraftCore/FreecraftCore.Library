using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.CMSG_SET_SELECTION)]
	public sealed partial class CMSG_SET_SELECTION_Payload : GamePacketPayload
	{
		[WireMember(1)]
		public ObjectGuid Target { get; internal set; }

		public CMSG_SET_SELECTION_Payload([NotNull] ObjectGuid target)
			: this()
		{
			Target = target ?? throw new ArgumentNullException(nameof(target));
		}

		/// <summary>
		/// Serializer ctor.
		/// </summary>
		public CMSG_SET_SELECTION_Payload()
			: base(NetworkOperationCode.CMSG_SET_SELECTION)
		{
			
		}
	}
}
