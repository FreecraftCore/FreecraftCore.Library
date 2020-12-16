using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	/// <summary>
	/// Packet payload structure for the <see cref="NetworkOperationCode"/> CMSG_QUESTGIVER_HELLO.
	/// </summary>
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.CMSG_QUESTGIVER_HELLO)]
	public sealed partial class CMSG_QUESTGIVER_HELLO_Payload : GamePacketPayload
	{
		/// <summary>
		/// The quest giver <see cref="ObjectGuid"/>.
		/// </summary>
		[WireMember(1)]
		public ObjectGuid Target { get; internal set; }

		public CMSG_QUESTGIVER_HELLO_Payload([NotNull] ObjectGuid target)
			: this()
		{
			Target = target ?? throw new ArgumentNullException(nameof(target));
		}

		/// <summary>
		/// Default Serializer Ctor.
		/// </summary>
		public CMSG_QUESTGIVER_HELLO_Payload()
			: base(NetworkOperationCode.CMSG_QUESTGIVER_HELLO)
		{

		}
	}
}
