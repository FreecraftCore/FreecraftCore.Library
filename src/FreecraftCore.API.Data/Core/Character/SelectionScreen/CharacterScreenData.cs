using System;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	[WireDataContract]
	public sealed class CharacterScreenData
	{
		/// <summary>
		/// The GUID of the character.
		/// </summary>
		[WireMember(1)]
		public ObjectGuid CharacterGuid { get; internal set; }

		/// <summary>
		/// The character's name.
		/// </summary>
		[WireMember(2)]
		public string CharacterName { get; internal set; } //null terminated

		/// <summary>
		/// The character's race.
		/// </summary>
		[WireMember(3)]
		public CharacterRace Race { get; internal set; }

		/// <summary>
		/// The class of the character.
		/// </summary>
		[WireMember(4)]
		public CharacterClass Class { get; internal set; }

		/// <summary>
		/// The gender setting of the character.
		/// </summary>
		[WireMember(5)]
		public CharacterGender Gender { get; internal set; }

		//TODO: Implement the looks
		//This is uint8 Skin, uint8 Face, uint8 Hairstyle, uint8 hairColor, uint8 facialStyle
		[KnownSize(5)] //is sent as 5 bytes in JackPoz's setup
		[WireMember(6)]
		public byte[] UnknownBytesOne { get; internal set; }

		/// <summary>
		/// The character's level.
		/// </summary>
		[WireMember(7)]
		public byte CharacterLevel { get; internal set; }

		[WireMember(8)]
		public TempLocationStructure Location { get; internal set; }

		[WireMember(9)]
		public uint GuildId { get; internal set; }

		//TODO: See Trinitycore's HandleCharEnum to see how these flags look and implement it
		[WireMember(10)]
		public uint CharacterFlags { get; internal set; }

		/// <inheritdoc />
		public CharacterScreenData([NotNull] ObjectGuid characterGuid, [NotNull] string characterName, CharacterRace race, CharacterClass @class, CharacterGender gender, [NotNull] byte[] unknownBytesOne, byte characterLevel, [NotNull] TempLocationStructure location, uint guildId, uint characterFlags)
		{
			CharacterGuid = characterGuid ?? throw new ArgumentNullException(nameof(characterGuid));
			CharacterName = characterName ?? throw new ArgumentNullException(nameof(characterName));
			Race = race;
			Class = @class;
			Gender = gender;
			UnknownBytesOne = unknownBytesOne ?? throw new ArgumentNullException(nameof(unknownBytesOne));
			CharacterLevel = characterLevel;
			Location = location ?? throw new ArgumentNullException(nameof(location));
			GuildId = guildId;
			CharacterFlags = characterFlags;
		}

		/// <summary>
		/// Serializer ctor.
		/// </summary>
		public CharacterScreenData()
		{
			
		}
	}
}
