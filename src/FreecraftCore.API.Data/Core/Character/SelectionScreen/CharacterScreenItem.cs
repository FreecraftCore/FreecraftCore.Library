using FreecraftCore.Serializer;

namespace FreecraftCore
{
	/// <summary>
	/// Represents an item worn on the character screen.
	/// Mostly unknown or unhandled values right now.
	/// </summary>
	[WireDataContract]
	public class CharacterScreenItem
	{
		//TODO: Find out what this means

		[WireMember(1)]
		public uint DisplayId { get; internal set; }

		//TODO: Find out what this means

		[WireMember(2)]
		public byte InventoryType { get; internal set; }

		//TODO: Find out what this means

		[WireMember(3)]
		internal uint EnchantDisplayId { get; set; }

		public CharacterScreenItem(uint displayId, byte inventoryType, uint enchantDisplayId)
		{
			DisplayId = displayId;
			InventoryType = inventoryType;
			EnchantDisplayId = enchantDisplayId;
		}

		public CharacterScreenItem()
		{
			//serializer ctor
		}
	}
}
