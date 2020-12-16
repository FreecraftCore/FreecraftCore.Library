using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	[WireDataContract]
	public sealed partial class PlayerAfkChatMessage : PlayerChatMessage
	{
		[WireMember(1)]
		public string Message { get; internal set; }

		public PlayerAfkChatMessage([NotNull] string message)
			: this(message, ChatLanguage.LANG_UNIVERSAL)
		{
		}

		public PlayerAfkChatMessage([NotNull] string message, ChatLanguage language)
			: base(ChatMessageType.CHAT_MSG_AFK, language)
		{
			if(string.IsNullOrWhiteSpace(message)) throw new ArgumentException("Value cannot be null or whitespace.", nameof(message));
			Message = message;
		}

		/// <summary>
		/// Serializer ctor.
		/// </summary>
		public PlayerAfkChatMessage()
		{
			
		}
	}
}
