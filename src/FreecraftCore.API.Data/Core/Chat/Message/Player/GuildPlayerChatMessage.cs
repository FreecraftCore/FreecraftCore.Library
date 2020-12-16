using System;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	[WireDataContract]
	public sealed partial class GuildPlayerChatMessage : PlayerChatMessage
	{
		/// <summary>
		/// The chat message being sent.
		/// </summary>
		[WireMember(1)]
		public string Message { get; internal set; } //null terminated string message

		/// <inheritdoc />
		public GuildPlayerChatMessage(ChatLanguage language, [NotNull] string message)
			: base(ChatMessageType.CHAT_MSG_GUILD, language)
		{
			if (message == null)
				throw new ArgumentNullException(nameof(message));

			Message = message;
		}

		public GuildPlayerChatMessage()
		{

		}
	}
}
