using System;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	[WireDataContract]
	public class TransportationInfo
	{
		//ClientVersion.AddedInVersion(ClientVersionBuild.V3_1_0_9767) post 3.1 it was a packedguid instead of a guid.
		/// <summary>
		/// The GUID of the transport.
		/// </summary>
		[WireMember(1)]
		public PackedGuid TransportGuid { get; internal set; }

		//TODO: What is this?
		[WireMember(2)]
		public Vector4<float> TransportOffset { get; internal set; }

		//Was missing this field
		[WireMember(3)]
		public int TransportTime { get; internal set; }

		//ClientVersion.AddedInVersion(ClientType.WrathOfTheLichKing)
		/// <summary>
		/// Indicates the id of the transportation seat.
		/// </summary>
		[WireMember(4)]
		public byte TransportSeatId { get; internal set; }

		/// <inheritdoc />
		public TransportationInfo(PackedGuid transportGuid, Vector4<float> transportOffset, int transportTime, byte transportSeatId)
		{
			TransportGuid = transportGuid;
			TransportOffset = transportOffset;
			TransportTime = transportTime;
			TransportSeatId = transportSeatId;
		}

		public TransportationInfo()
		{
			
		}
	}
}
