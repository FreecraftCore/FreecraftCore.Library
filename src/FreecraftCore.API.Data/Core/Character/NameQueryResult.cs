using System;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	/// <summary>
	/// The name query result model.
	/// </summary>
	[WireDataContract]
	public class NameQueryResult
	{
		/// <summary>
		/// Indicates the name of the unit.
		/// </summary>
		[Encoding(EncodingType.ASCII)]
		[WireMember(1)]
		public string Name { get; internal set; }

		/// <summary>
		/// The name of the realm they're on.
		/// (used for cross-realm; will likely be null)
		/// </summary>
		[Encoding(EncodingType.ASCII)]
		[WireMember(2)]
		public string RealmName { get; internal set; } = "";

		/// <summary>
		/// Indicates the race associated with the guid.
		/// </summary>
		[WireMember(3)]
		public CharacterRace Race { get; internal set; }

		/// <summary>
		/// Indicates the gender associated with the guid.
		/// </summary>
		[WireMember(4)]
		public CharacterGender Gender { get; internal set; }

		/// <summary>
		/// Indicates the class associated with the guid.
		/// </summary>
		[WireMember(5)]
		public CharacterClass Class { get; internal set; }

		//TODO: Handle declined names
		[WireMember(6)]
		public bool IsNameDeclined { get; internal set; }

		/// <inheritdoc />
		public NameQueryResult([NotNull] string name, [CanBeNull] string realmName, CharacterRace race, CharacterGender gender, CharacterClass @class)
		{
			Name = name ?? throw new ArgumentNullException(nameof(name));
			RealmName = realmName ?? ""; //don't check nullness
			Race = race;
			Gender = gender;
			Class = @class;
		}

		public NameQueryResult()
		{
			RealmName = "";
		}
	}
}
