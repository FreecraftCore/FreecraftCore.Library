using System;
using System.Collections.Generic;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	/// <summary>
	/// Represents a single character for the selection screen.
	/// </summary>
	[WireDataContract]
	public class CharacterScreenCharacter
	{
		[WireMember(1)]
		public CharacterScreenData Data { get; internal set; }

		//This is not sent in 1.12.1/mangos/cmangos
		//TODO: See Trinitycore's HandleCharEnum to see how the selection customization optional flags are set
		[WireMember(11)]
		public uint SelectionFlags { get; internal set; }

		/// <summary>
		/// Indicates if this is the first login by the account.
		/// </summary>
		[WireMember(12)]
		public bool isFirstLogin { get; internal set; } //This may be used to tell it to go to character customization?

		/// <summary>
		/// The visual display pet information.
		/// </summary>
		[WireMember(13)]
		public CharacterScreenPetInfo PetInformation { get; internal set; }

		/// <summary>
		/// Represents the display IDs of the various items equipped by a character so that
		/// the client can render it.
		/// </summary>
		[KnownSize(19)] //Jackpoz has this set as 20 items but reads length - 1 and Trinitycore sends 19 items. SO THERE ARE 19!!
		[WireMember(14)]
		internal CharacterScreenItem[] _VisualEquipmentItems { get; set; }

		//TODO: Why is this sent?
		[KnownSize(4)] //jackpoz bot shows they send 4 bags
		[WireMember(15)]
		internal CharacterScreenBag[] _Bags { get; set; }

		/// <summary>
		/// Represents the display IDs of the various items equipped by a character so that
		/// the client can render it.
		/// </summary>
		public IEnumerable<CharacterScreenItem> VisualEquipmentItems => _VisualEquipmentItems;

		/// <inheritdoc />
		public CharacterScreenCharacter([NotNull] CharacterScreenData data, uint selectionFlags, bool isFirstLogin, [NotNull] CharacterScreenPetInfo petInformation, [NotNull] CharacterScreenItem[] visualEquipmentItems, [NotNull] CharacterScreenBag[] bags)
		{
			Data = data ?? throw new ArgumentNullException(nameof(data));
			SelectionFlags = selectionFlags;
			this.isFirstLogin = isFirstLogin;
			PetInformation = petInformation ?? throw new ArgumentNullException(nameof(petInformation));
			_VisualEquipmentItems = visualEquipmentItems ?? throw new ArgumentNullException(nameof(visualEquipmentItems));
			_Bags = bags ?? throw new ArgumentNullException(nameof(bags));
		}

		public CharacterScreenCharacter()
		{
			
		}
	}
}
