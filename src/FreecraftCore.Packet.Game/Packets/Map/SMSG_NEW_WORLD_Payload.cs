using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	/// <summary>
	/// Packet sent when the client should begin loading to a new map.
	/// </summary>
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.SMSG_NEW_WORLD)]
	public sealed partial class SMSG_NEW_WORLD_Payload : GamePacketPayload
	{
		/// <summary>
		/// The ID of the map to teleport.
		/// </summary>
		[WireMember(1)]
		public int MapId { get; internal set; }

		/// <summary>
		/// The position to teleport to.
		/// </summary>
		[WireMember(2)]
		public Vector3<float> Position { get; internal set; }

		/// <summary>
		/// The orientation to teleport to.
		/// </summary>
		[WireMember(3)]
		public float Orientation { get; internal set; }

		public SMSG_NEW_WORLD_Payload(int mapId, [NotNull] Vector3<float> position, float orientation)
			: this()
		{
			//Blizzlike has map ID 0.
			if(mapId < 0) throw new ArgumentOutOfRangeException(nameof(mapId));

			MapId = mapId;
			Position = position ?? throw new ArgumentNullException(nameof(position));
			Orientation = orientation;
		}

		/// <summary>
		/// Serializer ctor.
		/// </summary>
		public SMSG_NEW_WORLD_Payload()
			: base(NetworkOperationCode.SMSG_NEW_WORLD)
		{

		}
	}
}
