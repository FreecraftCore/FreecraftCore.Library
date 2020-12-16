using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.SMSG_GROUP_INVITE)]
	public sealed partial class SMSG_GROUP_INVITE_Payload : GamePacketPayload
	{
		//TC sends 0 or 1. 1 when it's successful. 0 when the target player is already in a group.
		/// <summary>
		/// Indicates if the invite is a success.
		/// </summary>
		[WireMember(1)]
		public bool isInviteSuccessful { get; internal set; }

		/// <summary>
		/// The player's name inviting.
		/// </summary>
		[WireMember(2)]
		public string InvitingPlayer { get; internal set; }

		[WireMember(3)]
		internal int Unk1 { get; set; }

		//TrinityCore says this is count??
		[WireMember(4)]
		internal byte Unk2 { get; set; }

		[WireMember(5)]
		internal int Unk3 { get; set; }

		/// <inheritdoc />
		public SMSG_GROUP_INVITE_Payload(bool isInviteSuccessful, [NotNull] string invitingPlayer)
			: this()
		{
			if(string.IsNullOrWhiteSpace(invitingPlayer)) throw new ArgumentException("Value cannot be null or whitespace.", nameof(invitingPlayer));

			this.isInviteSuccessful = isInviteSuccessful;
			InvitingPlayer = invitingPlayer;
		}

		/// <summary>
		/// Serializer ctor.
		/// </summary>
		public SMSG_GROUP_INVITE_Payload()
			: base(NetworkOperationCode.SMSG_GROUP_INVITE)
		{
			
		}
	}
}
