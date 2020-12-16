using System;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.CMSG_TEXT_EMOTE)]
	[ProtocolGrouping(ProtocolCode.Game)] //TODO: Change this protocol to something more specific
	public partial class EmoteChatMessageRequest : GamePacketPayload
	{
		/// <inheritdoc />
		public override bool isValid { get; } = true;

		[WireMember(1)]
		public TextEmotes Emote { get; internal set; }

		[WireMember(2)]
		public uint UnknownEmoteNumber { get; internal set; }

		[WireMember(3)]
		public ObjectGuid EmoteTarget { get; internal set; }

		public EmoteChatMessageRequest(TextEmotes emote, uint emoteNumber, ObjectGuid guid)
			: this()
		{
			if (!Enum.IsDefined(typeof(TextEmotes), emote))
				throw new ArgumentOutOfRangeException(nameof(emote), "Value should be defined in the TextEmotes enum.");

			UnknownEmoteNumber = emoteNumber;
			Emote = emote;
			EmoteTarget = guid;
		}

		public EmoteChatMessageRequest()
			: base(NetworkOperationCode.CMSG_TEXT_EMOTE)
		{
			//serializer ctor
		}
	}
}
