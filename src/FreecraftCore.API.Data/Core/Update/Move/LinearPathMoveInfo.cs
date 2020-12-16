using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	[WireDataContract]
	[CustomTypeSerializer(typeof(LinearPathMoveInfoTypeSerializer))]
	public sealed class LinearPathMoveInfo
	{
		/// <summary>
		/// The final index of the path.
		/// </summary>
		//[WireMember(1)]
		public int LastIndex { get; internal set; }

		/// <summary>
		/// The final position of the linear path.
		/// </summary>
		//[WireMember(2)]
		public Vector3<float> FinalPosition { get; internal set; }

		public Vector3<float>[] SplineMiddlePoints { get; internal set; }

		/// <inheritdoc />
		public LinearPathMoveInfo(int lastIndex, Vector3<float> finalPosition, [NotNull] Vector3<float>[] splineMiddlePoints)
		{
			LastIndex = lastIndex;
			FinalPosition = finalPosition;
			SplineMiddlePoints = splineMiddlePoints ?? throw new ArgumentNullException(nameof(splineMiddlePoints));
		}

		internal LinearPathMoveInfo()
		{
			
		}
	}
}
