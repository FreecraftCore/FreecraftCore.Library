using System;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	[WireDataContract]
	public class AddonChecksumInfo
	{
		//Null terminated addon name.
		/// <summary>
		/// The fully qualified name of the addon.
		/// </summary>
		[NotNull]
		[WireMember(1)]
		public string AddonName { get; internal set; }

		/// <summary>
		/// Indicates if the addon is enabled.
		/// </summary>
		[WireMember(2)]
		internal bool UsesPublicKeyCRC { get; set; } = true; //sniffed as true

		//TODO: How do we compute this? It looks the same for every addon in the auth packet.
		/// <summary>
		/// The CRC hash of the addon.
		/// </summary>
		[WireMember(3)]
		internal uint CRCHash { get; set; } = 1276933997; //sniffed from real client auth

		//TODO: What is this?
		/// <summary>
		/// The something?
		/// </summary>
		[WireMember(4)]
		internal uint URLFileCRC { get; set; } = 0; //sniffed as 0 but I don't know what this is

		public AddonChecksumInfo([NotNull] string addonName)
		{
			if (string.IsNullOrEmpty(addonName))
				throw new ArgumentException("Value cannot be null or empty.", nameof(addonName));

			AddonName = addonName;
		}

		public AddonChecksumInfo()
		{
			//For deserialization
		}
	}
}
