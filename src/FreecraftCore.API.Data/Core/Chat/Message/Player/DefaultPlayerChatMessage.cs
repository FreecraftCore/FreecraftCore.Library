using System;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	[WireDataContract]
	public sealed partial class DefaultPlayerChatMessage : PlayerChatMessage
	{
		/// <summary>
		/// The chat message being sent.
		/// </summary>
		[WireMember(1)]
		public string Message { get; internal set; } //null terminated string message

		/// <inheritdoc />
		public DefaultPlayerChatMessage(ChatMessageType messageType, ChatLanguage language, [NotNull] string message) 
			: base(messageType, language)
		{
			if (message == null)
				throw new ArgumentNullException(nameof(message));

			Message = message;
		}

		public DefaultPlayerChatMessage()
		{
			
		}
	}
}
