using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	/// <summary>
	/// Packet payload structure for the <see cref="NetworkOperationCode"/> SMSG_QUESTGIVER_QUEST_LIST.
	/// </summary>
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.SMSG_QUESTGIVER_QUEST_LIST)]
	public sealed partial class SMSG_QUESTGIVER_QUEST_LIST_Payload : GamePacketPayload
	{
		/// <summary>
		/// The GUID of the quest giver.
		/// </summary>
		[WireMember(1)]
		public ObjectGuid QuestGiver { get; internal set; }

		/// <summary>
		/// The quests greeting type.
		/// </summary>
		[WireMember(2)]
		public QuestGreeting Greeting { get; internal set; }

		/// <summary>
		/// The quest entries for the quest list.
		/// </summary>
		[SendSize(PrimitiveSizeType.Byte)]
		[WireMember(3)]
		internal QuestGossipEntry[] _Entries { get; set; }

		[NotMapped]
		public IEnumerable<QuestGossipEntry> Entries => _Entries;

		public SMSG_QUESTGIVER_QUEST_LIST_Payload([NotNull] ObjectGuid questGiver, [NotNull] QuestGreeting greeting, [NotNull] QuestGossipEntry[] entries)
			: this()
		{
			QuestGiver = questGiver ?? throw new ArgumentNullException(nameof(questGiver));
			Greeting = greeting ?? throw new ArgumentNullException(nameof(greeting));
			_Entries = entries ?? throw new ArgumentNullException(nameof(entries));
		}

		/// <summary>
		/// Default Serializer Ctor.
		/// </summary>
		public SMSG_QUESTGIVER_QUEST_LIST_Payload()
			: base(NetworkOperationCode.SMSG_QUESTGIVER_QUEST_LIST)
		{

		}
	}
}
