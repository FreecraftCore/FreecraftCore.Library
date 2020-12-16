using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	[WireDataContract]
	public sealed class CreatureQueryResponseInfo
	{
		[Encoding(EncodingType.ASCII)]
		[WireMember(1)]
		[KnownSize(4)]
		public string[] CreatureNames { get; internal set; }

		[Encoding(EncodingType.ASCII)]
		[WireMember(2)]
		public string AlternativeName { get; internal set; }

		[Encoding(EncodingType.ASCII)]
		[WireMember(3)]
		public string CursorName { get; internal set; }

		//TODO: Find the enum for this
		[WireMember(4)]
		public CreatureTypeFlags Flags { get; internal set; }

		[WireMember(5)]
		public CreatureType CreatureType { get; internal set; }

		[WireMember(6)]
		public CreatureFamily Family { get; internal set; }

		[WireMember(7)]
		public CreatureEliteType Classification { get; internal set; }

		[KnownSize(2)]
		[WireMember(8)]
		public int[] ProxyCreatureIds { get; internal set; }

		[KnownSize(4)]
		[WireMember(9)]
		public int[] CreatureDisplayIds { get; internal set; }

		[WireMember(10)]
		public float HealthMultiplier { get; internal set; }

		[WireMember(11)]
		public float EnergyMultiplier { get; internal set; }

		//TODO: What does this mean?
		[WireMember(12)]
		public bool IsLeader { get; internal set; }

		[KnownSize(6)]
		[WireMember(13)]
		public int[] QuestItemIds { get; internal set; }

		[WireMember(14)]
		public int CreatureMovementInfoId { get; internal set; }

		//TODO: Validate parameters
		//TODO: Ctor overloads
		/// <inheritdoc />
		public CreatureQueryResponseInfo(string[] creatureNames, string alternativeName, string cursorName, CreatureTypeFlags flags, CreatureType creatureType, CreatureFamily family, CreatureEliteType classification, int[] proxyCreatureIds, int[] creatureDisplayIds, float healthMultiplier, float energyMultiplier, bool isLeader, int[] questItemIds, int creatureMovementInfoId)
		{
			CreatureNames = creatureNames;
			AlternativeName = alternativeName;
			CursorName = cursorName;
			Flags = flags;
			CreatureType = creatureType;
			Family = family;
			Classification = classification;
			ProxyCreatureIds = proxyCreatureIds;
			CreatureDisplayIds = creatureDisplayIds;
			HealthMultiplier = healthMultiplier;
			EnergyMultiplier = energyMultiplier;
			IsLeader = isLeader;
			QuestItemIds = questItemIds;
			CreatureMovementInfoId = creatureMovementInfoId;
		}

		public CreatureQueryResponseInfo()
		{
			
		}
	}
}
