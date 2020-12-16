using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	/// <summary>
	/// Packet payload structure for the <see cref="NetworkOperationCode"/> CMSG_QUESTGIVER_QUERY_QUEST.
	/// </summary>
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.CMSG_QUESTGIVER_QUERY_QUEST)]
	public sealed partial class CMSG_QUESTGIVER_QUERY_QUEST_Payload : GamePacketPayload
	{
		/// <summary>
		/// The <see cref="ObjectGuid"/> of the quest giver.
		/// </summary>
		[WireMember(1)]
		public ObjectGuid QuestGiver { get; internal set; }

		/// <summary>
		/// The ID of the quest to query.
		/// </summary>
		[WireMember(2)]
		public int QuestId { get; internal set; }

		[WireMember(3)]
		internal byte Unk1 { get; set; } = 1; //Usually 1, never seen it not 1 yet.

		public CMSG_QUESTGIVER_QUERY_QUEST_Payload([NotNull] ObjectGuid questGiver, int questId)
			: this()
		{
			QuestGiver = questGiver ?? throw new ArgumentNullException(nameof(questGiver));
			QuestId = questId;
		}

		/// <summary>
		/// Default Serializer Ctor.
		/// </summary>
		public CMSG_QUESTGIVER_QUERY_QUEST_Payload()
			: base(NetworkOperationCode.CMSG_QUESTGIVER_QUERY_QUEST)
		{

		}
	}
}
