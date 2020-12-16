using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	/// <summary>
	/// Monster Move spline information.
	/// This is optional data sent if the move packet is not a stop packet.
	/// </summary>
	[WireDataContract]
	public sealed class MonsterSplineInfo
	{
		/// <summary>
		/// Default value (or stop value) is <see cref="SplineMoveFlags.None"/>
		/// </summary>
		[WireMember(6)]
		public SplineMoveFlags SplineFlags { get; internal set; } = SplineMoveFlags.None;

		/// <summary>
		/// Indicates if the move information has animation
		/// data <see cref="OptionalAnimationInformation"/>
		/// </summary>
		public bool HasAnimationInformation => SplineFlags.HasFlag(SplineMoveFlags.Animation);

		[Optional(nameof(HasAnimationInformation))]
		[WireMember(7)]
		public AnimationInfo OptionalAnimationInformation { get; internal set; }

		/// <summary>
		/// The duration of the spline.
		/// </summary>
		[WireMember(8)]
		public int SplineDuration { get; internal set; }

		/// <summary>
		/// Indicates if the move information has parabolic spline information.
		/// </summary>
		public bool HasParabolicSplineInfo => SplineFlags.HasFlag(SplineMoveFlags.Parabolic);

		[Optional(nameof(HasParabolicSplineInfo))]
		[WireMember(9)]
		public ParabolicMoveInfo OptionalParabolicSplineInformation { get; internal set; }

		public bool HasLinearPath => !HasCatMulRomSpline;

		/// <summary>
		/// Indicates if the optional cyclic catmulrom spline path information
		/// is in the packet.
		/// </summary>
		public bool HasCatMulRomSpline => (SplineFlags & SplineMoveFlags.Mask_CatmullRom) != 0;

		[SendSize(PrimitiveSizeType.Int32)] //we have to add 1 to the size, it's what TC does
		[Optional(nameof(HasCatMulRomSpline))]
		[WireMember(10)]
		public Vector3<float>[] OptionalCatMulRomSplinePoints { get; internal set; }

		[Optional(nameof(HasLinearPath))]
		[WireMember(11)]
		public LinearPathMoveInfo OptionalLinearPathInformation { get; internal set; }

		//TODO: Overload ctors/builders
		//TODO: Validate params
		/// <inheritdoc />
		public MonsterSplineInfo(SplineMoveFlags splineFlags, AnimationInfo optionalAnimationInformation, int splineDuration, ParabolicMoveInfo optionalParabolicSplineInformation, Vector3<float>[] optionalCatMulRomSplinePoints, LinearPathMoveInfo optionalLinearPathInformation)
		{
			SplineFlags = splineFlags;
			OptionalAnimationInformation = optionalAnimationInformation;
			SplineDuration = splineDuration;
			OptionalParabolicSplineInformation = optionalParabolicSplineInformation;
			OptionalCatMulRomSplinePoints = optionalCatMulRomSplinePoints;
			OptionalLinearPathInformation = optionalLinearPathInformation;
		}

		/// <summary>
		/// Serializer ctor
		/// </summary>
		public MonsterSplineInfo()
		{
			
		}
	}
}
