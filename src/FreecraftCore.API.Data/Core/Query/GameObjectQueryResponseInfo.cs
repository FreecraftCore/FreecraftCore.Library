using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	[WireDataContract]
	public sealed class GameObjectQueryResponseInfo
	{
		//TODO: Get enum for this
		[WireMember(1)]
		public int GameObjectType { get; internal set; }

		[WireMember(2)]
		public int DisplayId { get; internal set; }

		[Encoding(EncodingType.ASCII)]
		[KnownSize(4)]
		[WireMember(3)]
		public string[] Names { get; internal set; }

		[Encoding(EncodingType.ASCII)]
		[WireMember(4)]
		public string IconName { get; internal set; }

		[Encoding(EncodingType.ASCII)]
		[WireMember(5)]
		public string CastBarCaption { get; internal set; }

		[Encoding(EncodingType.ASCII)]
		[WireMember(6)]
		public string UnkString { get; internal set; }

		[WireMember(7)]
		[KnownSize(sizeof(int) * 24)]
		public byte[] Data { get; internal set; }

		[WireMember(8)]
		public float Size { get; internal set; }

		[KnownSize(6)]
		[WireMember(9)]
		public int[] QuestItemIds { get; internal set; }

		/// <inheritdoc />
		public GameObjectQueryResponseInfo(int gameObjectType, int displayId, string[] names, string iconName, string castBarCaption, string unkString, byte[] data, float size, int[] questItemIds)
		{
			GameObjectType = gameObjectType;
			DisplayId = displayId;
			Names = names;
			IconName = iconName;
			CastBarCaption = castBarCaption;
			UnkString = unkString;
			Data = data;
			Size = size;
			QuestItemIds = questItemIds;
		}

		public GameObjectQueryResponseInfo()
		{
			
		}
	}
}
