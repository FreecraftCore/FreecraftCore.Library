using System;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	//Same on 1.12.1 as in 3.3.5
	/// <summary>
	/// The wotlk implementation of the <see cref="NetworkOperationCode.CMSG_NAME_QUERY"/>
	/// packet.
	/// </summary>
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.CMSG_NAME_QUERY)]
	[ProtocolGrouping(ProtocolCode.Game)] //TODO: Change this protocol to something more specific
	public partial class CMSG_NAME_QUERY_Payload : GamePacketPayload
	{
		/// <inheritdoc />
		public override bool isValid { get; } = true;

		/// <summary>
		/// The object to query information for.
		/// </summary>
		[WireMember(1)]
		public ObjectGuid TargetGuid { get; internal set; }

		public CMSG_NAME_QUERY_Payload([NotNull] ObjectGuid targetGuid)
			: this()
		{
			if (targetGuid == null)
				throw new ArgumentNullException(nameof(targetGuid));

			TargetGuid = targetGuid;
		}

		public CMSG_NAME_QUERY_Payload()
			: base(NetworkOperationCode.CMSG_NAME_QUERY)
		{
			//serializer ctor
		}
	}
}
