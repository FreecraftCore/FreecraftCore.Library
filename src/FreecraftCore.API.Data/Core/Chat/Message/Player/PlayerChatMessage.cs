using System;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	//TODO: Rewrite this so that we don't need 40 chat packet classes.
	[DefaultChild(typeof(DefaultPlayerChatMessage))]
	[WireDataContractBaseType((int)ChatMessageType.CHAT_MSG_GUILD, typeof(GuildPlayerChatMessage))] //for guild chat
	[WireDataContractBaseType((int)ChatMessageType.CHAT_MSG_CHANNEL, typeof(ChannelPlayerChatMessage))] //for channel messages
	[WireDataContractBaseType((int)ChatMessageType.CHAT_MSG_WHISPER, typeof(WhisperPlayerChatMessage))] //for player whispers
	[WireDataContractBaseType((int)ChatMessageType.CHAT_MSG_SAY, typeof(SayPlayerChatMessage))]
	[WireDataContractBaseType((int)ChatMessageType.CHAT_MSG_AFK, typeof(PlayerAfkChatMessage))]
	[WireDataContract(PrimitiveSizeType.Int32)]
	public abstract partial class PlayerChatMessage
	{
		/// <summary>
		/// Indicates the message type of the chat message.
		/// </summary>
		[EnumSize(PrimitiveSizeType.Int32)]
		[WireMember(1)]
		public ChatMessageType MessageType { get; internal set; }
	
		/// <summary>
		/// Indicates the language of the chat message.
		/// </summary>	
		[WireMember(2)]
		public ChatLanguage Language { get; internal set; }

		protected PlayerChatMessage(ChatMessageType messageType, ChatLanguage language)
		{
			if (!Enum.IsDefined(typeof(ChatMessageType), messageType))
				throw new ArgumentOutOfRangeException(nameof(messageType), "Value should be defined in the ChatMessageType enum.");

			if (!Enum.IsDefined(typeof(ChatLanguage), language))
				throw new ArgumentOutOfRangeException(nameof(language), "Value should be defined in the ChatLanguage enum.");

			MessageType = messageType;
			Language = language;
		}

		protected PlayerChatMessage()
		{
			
		}
	}
}
