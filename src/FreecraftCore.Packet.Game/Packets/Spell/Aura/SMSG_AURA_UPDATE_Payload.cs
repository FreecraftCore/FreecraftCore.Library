using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.SMSG_AURA_UPDATE)]
	public sealed partial class SMSG_AURA_UPDATE_Payload : GamePacketPayload
	{
		/// <summary>
		/// The guid of the aura target.
		/// </summary>
		[WireMember(1)]
		public PackedGuid TargetGuid { get; internal set; }

		/// <summary>
		/// The aura update data.
		/// </summary>
		[WireMember(2)]
		public AuraUpdateData Data { get; internal set; }

		public SMSG_AURA_UPDATE_Payload([NotNull] PackedGuid targetGuid, [NotNull] AuraUpdateData data)
			: this()
		{
			TargetGuid = targetGuid ?? throw new ArgumentNullException(nameof(targetGuid));
			Data = data ?? throw new ArgumentNullException(nameof(data));
		}

		/// <summary>
		/// Serializer ctor.
		/// </summary>
		public SMSG_AURA_UPDATE_Payload()
			: base(NetworkOperationCode.SMSG_AURA_UPDATE)
		{

		}
	}
}
