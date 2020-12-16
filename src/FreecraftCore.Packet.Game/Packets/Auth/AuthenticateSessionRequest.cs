using System;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	[ForClientBuild(ClientBuild.Wotlk_3_3_5a)]
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.CMSG_AUTH_SESSION)]
	[ProtocolGrouping(ProtocolCode.Authentication)] //Though this isn't part of the actual authserver stuff it's still auth.
	public partial class SessionAuthProofRequest : GamePacketPayload
	{
		/// <inheritdoc />
		public override bool isValid => SessionDigest != null && SessionDigest.Length == 20
			&& String.IsNullOrEmpty(AccountName) && RandomSeedBytes != null &&
			RandomSeedBytes.Length == 4 && RealmIdentity != null && BlizzardAddonVerificationContainer != null;

		/// <summary>
		/// The build number of the client.
		/// </summary>
		[WireMember(1)]
		public ClientBuild ClientBuildNumber { get; internal set; }

		//For some reason Trinitycore expects a 4 byte clientbuild number
		//But clientbuild number is only a short, on the authentication process,
		//so it's likely these are unknown bytes
		[WireMember(2)]
		internal short unknownOne { get; set; } = 0;

		//Not checked on Trinitycore
		//Was probably used for loadbalancing so it knows
		//which server to ask for the session key.
		//Skipped on Mangos too, with read_skip<uint32>()
		[WireMember(3)]
		internal int LoginServiceId { get; set; } = 0;

		/// <summary>
		/// The account name attempting to authentication their session.
		/// </summary>
		[WireMember(4)]
		public string AccountName { get; internal set; } //is a null terminated string

		//Not check on trinitycore
		//Don't know what the type of login server would mean.
		//Not in the 1.12.1 packet
		[WireMember(5)]
		internal uint LoginServerType { get; set; } = 0; // 0 GRUNT, 1 Battle.net

		/// <summary>
		/// The client's randomly generated seed.
		/// </summary>
		[NotNull]
		[KnownSize(4)]
		[WireMember(6)]
		public byte[] RandomSeedBytes { get; internal set; }

		/// <summary>
		/// The realm indentify containing information about ID
		/// and other unexposed data.
		/// </summary>
		[NotNull]
		[WireMember(7)]
		public RealmIdentification RealmIdentity { get; internal set; }

		//Don't know what this is
		//Trinitycore doesn't use it
		[WireMember(8)]
		internal ulong DosResponse { get; set; }

		/// <summary>
		/// The client's computed digest for session authentication.
		/// </summary>
		[NotNull]
		[KnownSize(20)]
		[WireMember(9)]
		public byte[] SessionDigest { get; internal set; }

		//Trintycore will crash if you don't at least send the size on newer versions
		//Though it'll probably be fixed soon
		[NotNull]
		[Compress] //compressed with zlib
		[WireMember(10)]
		public AddonChecksumsContainer BlizzardAddonVerificationContainer { get; internal set; }
		
		public SessionAuthProofRequest(ClientBuild clientBuildNumber, [NotNull] string accountName, [NotNull] byte[] randomSeedBytes,
			[NotNull] RealmIdentification realmIdentity, [NotNull] byte[] sessionDigest, [NotNull] AddonChecksumInfo[] addonChecksums)
			: this()
		{
			if (!Enum.IsDefined(typeof(ClientBuild), clientBuildNumber))
				throw new ArgumentOutOfRangeException(nameof(clientBuildNumber), "Value should be defined in the ClientBuild enum.");

			if (randomSeedBytes == null) throw new ArgumentNullException(nameof(randomSeedBytes));
			if (realmIdentity == null) throw new ArgumentNullException(nameof(realmIdentity));
			if (sessionDigest == null) throw new ArgumentNullException(nameof(sessionDigest));
			if (addonChecksums == null) throw new ArgumentNullException(nameof(addonChecksums));

			if (string.IsNullOrEmpty(accountName))
				throw new ArgumentException("Value cannot be null or empty.", nameof(accountName));

			BlizzardAddonVerificationContainer = new AddonChecksumsContainer(addonChecksums);
			ClientBuildNumber = clientBuildNumber;
			AccountName = accountName;
			RandomSeedBytes = randomSeedBytes;
			RealmIdentity = realmIdentity;
			SessionDigest = sessionDigest;
		}

		public SessionAuthProofRequest()
			: base(NetworkOperationCode.CMSG_AUTH_SESSION)
		{
			//protected ctor for serialization
		}
	}
}
