﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace FreecraftCore
{
	//ChrRaces.dbc
	/// <summary>
	/// Table model for ChrRaces.dbc
	/// https://wowdev.wiki/DB/ChrRaces
	/// </summary>
	[DBC]
	[WireDataContract]
	[JsonObject]
	[StringDBC(typeof(ChrRacesEntry<>))]
	[Table("ChrRaces")]
	public class ChrRacesEntry<TStringType> : IDBCEntryIdentifiable 
		where TStringType : class
	{
		public static readonly string[] INTERNAL_FIELD_NAMES = new string[] { nameof(RaceId), nameof(ExpansionId) };

		[NotMapped]
		[JsonIgnore]
		public uint EntryId => (uint) RaceId;

		[Key]
		[WireMember(1)]
		internal int RaceId { get; private set; }

		/// <summary>
		/// The race of the entry.
		/// </summary>
		[JsonIgnore]
		[NotMapped]
		public CharacterRace Race => (CharacterRace) RaceId;

		[WireMember(2)]
		public CharacterRaceFlags Flags { get; private set; }

		/// <summary>
		/// Foreign key reference to <see cref="FactionTemplateEntry"/>.
		/// Faction template id. The order in the creation screen depends on this.
		/// </summary>
		[WireMember(3)]
		public int FactionTemplateId { get; private set; }

		[JsonIgnore]
		[ForeignKey(nameof(FactionTemplateId))]
		public virtual FactionTemplateEntry FactionTemplate { get; private set; }

		/// <summary>
		/// Nullable.
		/// Played on exploring zones with SMSG_EXPLORATION_EXPERIENCE.
		/// See: <see cref="SoundEntriesEntry{TStringType}"/>
		/// </summary>
		[WireMember(4)]
		public int ExplorationSoundId { get; private set; }

		/// <summary>
		/// Non-nullable.
		/// Default <see cref="CreatureDisplayInfoEntry{TStringType}"/> id for this race.
		/// only used for the char creation/selection screen. Ingame the server sets the model.
		/// </summary>
		[WireMember(5)]
		public int DefaultMaleDisplayInfoId { get; private set; }

		/// <summary>
		/// Non-nullable.
		/// Default <see cref="CreatureDisplayInfoEntry{TStringType}"/> id for this race.
		/// only used for the char creation/selection screen. Ingame the server sets the model.
		/// </summary>
		[ForeignKey(nameof(DefaultMaleDisplayInfoId))]
		[JsonIgnore]
		public virtual CreatureDisplayInfoEntry<TStringType> DefaultMaleDisplayInfo { get; private set; }

		/// <summary>
		/// Non-nullable.
		/// Default <see cref="CreatureDisplayInfoEntry{TStringType}"/> id for this race.
		/// only used for the char creation/selection screen. Ingame the server sets the model.
		/// </summary>
		[WireMember(6)]
		public int DefaultFemaleDisplayInfoId { get; private set; }

		/// <summary>
		/// Non-nullable.
		/// Default <see cref="CreatureDisplayInfoEntry{TStringType}"/> id for this race.
		/// only used for the char creation/selection screen. Ingame the server sets the model.
		/// </summary>
		[ForeignKey(nameof(DefaultFemaleDisplayInfoId))]
		[JsonIgnore]
		public virtual CreatureDisplayInfoEntry<TStringType> DefaultFemaleDisplayInfo { get; private set; }

		/// <summary>
		/// A short form of the name. Used for helmet models.
		/// </summary>
		[WireMember(7)]
		public TStringType RacePrefix { get; private set; }

		/// <summary>
		/// Non-nullable.
		/// See: <see cref="LanguagesEntry{TStringType}"/>
		/// </summary>
		[WireMember(8)]
		public int BaseLanguageId { get; private set; }

		/// <summary>
		/// Non-nullable.
		/// See: <see cref="LanguagesEntry{TStringType}"/>
		/// </summary>
		[ForeignKey(nameof(BaseLanguageId))]
		[JsonIgnore]
		public virtual LanguagesEntry<TStringType> BaseLanguage { get; private set; }

		/// <summary>
		/// Non-nullable.
		/// See: <see cref="CreatureTypeEntry{TStringType}"/>
		/// </summary>
		[WireMember(9)]
		public int CreatureTypeId { get; private set; }

		/// <summary>
		/// Non-nullable.
		/// See: <see cref="CreatureTypeEntry{TStringType}"/>
		/// In Blizzlike this is Always 7 (humanoid).
		/// </summary>
		[ForeignKey(nameof(CreatureTypeId))]
		[JsonIgnore]
		public virtual CreatureTypeEntry<TStringType> CreatureType { get; private set; }

		/// <summary>
		/// Non-nullable.
		/// See: <see cref="SpellEntry{TStringType}"/>
		/// </summary>
		[WireMember(10)]
		public int ResSicknessSpellId { get; private set; }

		/// <summary>
		/// Non-nullable.
		/// See: <see cref="SpellEntry{TStringType}"/>
		/// </summary>
		[ForeignKey(nameof(ResSicknessSpellId))]
		[JsonIgnore]
		public virtual SpellEntry<TStringType> ResSicknessSpell { get; private set; }

		/// <summary>
		/// Non-nullable
		/// See: <see cref="SoundEntriesEntry{TStringType}"/>
		/// </summary>
		[WireMember(11)]
		public int SplashSoundId { get; private set; }

		/// <summary>
		/// Non-nullable
		/// See: <see cref="SoundEntriesEntry{TStringType}"/>
		/// </summary>
		[ForeignKey(nameof(SplashSoundId))]
		[JsonIgnore]
		public virtual SoundEntriesEntry<TStringType> SplashSound { get; private set; }

		[WireMember(12)]
		public TStringType ClientFileString { get; private set; }

		/// <summary>
		/// Nullable.
		/// See: <see cref="CinematicSequencesEntry"/>
		/// </summary>
		[WireMember(13)]
		public int CinematicSequenceId { get; private set; }

		/// <summary>
		/// For blizzlike this value is:
		/// 0 - Alliance
		/// 1 - Horde
		/// 2 - Non-playable
		/// </summary>
		[WireMember(14)]
		public int Alliance { get; private set; }

		[WireMember(15)]
		public LocalizedStringDBC<TStringType> Name { get; private set; }

		[WireMember(16)]
		public LocalizedStringDBC<TStringType> FemaleName { get; private set; }

		[WireMember(17)]
		public LocalizedStringDBC<TStringType> MaleName { get; private set; }

		[Column(nameof(FacialCustomizationName) + "_Internal")]
		[WireMember(18)]
		public TStringType FacialCustomizationNameInternal { get; private set; }

		[WireMember(19)]
		public TStringType FacialCustomizationName { get; private set; }

		[WireMember(20)]
		public TStringType HairCustomizationName { get; private set; }

		[WireMember(21)]
		internal int ExpansionId { get; private set; }

		[JsonIgnore]
		[NotMapped]
		public Expansions Expansion => (Expansions) ExpansionId;

		public ChrRacesEntry(int raceId, CharacterRaceFlags flags, int factionTemplateId, int explorationSoundId, int defaultMaleDisplayInfoId, int defaultFemaleDisplayInfoId, [NotNull] TStringType racePrefix, int baseLanguageId, int creatureTypeId, int resSicknessSpellId, int splashSoundId, [NotNull] TStringType clientFileString, int cinematicSequenceId, int alliance, [NotNull] LocalizedStringDBC<TStringType> name, [NotNull] LocalizedStringDBC<TStringType> femaleName, [NotNull] LocalizedStringDBC<TStringType> maleName, [NotNull] TStringType facialCustomizationNameInternal, [NotNull] TStringType facialCustomizationInternalName, [NotNull] TStringType hairCustomizationName, int expansionId)
		{
			if (raceId <= 0) throw new ArgumentOutOfRangeException(nameof(raceId));
			if (factionTemplateId <= 0) throw new ArgumentOutOfRangeException(nameof(factionTemplateId));
			if (defaultMaleDisplayInfoId <= 0) throw new ArgumentOutOfRangeException(nameof(defaultMaleDisplayInfoId));
			if (defaultFemaleDisplayInfoId <= 0) throw new ArgumentOutOfRangeException(nameof(defaultFemaleDisplayInfoId));
			if (baseLanguageId <= 0) throw new ArgumentOutOfRangeException(nameof(baseLanguageId));
			if (creatureTypeId <= 0) throw new ArgumentOutOfRangeException(nameof(creatureTypeId));
			if (resSicknessSpellId <= 0) throw new ArgumentOutOfRangeException(nameof(resSicknessSpellId));
			if (resSicknessSpellId <= 0) throw new ArgumentOutOfRangeException(nameof(resSicknessSpellId));
			if (splashSoundId <= 0) throw new ArgumentOutOfRangeException(nameof(splashSoundId));

			RaceId = raceId;
			Flags = flags;
			FactionTemplateId = factionTemplateId;
			ExplorationSoundId = explorationSoundId;
			DefaultMaleDisplayInfoId = defaultMaleDisplayInfoId;
			DefaultFemaleDisplayInfoId = defaultFemaleDisplayInfoId;
			RacePrefix = racePrefix ?? throw new ArgumentNullException(nameof(racePrefix));
			BaseLanguageId = baseLanguageId;
			CreatureTypeId = creatureTypeId;
			ResSicknessSpellId = resSicknessSpellId;
			SplashSoundId = splashSoundId;
			ClientFileString = clientFileString ?? throw new ArgumentNullException(nameof(clientFileString));
			CinematicSequenceId = cinematicSequenceId;
			Alliance = alliance;
			Name = name ?? throw new ArgumentNullException(nameof(name));
			FemaleName = femaleName ?? throw new ArgumentNullException(nameof(femaleName));
			MaleName = maleName ?? throw new ArgumentNullException(nameof(maleName));
			FacialCustomizationNameInternal = facialCustomizationNameInternal ?? throw new ArgumentNullException(nameof(facialCustomizationNameInternal));
			FacialCustomizationName = facialCustomizationInternalName ?? throw new ArgumentNullException(nameof(facialCustomizationInternalName));
			HairCustomizationName = hairCustomizationName ?? throw new ArgumentNullException(nameof(hairCustomizationName));
			ExpansionId = expansionId;
		}

		/// <summary>
		/// Serializer ctor.
		/// </summary>
		public ChrRacesEntry()
		{
			
		}
	}
}