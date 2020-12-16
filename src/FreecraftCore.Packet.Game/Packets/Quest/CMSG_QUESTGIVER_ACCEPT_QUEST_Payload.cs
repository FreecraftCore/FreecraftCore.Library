using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	/// <summary>
	/// Packet payload structure for the <see cref="NetworkOperationCode"/> CMSG_QUESTGIVER_ACCEPT_QUEST.
	/// </summary>
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.CMSG_QUESTGIVER_ACCEPT_QUEST)]
	public sealed partial class CMSG_QUESTGIVER_ACCEPT_QUEST_Payload : GamePacketPayload
	{
		/// <summary>
		/// The <see cref="ObjectGuid"/> of the quest giver.
		/// </summary>
		[WireMember(1)]
		public ObjectGuid QuestGiver { get; internal set; }

		/// <summary>
		/// The id of the quest.
		/// </summary>
		[WireMember(2)]
		public int QuestId { get; internal set; }

		//TODO: TrinityCore reads this but does nothing with it.
		[WireMember(3)]
		internal int StartCheat { get; set; } =  0;

		public CMSG_QUESTGIVER_ACCEPT_QUEST_Payload([NotNull] ObjectGuid questGiver, int questId)
			: this()
		{
			QuestGiver = questGiver ?? throw new ArgumentNullException(nameof(questGiver));
			QuestId = questId;
		}

		/// <summary>
		/// Default Serializer Ctor.
		/// </summary>
		public CMSG_QUESTGIVER_ACCEPT_QUEST_Payload()
			: base(NetworkOperationCode.CMSG_QUESTGIVER_ACCEPT_QUEST)
		{

		}
	}
}
