using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	/// <summary>
	/// Packet payload structure for the <see cref="NetworkOperationCode"/> CMSG_QUESTGIVER_COMPLETE_QUEST.
	/// Represents just a REQUEST to complete a quest. It can be thought of conceptually
	/// as a Try Complete. The server may redirect to Required Items page or Complete page
	/// through afew different packets.
	/// </summary>
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.CMSG_QUESTGIVER_COMPLETE_QUEST)]
	public sealed partial class CMSG_QUESTGIVER_COMPLETE_QUEST_Payload : GamePacketPayload
	{
		/// <summary>
		/// The <see cref="ObjectGuid"/> of the quest giver.
		/// </summary>
		[WireMember(1)]
		public ObjectGuid QuestGiver { get; internal set; }

		[WireMember(2)]
		public int QuestId { get; internal set; }

		public CMSG_QUESTGIVER_COMPLETE_QUEST_Payload([NotNull] ObjectGuid questGiver, int questId)
			: this()
		{
			QuestGiver = questGiver ?? throw new ArgumentNullException(nameof(questGiver));
			QuestId = questId;
		}

		/// <summary>
		/// Default Serializer Ctor.
		/// </summary>
		public CMSG_QUESTGIVER_COMPLETE_QUEST_Payload()
			: base(NetworkOperationCode.CMSG_QUESTGIVER_COMPLETE_QUEST)
		{

		}
	}
}
