using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	/*
	data << pCurrChar->GetMapId();
	data << pCurrChar->GetPositionX();
	data << pCurrChar->GetPositionY();
	data << pCurrChar->GetPositionZ();
	data << pCurrChar->GetOrientation();
	*/
	
	/// <summary>
	/// Packet sent on initial entry of a character to the world.
	/// </summary>
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.SMSG_LOGIN_VERIFY_WORLD)]
	public sealed partial class SMSG_LOGIN_VERIFY_WORLD_Payload : GamePacketPayload
	{
		/// <summary>
		/// The Map Id to load the character into.
		/// </summary>
		[WireMember(1)]
		public int MapId { get; internal set; }

		/// <summary>
		/// The position of the character.
		/// </summary>
		[WireMember(2)]
		public Vector3<float> Position { get; internal set; }

		/// <summary>
		/// The orientation of the player.
		/// </summary>
		[WireMember(3)]
		public float Orientation { get; internal set; }

		public SMSG_LOGIN_VERIFY_WORLD_Payload(int mapId, [NotNull] Vector3<float> position, float orientation)
			: this()
		{
			//Blizzlike map supports map 0. FOR SOME REASON!!
			if (mapId < 0) throw new ArgumentOutOfRangeException(nameof(mapId));

			MapId = mapId;
			Position = position ?? throw new ArgumentNullException(nameof(position));
			Orientation = orientation;
		}

		/// <summary>
		/// Serializer ctor.
		/// </summary>
		public SMSG_LOGIN_VERIFY_WORLD_Payload()
			: base(NetworkOperationCode.SMSG_LOGIN_VERIFY_WORLD)
		{
			
		}
	}
}
