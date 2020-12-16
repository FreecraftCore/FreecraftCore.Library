using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	[WireDataContract]
	public sealed class NetworkChatMessageHeader
	{
		/// <summary>
		/// Indicates the message type of the chat message.
		/// </summary>
		[WireMember(1)]
		public ChatMessageType MessageType { get; internal set; }

		/// <summary>
		/// Indicates the language of the chat message.
		/// </summary>
		[WireMember(2)]
		public ChatLanguage Language { get; internal set; }

		/// <summary>
		/// The <see cref="ObjectGuid"/> of the entity that sent the message.
		/// </summary>
		[WireMember(3)]
		public ObjectGuid SenderGuid { get; internal set; }

		//TODO: Find out what this is
		[WireMember(4)]
		public int UnkFlags { get; internal set; }

		/// <inheritdoc />
		public NetworkChatMessageHeader(ChatMessageType messageType, ChatLanguage language, [NotNull] ObjectGuid senderGuid, int unkFlags)
		{
			MessageType = messageType;
			Language = language;
			SenderGuid = senderGuid ?? throw new ArgumentNullException(nameof(senderGuid));
			UnkFlags = unkFlags;
		}

		public NetworkChatMessageHeader()
		{
			
		}
	}
}
