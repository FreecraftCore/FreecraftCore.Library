using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	/// <summary>
	/// Packet payload structure for the <see cref="NetworkOperationCode"/> CMSG_QUESTGIVER_CHOOSE_REWARD.
	/// Packet is used to turn-in or complete a quest. Even for quests that don't select a reward
	/// this is actually sent. Probably with index 0 for the reward slot.
	/// </summary>
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.CMSG_QUESTGIVER_CHOOSE_REWARD)]
	public sealed partial class CMSG_QUESTGIVER_CHOOSE_REWARD_Payload : GamePacketPayload
	{
		/// <summary>
		/// The <see cref="ObjectGuid"/> of the quest giver.
		/// </summary>
		[WireMember(1)]
		public ObjectGuid QuestGiver { get; internal set; }

		/// <summary>
		/// The quest id.
		/// </summary>
		[WireMember(2)]
		public int QuestId { get; internal set; }

		/// <summary>
		/// The reward slot to claim.
		/// Should be 0 if none.
		/// </summary>
		[WireMember(3)]
		public int RewardSlot { get; internal set; }

		public CMSG_QUESTGIVER_CHOOSE_REWARD_Payload([NotNull] ObjectGuid questGiver, int questId, int rewardSlot)
			: this()
		{
			if (questId <= 0) throw new ArgumentOutOfRangeException(nameof(questId));
			if (rewardSlot < 0) throw new ArgumentOutOfRangeException(nameof(rewardSlot));

			QuestGiver = questGiver ?? throw new ArgumentNullException(nameof(questGiver));
			QuestId = questId;
			RewardSlot = rewardSlot;
		}

		/// <summary>
		/// Default Serializer Ctor.
		/// </summary>
		public CMSG_QUESTGIVER_CHOOSE_REWARD_Payload()
			: base(NetworkOperationCode.CMSG_QUESTGIVER_CHOOSE_REWARD)
		{

		}
	}
}
