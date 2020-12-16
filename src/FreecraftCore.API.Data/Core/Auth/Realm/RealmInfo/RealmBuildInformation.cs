using FreecraftCore.Serializer;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace FreecraftCore
{
	[WireDataContract]
	public class RealmBuildInformation
	{
		[WireMember(1)]
		public int ExpansionVersionId { get; internal set; }

		[NotMapped]
		[JsonIgnore]
		public Expansions Expansion => (Expansions) (ExpansionVersionId - 1);

		[WireMember(2)]
		public byte MajorVersion { get; internal set; }

		[WireMember(3)]
		public byte MinorVersion { get; internal set; }

		[WireMember(4)]
		public short BuildNumber { get; internal set; }

		/// <inheritdoc />
		public RealmBuildInformation(Expansions expansion, byte majorVersion, byte minorVersion, short buildNumber)
		{
			if(!Enum.IsDefined(typeof(Expansions), expansion)) throw new ArgumentOutOfRangeException(nameof(expansion), "Value should be defined in the ExpansionType enum.");

			ExpansionVersionId = (int) (expansion + 1);
			MajorVersion = majorVersion;
			MinorVersion = minorVersion;
			BuildNumber = buildNumber;
		}

		public RealmBuildInformation()
		{
		}

		/// <inheritdoc />
		public override string ToString()
		{
			return $"{nameof(Expansion)}: {Expansion} {nameof(MajorVersion)}: {MajorVersion} {nameof(MinorVersion)}: {MinorVersion} {nameof(BuildNumber)}: {BuildNumber}";
		}
	}
}
