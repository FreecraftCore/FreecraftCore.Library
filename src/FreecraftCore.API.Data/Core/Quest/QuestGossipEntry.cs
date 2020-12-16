using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	[WireDataContract]
	public sealed class QuestGossipEntry
	{
		[WireMember(1)]
		public int QuestId { get; internal set; }

		//TODO: What is the enumeration for this. Seems to change for status.
		//NOT RELATED TO ICON DBC.
		[WireMember(2)]
		public int QuestIcon { get; internal set; }

		[WireMember(3)]
		public int QuestLevel { get; internal set; }

		[WireMember(4)]
		public QuestFlags Flags { get; internal set; }

		[WireMember(5)]
		public bool IsRepeatable { get; internal set; }

		//Max 0x200 according to TC
		[Encoding(EncodingType.ASCII)]
		[WireMember(6)]
		public string QuestTitle { get; internal set; }

		public QuestGossipEntry(int questId, int questIcon, int questLevel, QuestFlags flags, bool isRepeatable, string questTitle)
		{
			QuestId = questId;
			QuestIcon = questIcon;
			QuestLevel = questLevel;
			Flags = flags;
			IsRepeatable = isRepeatable;
			QuestTitle = questTitle;
		}

		public QuestGossipEntry()
		{
			
		}
	}
}
