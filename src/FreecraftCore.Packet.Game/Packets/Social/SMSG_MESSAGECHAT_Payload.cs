using System;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	//TODO: Support BG and Achievement messages
	/// <summary>
	/// Represents a chat message payload from 3.3.5
	/// </summary>
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.SMSG_MESSAGECHAT)]
	[ProtocolGrouping(ProtocolCode.Game)] //TODO: Change this protocol to something more specific
	public partial class SMSG_MESSAGECHAT_Payload : GamePacketPayload
	{
		/// <summary>
		/// The header details of the message.
		/// </summary>
		[WireMember(1)]
		public NetworkChatMessageHeader MessageHeader { get; internal set; }

		/// <summary>
		/// Indicates if it is a whisper message
		/// and that <see cref="WhisperMessageDetails"/> is contained within
		/// the message.
		/// </summary>
		public bool IsWhisperMessage
		{
			get
			{
				switch(MessageHeader.MessageType)
				{
					case ChatMessageType.CHAT_MSG_WHISPER_FOREIGN:
						return true;
					default:
						return false;
				}
			}
		}

		/// <summary>
		/// Indicates if it is a creature message and
		/// if the <see cref="CreatureMessageDetails"/> is set.
		/// </summary>
		public bool IsCreatureMessage
		{
			get
			{
				switch(MessageHeader.MessageType)
				{
					case ChatMessageType.CHAT_MSG_MONSTER_SAY:
					case ChatMessageType.CHAT_MSG_MONSTER_PARTY:
					case ChatMessageType.CHAT_MSG_MONSTER_YELL:
					case ChatMessageType.CHAT_MSG_MONSTER_WHISPER:
					case ChatMessageType.CHAT_MSG_MONSTER_EMOTE:
					case ChatMessageType.CHAT_MSG_RAID_BOSS_EMOTE:
					case ChatMessageType.CHAT_MSG_RAID_BOSS_WHISPER:
					case ChatMessageType.CHAT_MSG_BATTLENET:
						return true;
					default:
						return false;
				}
			}
		}

		/// <summary>
		/// Indicates if it s a chat channel message
		/// and if <see cref="ChannelMessageDetails"/>
		/// is set.
		/// </summary>
		public bool IsChatChannelMessage
		{
			get
			{
				switch(MessageHeader.MessageType)
				{
					case ChatMessageType.CHAT_MSG_CHANNEL:
						return true;
					default:
						return false;
				}
			}
		}

		/// <summary>
		/// Indicates that the message is a default chat message
		/// meaning <see cref="DefaultMessageDetails"/> is set.
		/// </summary>
		public bool IsDefaultChatMessage => !IsChatChannelMessage &&
			!IsCreatureMessage && !IsWhisperMessage;

		/// <summary>
		/// The whisper message details.
		/// </summary>
		[CanBeNull]
		[Optional(nameof(IsWhisperMessage))]
		[WireMember(6)]
		public NetworkChatWhisperMessageDetails WhisperMessageDetails { get; internal set; }

		/// <summary>
		/// The creature message details.
		/// </summary>
		[CanBeNull]
		[Optional(nameof(IsCreatureMessage))]
		[WireMember(7)]
		public NetworkChatCreatureMessageDetails CreatureMessageDetails { get; internal set; }

		/// <summary>
		/// The channel message details.
		/// </summary>
		[CanBeNull]
		[Optional(nameof(IsChatChannelMessage))]
		[WireMember(8)]
		public NetworkChatChannelMessageDetails ChannelMessageDetails { get; internal set; }

		[CanBeNull]
		[Optional(nameof(IsDefaultChatMessage))]
		[WireMember(9)]
		public NetworkChatDefaultMessageDetails DefaultMessageDetails { get; internal set; }

		/// <summary>
		/// These details are sent in all messages.
		/// </summary>
		[WireMember(50)]
		public NetworkChatMessageFooter MessageFooter { get; internal set; }

		//TODO: Optional message data if it was a guild achievement
		
		//TODO: Parameter validation
		/// <inheritdoc />
		public SMSG_MESSAGECHAT_Payload([NotNull] NetworkChatMessageHeader messageHeader, [NotNull] NetworkChatMessageFooter messageFooter, [NotNull] NetworkChatWhisperMessageDetails whisperMessageDetails)
			: this()
		{
			MessageHeader = messageHeader ?? throw new ArgumentNullException(nameof(messageHeader));
			WhisperMessageDetails = whisperMessageDetails ?? throw new ArgumentNullException(nameof(whisperMessageDetails));
			MessageFooter = messageFooter ?? throw new ArgumentNullException(nameof(messageFooter));
		}

		public SMSG_MESSAGECHAT_Payload([NotNull] NetworkChatMessageHeader messageHeader, [NotNull] NetworkChatMessageFooter messageFooter, [NotNull] NetworkChatCreatureMessageDetails creatureMessageDetails)
			: this()
		{
			MessageHeader = messageHeader ?? throw new ArgumentNullException(nameof(messageHeader));
			CreatureMessageDetails = creatureMessageDetails ?? throw new ArgumentNullException(nameof(creatureMessageDetails));
			MessageFooter = messageFooter ?? throw new ArgumentNullException(nameof(messageFooter));
		}

		public SMSG_MESSAGECHAT_Payload([NotNull] NetworkChatMessageHeader messageHeader, [NotNull] NetworkChatMessageFooter messageFooter, [NotNull] NetworkChatChannelMessageDetails channelMessageDetails)
			: this()
		{
			MessageHeader = messageHeader ?? throw new ArgumentNullException(nameof(messageHeader));
			ChannelMessageDetails = channelMessageDetails ?? throw new ArgumentNullException(nameof(channelMessageDetails));
			MessageFooter = messageFooter ?? throw new ArgumentNullException(nameof(messageFooter));
		}

		public SMSG_MESSAGECHAT_Payload([NotNull] NetworkChatMessageHeader messageHeader, [NotNull] NetworkChatMessageFooter messageFooter, [NotNull] NetworkChatDefaultMessageDetails defaultMessageDetails)
			: this()
		{
			MessageHeader = messageHeader ?? throw new ArgumentNullException(nameof(messageHeader));
			DefaultMessageDetails = defaultMessageDetails;
			MessageFooter = messageFooter ?? throw new ArgumentNullException(nameof(messageFooter));
		}

		public SMSG_MESSAGECHAT_Payload()
			: base(NetworkOperationCode.SMSG_MESSAGECHAT)
		{
			//serializer ctor
		}
	}
}
