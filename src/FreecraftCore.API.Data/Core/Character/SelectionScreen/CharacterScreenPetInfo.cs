using FreecraftCore.Serializer;

namespace FreecraftCore
{
	[WireDataContract]
	public class CharacterScreenPetInfo
	{
		//TODO: Figure out what any of this means
		[WireMember(1)]
		public uint PetInformationId { get; internal set; }

		[WireMember(2)]
		public uint PetLevel { get; internal set; }

		[WireMember(3)]
		public uint PetFamilyId { get; internal set; }

		public CharacterScreenPetInfo()
		{
			//serializer ctor
		}
	}
}
