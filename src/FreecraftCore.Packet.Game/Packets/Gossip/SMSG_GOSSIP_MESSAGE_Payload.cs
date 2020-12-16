using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	/// <summary>
	/// Packet payload structure for the <see cref="NetworkOperationCode"/> SMSG_GOSSIP_MESSAGE.
	/// </summary>
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.SMSG_GOSSIP_MESSAGE)]
	public sealed partial class SMSG_GOSSIP_MESSAGE_Payload : GamePacketPayload
	{
		/// <summary>
		/// The GUID of the gossip source.
		/// </summary>
		[WireMember(1)]
		public ObjectGuid GossipSource { get; internal set; }

		/// <summary>
		/// ID of the gossip menu.
		/// TODO: What is this used for??
		/// </summary>
		[WireMember(2)]
		public int MenuId { get; internal set; }

		/// <summary>
		/// The id of the title text.
		/// TODO: What for?
		/// </summary>
		[WireMember(3)]
		public int TitleTextId { get; internal set; }

		[SendSize(PrimitiveSizeType.Int32)]
		[WireMember(4)]
		internal GossipMenuItem[] _GossipOptions { get; set; }

		/// <summary>
		/// The gossip/menu entry/options for the gossip.
		/// </summary>
		[NotMapped]
		public IEnumerable<GossipMenuItem> GossipOptions => _GossipOptions;

		[SendSize(PrimitiveSizeType.Int32)]
		[WireMember(5)]
		internal QuestGossipEntry[] _QuestOptions { get; set; }

		[NotMapped]
		public IEnumerable<QuestGossipEntry> QuestOptions => _QuestOptions;

		public SMSG_GOSSIP_MESSAGE_Payload([NotNull] ObjectGuid gossipSource, int menuId, int titleTextId, [NotNull] GossipMenuItem[] gossipOptions, [NotNull] QuestGossipEntry[] questOptions)
			: this()
		{
			GossipSource = gossipSource ?? throw new ArgumentNullException(nameof(gossipSource));
			MenuId = menuId;
			TitleTextId = titleTextId;
			_GossipOptions = gossipOptions ?? throw new ArgumentNullException(nameof(gossipOptions));
			_QuestOptions = questOptions ?? throw new ArgumentNullException(nameof(questOptions));
		}

		/// <summary>
		/// Default Serializer Ctor.
		/// </summary>
		public SMSG_GOSSIP_MESSAGE_Payload()
			: base(NetworkOperationCode.SMSG_GOSSIP_MESSAGE)
		{

		}
	}
}
