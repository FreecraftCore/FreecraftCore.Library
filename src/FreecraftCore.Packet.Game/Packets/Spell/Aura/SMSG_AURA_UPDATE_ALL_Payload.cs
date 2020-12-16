using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace FreecraftCore
{
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.SMSG_AURA_UPDATE_ALL)]
	public sealed partial class SMSG_AURA_UPDATE_ALL_Payload : GamePacketPayload
	{
		/// <summary>
		/// The guid of the aura target.
		/// </summary>
		[WireMember(1)]
		public PackedGuid TargetGuid { get; internal set; }

		/// <summary>
		/// The aura update data.
		/// </summary>
		[ReadToEnd]
		[WireMember(2)]
		internal AuraUpdateData[] _Data { get; set; }

		/// <summary>
		/// The collection of aura application data for the specified <see cref="TargetGuid"/>.
		/// </summary>
		[JsonIgnore]
		[NotMapped]
		public IReadOnlyCollection<AuraUpdateData> Data => _Data;

		public SMSG_AURA_UPDATE_ALL_Payload([NotNull] PackedGuid targetGuid, [NotNull] AuraUpdateData[] data)
			: this()
		{
			TargetGuid = targetGuid ?? throw new ArgumentNullException(nameof(targetGuid));
			_Data = data ?? throw new ArgumentNullException(nameof(data));
		}

		/// <summary>
		/// Serializer ctor.
		/// </summary>
		public SMSG_AURA_UPDATE_ALL_Payload()
			: base(NetworkOperationCode.SMSG_AURA_UPDATE_ALL)
		{

		}
	}
}
