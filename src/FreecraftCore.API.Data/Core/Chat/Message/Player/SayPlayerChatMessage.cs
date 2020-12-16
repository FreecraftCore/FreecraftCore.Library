using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	[WireDataContract]
	public sealed partial class SayPlayerChatMessage : PlayerChatMessage
	{
		/// <summary>
		/// The chat message being sent.
		/// </summary>
		[WireMember(1)]
		public string Message { get; internal set; } //null terminated string message

		/// <inheritdoc />
		public SayPlayerChatMessage(ChatLanguage language, [NotNull] string message)
			: base(ChatMessageType.CHAT_MSG_SAY, language)
		{
			if(string.IsNullOrWhiteSpace(message)) throw new ArgumentException("Value cannot be null or whitespace.", nameof(message));

			Message = message;
		}

		/// <summary>
		/// Serializer ctor.
		/// </summary>
		public SayPlayerChatMessage()
		{

		}
	}
}
