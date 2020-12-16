using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	/// <summary>
	/// Packet payload structure for the <see cref="NetworkOperationCode"/> SMSG_QUESTGIVER_QUEST_COMPLETE.
	/// </summary>
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.SMSG_QUESTGIVER_QUEST_COMPLETE)]
	public sealed partial class SMSG_QUESTGIVER_QUEST_COMPLETE_Payload : GamePacketPayload
	{
		[WireMember(1)]
		public int QuestId { get; internal set; }

		[WireMember(2)]
		public int ExperienceRewarded { get; internal set; }

		[WireMember(3)]
		public int MoneyRewarded { get; internal set; }

		//TODO: There is more stuff here, but not implementing it at this time. See Player::SendQuestReward

		public SMSG_QUESTGIVER_QUEST_COMPLETE_Payload(int questId, int experienceRewarded, int moneyRewarded)
			: this()
		{
			if (questId <= 0) throw new ArgumentOutOfRangeException(nameof(questId));

			QuestId = questId;
			ExperienceRewarded = experienceRewarded;
			MoneyRewarded = moneyRewarded;
		}

		/// <summary>
		/// Default Serializer Ctor.
		/// </summary>
		public SMSG_QUESTGIVER_QUEST_COMPLETE_Payload()
			: base(NetworkOperationCode.SMSG_QUESTGIVER_QUEST_COMPLETE)
		{

		}
	}
}
