using FreecraftCore.Serializer;

namespace FreecraftCore
{
	[WireDataContract]
	public sealed class VehicleMovementInfo
	{
		/// <summary>
		/// 
		/// </summary>
		[WireMember(1)]
		public uint VehicleId { get; internal set; }

		[WireMember(2)]
		public float VehicleOrientation { get; internal set; }

		/// <inheritdoc />
		public VehicleMovementInfo(uint vehicleId, float vehicleOrientation)
		{
			VehicleId = vehicleId;
			VehicleOrientation = vehicleOrientation;
		}

		public VehicleMovementInfo()
		{
			
		}
	}
}
