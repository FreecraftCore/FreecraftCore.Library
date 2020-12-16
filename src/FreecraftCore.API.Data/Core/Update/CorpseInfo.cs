using FreecraftCore.Serializer;

namespace FreecraftCore
{
	[WireDataContract]
	public sealed class CorpseInfo
	{
		//TODO: What is this?
		/// <summary>
		/// If a Transport object exists then this will be the GUID of the transport.
		/// Otherwise Empty.
		/// </summary>
		[WireMember(1)]
		public PackedGuid TransportGuid { get; internal set; }

		/// <summary>
		/// The absolute coordinate position of the object.
		/// (Usually GameObject)
		/// </summary>
		[WireMember(2)]
		public Vector3<float> GoLocation { get; internal set; }

		/// <summary>
		/// If <see cref="TransportGuid"/> exists then
		/// this will be the transport offset.
		/// Otherwise for some reason it's a copy of <see cref="GoLocation"/>.
		/// </summary>
		[WireMember(3)]
		public Vector3<float> TransportOffset { get; internal set; }

		/// <summary>
		/// Represents Y-Axis orientation.
		/// </summary>
		[WireMember(4)]
		public float Orientation { get; internal set; }

		/// <summary>
		/// If the Unit is TYPID_CORPSE then this is the corpse orientation for the unit.
		/// Otherwise this will be 0. Will be a copy of <see cref="Orientation"/>.
		/// Very Strange!!
		/// </summary>
		[WireMember(5)]
		public float CorpseOrientation { get; internal set; }

		/// <inheritdoc />
		public CorpseInfo(PackedGuid transportGuid, Vector3<float> goLocation, Vector3<float> transportOffset, float orientation, float corpseOrientation)
		{
			TransportGuid = transportGuid;
			GoLocation = goLocation;
			TransportOffset = transportOffset;
			Orientation = orientation;
			CorpseOrientation = corpseOrientation;
		}

		/// <summary>
		/// Serializer ctor.
		/// </summary>
		public CorpseInfo()
		{
			
		}
	}
}
