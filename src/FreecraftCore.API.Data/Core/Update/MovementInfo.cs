using FreecraftCore.Serializer;

namespace FreecraftCore
{
	[WireDataContract]
	public sealed class MovementInfo : IPlayerMovementDatable<MovementFlag>
	{
		/// <summary>
		/// TODO DOC
		/// </summary>
		[WireMember(1)]
		public MovementFlag MoveFlags { get; internal set; }

		//ClientVersion.AddedInVersion(ClientVersionBuild.V3_0_2_9056) previous to 3.0 it was a byte.
		[WireMember(2)]
		public MovementFlagExtra ExtraFlags { get; internal set; }

		//TODO: Support packed date time? Or is this milliseconds?
		/// <summary>
		/// Went sent by the player (client) this is MILLISECONDS
		/// and it represents the milliseconds since the local system (client's PC) started.
		/// </summary>
		[WireMember(3)]
		public uint TimeStamp { get; internal set; }

		/// <summary>
		/// The Vector3 x,y,z position.
		/// </summary>
		[WireMember(4)]
		public Vector3<float> Position { get; internal set; }

		/// <summary>
		/// Probably Y axis rotation.
		/// </summary>
		[WireMember(5)]
		public float Orientation { get; internal set; }

		public bool IsOnTransport => MoveFlags.HasFlag(MovementFlag.MOVEMENTFLAG_ONTRANSPORT);

		public bool HasTransportationTime => IsOnTransport && ExtraFlags.HasFlag(MovementFlagExtra.InterpolateMove);

		//Note, important to use HasAnyFlags as it checks if EITHER flag is set
		public bool HasMovementPitch => MoveFlags.HasAnyFlags(MovementFlag.MOVEMENTFLAG_SWIMMING | MovementFlag.MOVEMENTFLAG_FLYING)
			|| ExtraFlags.HasFlag(MovementFlagExtra.AlwaysAllowPitching);

		public bool IsFalling => MoveFlags.HasFlag(MovementFlag.MOVEMENTFLAG_FALLING);

		public bool HasSplineElevation => MoveFlags.HasFlag(MovementFlag.MOVEMENTFLAG_SPLINE_ELEVATION);

		[Optional(nameof(IsOnTransport))]
		[WireMember(6)]
		public TransportationInfo TransportationInformation { get; internal set; }

		[Optional(nameof(HasTransportationTime))]
		[WireMember(7)]
		public int TransportationTime { get; internal set; }

		//AKA: Swim Pitch
		[Optional(nameof(HasMovementPitch))]
		[WireMember(8)]
		public float MovePitch { get; internal set; }

		//Always read for some reason
		[WireMember(9)]
		public int FallTime { get; internal set; }

		//TODO: Refactor/encapsulate
		//Optional fall data
		[Optional(nameof(IsFalling))]
		[WireMember(10)]
		public Vector4<float> FallData { get; internal set; }

		//This is a hack though?
		[Optional(nameof(HasSplineElevation))]
		[WireMember(11)]
		public float SplineElevation { get; internal set; }

		//TODO: Parameter validation
		/// <inheritdoc />
		public MovementInfo(MovementFlag movementFlags, MovementFlagExtra extraFlags, uint timeStamp, Vector3<float> position, float orientation, TransportationInfo transportationInformation, int transportationTime, float movePitch, int fallTime, Vector4<float> fallData, float splineElevation)
		{
			MoveFlags = movementFlags;
			ExtraFlags = extraFlags;
			TimeStamp = timeStamp;
			Position = position;
			Orientation = orientation;
			TransportationInformation = transportationInformation;
			TransportationTime = transportationTime;
			MovePitch = movePitch;
			FallTime = fallTime;
			FallData = fallData;
			SplineElevation = splineElevation;
		}
		
		/// <summary>
		/// Serializer ctor.
		/// </summary>
		public MovementInfo()
		{
			
		}
	}
}
