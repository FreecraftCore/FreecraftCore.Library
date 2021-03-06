using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace FreecraftCore
{
	//CreatureType.dbc
	/// <summary>
	/// Table model for CreatureType.dbc
	/// https://wowdev.wiki/DB/CreatureType
	/// If changes are made then <see cref="ChatLanguage"/> must be updated.
	/// </summary>
	[DBC]
	[WireDataContract]
	[JsonObject]
	[StringDBC(typeof(CreatureTypeEntry<>))]
	[Table("CreatureType")]
	public class CreatureTypeEntry<TStringType> : IDBCEntryIdentifiable
	{
		[NotMapped]
		[JsonIgnore]
		public int EntryId => CreatureTypeId;

		[Key]
		[WireMember(1)]
		public int CreatureTypeId { get; internal set; }

		[WireMember(2)]
		public LocalizedStringDBC<TStringType> Name { get; internal set; }

		[WireMember(3)]
		public CreatureTypeDefinitionFlags Flags { get; internal set; }

		public CreatureTypeEntry(int creatureTypeId, [NotNull] LocalizedStringDBC<TStringType> name, CreatureTypeDefinitionFlags flags)
		{
			if (creatureTypeId <= 0) throw new ArgumentOutOfRangeException(nameof(creatureTypeId));

			CreatureTypeId = creatureTypeId;
			Name = name ?? throw new ArgumentNullException(nameof(name));
			Flags = flags;
		}

		/// <summary>
		/// Serializer ctor.
		/// </summary>
		public CreatureTypeEntry()
		{
			
		}
	}

	public static class CreatureTypeEntryExtensions
	{
		/// <summary>
		/// Indicates if the creature type <see cref="CreatureTypeEntry{TStringType}"/> <see cref="entry"/>
		/// is selectable via tab target selection.
		/// </summary>
		/// <typeparam name="TStringType">String type.</typeparam>
		/// <param name="entry">The creature type entry.</param>
		/// <returns>True if the creature type can be tab targeted to.</returns>
		public static bool IsTabTargetable<TStringType>([NotNull] this CreatureTypeEntry<TStringType> entry)
		{
			if (entry == null) throw new ArgumentNullException(nameof(entry));

			return !entry.Flags.HasFlag(CreatureTypeDefinitionFlags.IgnoreTabTargetting);
		}

		public static CreatureType ToCreatureTypeEnum<TStringType>([NotNull] this CreatureTypeEntry<TStringType> entry)
		{
			if(entry == null) throw new ArgumentNullException(nameof(entry));

			return (CreatureType) entry.CreatureTypeId;
		}
	}
}
