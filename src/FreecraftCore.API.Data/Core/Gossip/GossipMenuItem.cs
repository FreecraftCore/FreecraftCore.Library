using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	[WireDataContract]
	public sealed class GossipMenuItem
	{
		/// <summary>
		/// The menu id entry.
		/// </summary>
		[WireMember(1)]
		public int EntryId { get; internal set; }

		//TODO: Enumerate this
		[WireMember(2)]
		public byte MenuIconId { get; internal set; }

		/// <summary>
		/// makes pop up box password
		/// </summary>
		[WireMember(3)]
		public bool IsCoded { get; internal set; }

		/// <summary>
		/// money required to open menu, 2.0.3
		/// </summary>
		[WireMember(4)]
		public int RequiredMoney { get; internal set; }

		/// <summary>
		/// text for gossip item
		/// </summary>
		[Encoding(EncodingType.ASCII)]
		[WireMember(5)]
		public string MenuText { get; internal set; }

		/// <summary>
		/// accept text (related to money) pop up box, 2.0.3
		/// </summary>
		[Encoding(EncodingType.ASCII)]
		[WireMember(6)]
		public string OptionalRequiredMoneyText { get; internal set; }

		public GossipMenuItem(int entryId, byte menuIconId, bool isCoded, int requiredMoney, string menuText, string optionalRequiredMoneyText)
		{
			EntryId = entryId;
			MenuIconId = menuIconId;
			IsCoded = isCoded;
			RequiredMoney = requiredMoney;
			MenuText = menuText;
			OptionalRequiredMoneyText = optionalRequiredMoneyText;
		}

		/// <summary>
		/// Serializer ctor.
		/// </summary>
		public GossipMenuItem()
		{
			
		}
	}
}
