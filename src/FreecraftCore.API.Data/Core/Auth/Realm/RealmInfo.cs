using FreecraftCore.Serializer;
using System;
using JetBrains.Annotations;

namespace FreecraftCore
{
	[WireDataContract]
	public partial class RealmInfo
	{
		/// <summary>
		/// Realm Type
		/// (RP, PVP, PVE etc)
		/// </summary>
		[WireMember(1)]
		public RealmType RealmType { get; internal set; }

		/// <summary>
		/// Indicates if the realm list information
		/// contains the optional build info.
		/// (Trinitycore only sends this if SpecifyBuild is in the flags.
		/// </summary>
		public bool HasBuildInformation => DefaultInformation.Flags.HasFlag(RealmFlags.SpecifyBuild);

		/// <summary>
		/// Indidicates if the realm is open.
		/// (Only in 2.x and 3.x according to Trinitycore)
		/// </summary>
		[WireMember(2)]
		public bool isLocked { get; internal set; }

		//Switched away from flags based polymorphic serialization and uses the bool checking
		//optional serialization.
		[WireMember(3)]
		internal DefaultRealmInformation DefaultInformation { get; set; }

		//No longer serialized polymorphically
		/// <summary>
		/// The realm information.
		/// </summary>
		public IRealmInformation Information => DefaultInformation;

		[Optional(nameof(HasBuildInformation))]
		[WireMember(4)]
		public RealmBuildInformation BuildInfo { get; internal set; }

		/// <inheritdoc />
		public RealmInfo(RealmType realmType, bool isLocked, [NotNull] DefaultRealmInformation information)
			: this(realmType, isLocked, information, null)
		{

		}

		/// <inheritdoc />
		public RealmInfo(RealmType realmType, bool isLocked, DefaultRealmInformation defaultInformation, [CanBeNull] RealmBuildInformation buildInfo)
		{
			if(!Enum.IsDefined(typeof(RealmType), realmType)) throw new ArgumentOutOfRangeException(nameof(realmType), "Value should be defined in the RealmType enum.");
			//Don't check build info. It can be null. Only if the specify build was not included

			RealmType = realmType;
			this.isLocked = isLocked;
			DefaultInformation = defaultInformation;
			BuildInfo = buildInfo;
			
			//Check after initialization if we have everything needed
			if(HasBuildInformation && BuildInfo == null)
				throw new ArgumentNullException(nameof(buildInfo), $"{defaultInformation} has the {RealmFlags.SpecifyBuild} flags but no build information is provided.");
		}

		public RealmInfo()
		{

		}

		/// <inheritdoc />
		public override string ToString()
		{
			return $"RealmType: {RealmType} HasBuildInfo: {HasBuildInformation} {DefaultInformation?.ToString()} {BuildInfo?.ToString()}";
		}
	}
}
