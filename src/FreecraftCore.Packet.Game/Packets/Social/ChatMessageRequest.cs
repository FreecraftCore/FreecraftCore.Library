using System;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.CMSG_MESSAGECHAT)]
	[ProtocolGrouping(ProtocolCode.Game)] //TODO: Change this protocol to something more specific
	public partial class ChatMessageRequest : GamePacketPayload
	{
		/// <inheritdoc />
		public override bool isValid { get; }

		/// <summary>
		/// The chat message.
		/// </summary>
		[WireMember(1)]
		public PlayerChatMessage Message { get; internal set; }

		public ChatMessageRequest([NotNull] PlayerChatMessage message)
			: this()
		{
			if (message == null) throw new ArgumentNullException(nameof(message));

			Message = message;
		}

		public ChatMessageRequest()
			: base(NetworkOperationCode.CMSG_MESSAGECHAT)
		{
			
		}
	}
}
