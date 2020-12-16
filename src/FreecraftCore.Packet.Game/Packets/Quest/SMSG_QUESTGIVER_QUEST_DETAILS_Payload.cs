using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	/// <summary>
	/// Packet payload structure for the <see cref="NetworkOperationCode"/> SMSG_QUESTGIVER_QUEST_DETAILS.
	/// </summary>
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.SMSG_QUESTGIVER_QUEST_DETAILS)]
	public sealed partial class SMSG_QUESTGIVER_QUEST_DETAILS_Payload : GamePacketPayload
	{
		//This is not a complete/full implementation
		//I have decided to pull down quest data over HTTP instead
		//of rely on this packet.
		/// <summary>
		/// The <see cref="ObjectGuid"/> of the entity offering the quest.
		/// </summary>
		[WireMember(1)]
		public ObjectGuid QuestGiver { get; internal set; }

		/// <summary>
		/// The optional quest sharer guid.
		/// </summary>
		[WireMember(2)]
		public ObjectGuid OptionalQuestSharer { get; internal set; }

		/// <summary>
		/// The quest id.
		/// </summary>
		[WireMember(3)]
		public int QuestId { get; internal set; }

		//There is a lot more data and properties but in all FreecraftCore
		//implementations we pull them down over HTTP instead.

		public SMSG_QUESTGIVER_QUEST_DETAILS_Payload([NotNull] ObjectGuid questGiver, [NotNull] ObjectGuid optionalQuestSharer, int questId)
			: this()
		{
			QuestGiver = questGiver ?? throw new ArgumentNullException(nameof(questGiver));
			OptionalQuestSharer = optionalQuestSharer ?? throw new ArgumentNullException(nameof(optionalQuestSharer));
			QuestId = questId;
		}

		public SMSG_QUESTGIVER_QUEST_DETAILS_Payload([NotNull] ObjectGuid questGiver, int questId)
			: this()
		{
			QuestGiver = questGiver ?? throw new ArgumentNullException(nameof(questGiver));
			QuestId = questId;
		}

		/// <summary>
		/// Default Serializer Ctor.
		/// </summary>
		public SMSG_QUESTGIVER_QUEST_DETAILS_Payload()
			: base(NetworkOperationCode.SMSG_QUESTGIVER_QUEST_DETAILS)
		{

		}
	}
}
