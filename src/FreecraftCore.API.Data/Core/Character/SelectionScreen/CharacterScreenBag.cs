using FreecraftCore.Serializer;

namespace FreecraftCore
{
	/// <summary>
	/// Represents the bags on the character screen.
	/// Mostly unknown values.
	/// </summary>
	[WireDataContract]
	public class CharacterScreenBag
	{
		//TODO: Figure out what these values are or do
		[WireMember(1)]
		internal uint UnknownOne { get; set; }

		[WireMember(2)]
		internal byte UnknownTwo { get; set; }

		[WireMember(3)]
		internal uint UnknownThree { get; set; }

		/// <inheritdoc />
		public CharacterScreenBag(uint unknownOne, byte unknownTwo, uint unknownThree)
		{
			UnknownOne = unknownOne;
			UnknownTwo = unknownTwo;
			UnknownThree = unknownThree;
		}

		public CharacterScreenBag()
		{
			//serializer ctor
		}
	}
}
