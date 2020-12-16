using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;
using System.Text;
using FreecraftCore.Serializer;
using Newtonsoft.Json;

namespace FreecraftCore
{
	/// <summary>
	/// Challenge data.
	/// (Shared between Challenge/ReconnectChallange.
	/// </summary>
	[WireDataContract]
	public sealed class AuthChallengeData
	{
		/// <summary>
		/// Authentication protocol version to use.
		/// Trinitycore/Mangos has this marked as an error but Ember https://github.com/EmberEmu/Ember/blob/spark-new/src/login/grunt/client/LoginChallenge.h has this
		/// marked as the protocol field.
		/// </summary>
		[WireMember(1)]
		public ProtocolVersion Protocol { get; internal set; }

		//We don't need to expose this really. Shouldn't need to be checked. This isn't C++
		/// <summary>
		/// Packet size. Computed by Trinitycore as the size of the payload + the username size.
		/// </summary>
		[WireMember(2)]
		internal ushort size;

		//Could be reversed?
		/// <summary>
		/// Game the client is for.
		/// </summary>
		[Encoding(EncodingType.ASCII)]
		[EnumString]
		[KnownSize(4)]
		[WireMember(3)]
		public GameType Game { get; internal set; }

		/// <summary>
		/// Indicates the expansion this client is authenticating for.
		/// </summary>
		[WireMember(4)]
		public byte ExpansionVersionId { get; internal set; }

		[NotMapped]
		[JsonIgnore]
		public Expansions Expansion => (Expansions) (ExpansionVersionId - 1);

		/// <summary>
		/// Indicates the major patch version (Ex. x.3.x)
		/// </summary>
		[WireMember(5)]
		public byte MajorPatchVersion { get; internal set; }

		/// <summary>
		/// Indicates the major patch version (Ex. x.x.5)
		/// </summary>
		[WireMember(6)]
		public byte MinorPatchVersion { get; internal set; }

		//TODO: Enumerate this maybe?
		[WireMember(7)]
		public ClientBuild Build { get; internal set; }

		/// <summary>
		/// Indicates the platform/arc (Ex. 32bit or 64bit)
		/// </summary>
		[Encoding(EncodingType.ASCII)]
		[EnumString]
		[ReverseData]
		[KnownSize(4)]
		[WireMember(8)]
		public PlatformType Platform { get; internal set; }

		/// <summary>
		/// Indicates the operating system the client is running on (Ex. Win or Mac)
		/// </summary>
		[Encoding(EncodingType.ASCII)]
		[EnumString]
		[ReverseData]
		[KnownSize(4)]
		[WireMember(9)]
		public OperatingSystemType OperatingSystem { get; internal set; }

		/// <summary>
		/// Indicates the Locale of the client. (Ex. En-US)
		/// </summary>
		[Encoding(EncodingType.ASCII)]
		[EnumString]
		[ReverseData]
		[DontTerminate] //Locale also doesn't terminate. It is a char[4] like "SUne" without a terminator.
		[KnownSize(4)]
		[WireMember(10)]
		public LocaleType Locale { get; internal set; }

		//TODO: Timezone bias? Investigate values.
		[WireMember(11)]
		internal uint TimeZoneBias { get; set; }

		[KnownSize(4)]
		[WireMember(12)]
		internal byte[] ipAddressInBytes;

		//Lazily cached Ip built from wired bytes
		internal Lazy<IPAddress> cachedIp { get; set; }

		//TODO: Thread safety
		/// <summary>
		/// IP Address of the client.
		/// </summary>
		public IPAddress IP => cachedIp.Value;

		/// <summary>
		/// Could be Username or maybe Email.
		/// </summary>
		//TODO: Check Mangos if they look for a null terminator on Identity
		[DontTerminate] //JackPoz doesn't terminate and it looks like Trinitycore doesn't really expect a null terminator either.
		[SendSize(PrimitiveSizeType.Byte)]
		[WireMember(13)]
		public string Identity { get; internal set; }

		public AuthChallengeData(ProtocolVersion protocol, GameType game, Expansions expansion, byte majorPatch, byte minorPatch, ClientBuild build, PlatformType platform, OperatingSystemType operatingSystem, LocaleType locale, IPAddress clientIp, string identity)
			: this()
		{
			//TODO: Very long ctor. Maybe use builder in the future.
			Protocol = protocol;
			Game = game;
			ExpansionVersionId = (byte) (expansion + 1);
			MajorPatchVersion = majorPatch;
			MinorPatchVersion = minorPatch;
			Build = build;
			Platform = platform;
			OperatingSystem = operatingSystem;
			Locale = locale;

			//Convert IP to bytes
			//TODO: Check size
			ipAddressInBytes = clientIp.GetAddressBytes(); //Trinitycore expects an int32 but an array of bytes should work

			Identity = identity;

			//Now we can compute size. Jackpoz does this with a literal. Trinitycore uses constants. I think we'll just use a literal though.
			size = (ushort)(identity.Length + 30);
		}

		public AuthChallengeData()
		{
			//Use a Lazy IPAddress to create the IP from the bytes coming across the network
			cachedIp = new Lazy<IPAddress>(() => new IPAddress(ipAddressInBytes), true);
		}
	}
}
