using System;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	[WireDataContract]
	public sealed partial class ChannelPlayerChatMessage : PlayerChatMessage
	{
		/// <summary>
		/// The targeted reciever of the message.
		/// </summary>
		[WireMember(1)]
		public string ChannelName { get; internal set; } //null terminated string reciever

		/// <summary>
		/// The chat message being sent.
		/// </summary>
		[WireMember(2)]
		public string Message { get; internal set; } //null terminated string message

		/// <inheritdoc />
		public ChannelPlayerChatMessage(ChatLanguage language, [NotNull] string message, [NotNull] string channelName) 
			: base(ChatMessageType.CHAT_MSG_CHANNEL, language)
		{
			if (channelName == null)
				throw new ArgumentNullException(nameof(channelName));
			if (message == null)
				throw new ArgumentNullException(nameof(message));

			ChannelName = channelName;
			Message = message;
		}

		public ChannelPlayerChatMessage()
		{
			
		}
	}
}
