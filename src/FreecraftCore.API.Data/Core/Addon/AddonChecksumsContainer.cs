using System;
using System.Collections;
using System.Collections.Generic;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	/// <summary>
	/// Container class encapsulating the data required for the addon checksum verification.
	/// Contains a collection of <see cref="AddonChecksumInfo"/>s and a date timestamp.
	/// </summary>
	[WireDataContract]
	public class AddonChecksumsContainer : IEnumerable<AddonChecksumInfo>
	{
		/// <summary>
		/// Wire sent collection of checksums.
		/// </summary>
		[NotNull]
		[WireMember(1)]
		[SendSize(PrimitiveSizeType.Int32)]
		internal AddonChecksumInfo[] addonChecksumInfos { get; set; }

		//TODO: Trinitycore just reads a uint32 but does nothing with it. What does real WoW client send?
		/// <summary>
		/// Indicates the time this container was generated.
		/// </summary>
		[WireMember(2)]
		public uint Timestamp { get; internal set; }

		/// <summary>
		/// Collection of Addon checksums used for Addon validation.
		/// </summary>
		public IEnumerable<AddonChecksumInfo> AddonChecksums => addonChecksumInfos;

		/// <summary>
		/// Create a new checksum verification
		/// </summary>
		/// <param name="checksums"></param>
		public AddonChecksumsContainer([NotNull] AddonChecksumInfo[] checksums)
		{
			if (checksums == null) throw new ArgumentNullException(nameof(checksums));

			addonChecksumInfos = checksums;
			Timestamp = (uint)DateTime.UtcNow.ToUniversalTime()
				.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).Ticks;
		}

		public AddonChecksumsContainer()
		{
			
		}

		/// <inheritdoc />
		public IEnumerator<AddonChecksumInfo> GetEnumerator()
		{
			return AddonChecksums.GetEnumerator();
		}

		/// <inheritdoc />
		IEnumerator IEnumerable.GetEnumerator()
		{
			return AddonChecksums.GetEnumerator();
		}
	}
}
