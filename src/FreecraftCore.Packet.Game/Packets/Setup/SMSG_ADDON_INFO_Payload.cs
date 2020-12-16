using System;
using System.Collections.Generic;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	/// <summary>
	/// Sent to the connecting user before the character list.
	/// Sent with <see cref="NetworkOperationCode.SMSG_ADDON_INFO"/>.
	/// </summary>
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.SMSG_ADDON_INFO)]
	public sealed partial class SMSG_ADDON_INFO_Payload : GamePacketPayload
	{
		[KnownSize(23)] //TC sends 23 of these
		[WireMember(1)]
		internal AddonChecksumResult[] _AddonChecks;

		/// <summary>
		/// The results of the addon checks.
		/// </summary>
		public IReadOnlyCollection<AddonChecksumResult> AddonChecks => _AddonChecks;

		//TODO: Implement banned addon handling
		[WireMember(2)]
		internal int BannedAddonCount = 0;

		/// <inheritdoc />
		public SMSG_ADDON_INFO_Payload([NotNull] AddonChecksumResult[] addonChecks)
			: this()
		{
			//TODO: Assert size
			_AddonChecks = addonChecks ?? throw new ArgumentNullException(nameof(addonChecks));
		}

		/// <summary>
		/// Serializer ctor.
		/// </summary>
		public SMSG_ADDON_INFO_Payload()
			: base(NetworkOperationCode.SMSG_ADDON_INFO)
		{

		}
	}
}
