using FreecraftCore.Serializer;

namespace FreecraftCore
{
	[WireDataContract]
	public sealed class StationaryMovementInfo
	{
		[WireMember(1)]
		public Vector3<float> Position { get; internal set; }

		[WireMember(2)]
		public float Orientation { get; internal set; }

		/// <inheritdoc />
		public StationaryMovementInfo(Vector3<float> position, float orientation)
		{
			Position = position;
			Orientation = orientation;
		}

		public StationaryMovementInfo()
		{
			
		}
	}
}
