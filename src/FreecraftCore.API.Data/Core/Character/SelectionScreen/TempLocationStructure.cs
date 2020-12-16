using FreecraftCore.Serializer;

namespace FreecraftCore
{
	//TODO: Replace with something real when we need to actually use this stuff
	/// <summary>
	/// Temporary structure that represents the location of an object
	/// </summary>
	[WireDataContract]
	public sealed class TempLocationStructure
	{
		//TODO: Encapsulate this in a location object when we make it
		[WireMember(1)]
		public uint ZoneId { get; internal set; }

		//TODO: Encapsulate this in a location object when we make it
		[WireMember(2)]
		public uint MapId { get; internal set; }

		//TODO: Encapsulate this in the Vector3 in System.Numerics with SIMD or create a Vector3 class
		[WireMember(3)]
		public float XPosition { get; internal set; }

		[WireMember(4)]
		public float YPosition { get; internal set; }

		[WireMember(5)]
		public float ZPosition { get; internal set; }

		//TODO: Create a real ctor if we ever make a server
		public TempLocationStructure()
		{
			//serializer ctor
		}
	}
}
