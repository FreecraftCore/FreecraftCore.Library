using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	//Slightly different on 1.12.1
	/// <summary>
	/// Sent by both the 1.12.1 and 3.3.5s on pre-initial enter map (login character game session).
	/// Sets the simulation tick rate I guess?
	/// </summary>
	[GamePayloadOperationCode(NetworkOperationCode.SMSG_LOGIN_SETTIMESPEED)]
	[WireDataContract]
	public sealed partial class SMSG_LOGIN_SETTIMESPEED_Payload : GamePacketPayload
	{
		//TODO: Implement packed DateTime support.
		[WireMember(1)]
		public uint GameTimeStamp { get; internal set; }

		/// <summary>
		/// The tick rate of the game simulation maybe???
		/// </summary>
		[WireMember(2)]
		public float GameTickRate { get; internal set; }

		//Sent only in 3.3.5 // added in 3.1.2 (TC)
		[WireMember(3)]
		internal int Unk { get; set; } = 0;

		/// <inheritdoc />
		public SMSG_LOGIN_SETTIMESPEED_Payload(uint gameTimeStamp, float gameTickRate)
			: this()
		{
			if (gameTickRate <= 0) throw new ArgumentOutOfRangeException(nameof(gameTickRate));

			GameTimeStamp = gameTimeStamp;
			GameTickRate = gameTickRate;
		}

		/// <summary>
		/// Serializer ctor.
		/// </summary>
		public SMSG_LOGIN_SETTIMESPEED_Payload()
			: base(NetworkOperationCode.SMSG_LOGIN_SETTIMESPEED)
		{
			
		}
	}
}
