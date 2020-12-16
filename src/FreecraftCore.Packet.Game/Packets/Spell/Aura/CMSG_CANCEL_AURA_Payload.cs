using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	/// <summary>
	/// Packet payload structure for the <see cref="NetworkOperationCode"/> CMSG_CANCEL_AURA.
	/// </summary>
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.CMSG_CANCEL_AURA)]
	public sealed partial class CMSG_CANCEL_AURA_Payload : GamePacketPayload
	{
		/// <summary>
		/// Represents the spell id to cancel the aura for.
		/// </summary>
		[WireMember(1)]
		public int SpellId { get; internal set; }

		public CMSG_CANCEL_AURA_Payload(int spellId)
			: this()
		{
			if (spellId <= 0) throw new ArgumentOutOfRangeException(nameof(spellId));

			SpellId = spellId;
		}

		/// <summary>
		/// Default Serializer Ctor.
		/// </summary>
		public CMSG_CANCEL_AURA_Payload()
			: base(NetworkOperationCode.CMSG_CANCEL_AURA)
		{

		}
	}
}
