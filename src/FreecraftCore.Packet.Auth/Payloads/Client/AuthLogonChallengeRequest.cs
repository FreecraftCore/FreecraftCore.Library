using FreecraftCore.Serializer;
using System;
using System.Net;
using JetBrains.Annotations;


namespace FreecraftCore
{
	/// <summary>
	/// Initial Authentication payload
	/// </summary>
	[WireDataContract]
	[AuthenticationClientPayload(AuthOperationCode.AUTH_LOGON_CHALLENGE)] //TODO: Figure out how to support linking with the limited information.
	public partial class AuthLogonChallengeRequest : AuthenticationClientPayload
	{
		/// <inheritdoc />
		public override bool isValid => Challenge.Protocol.VerifyIsDefined() && Challenge.Game.VerifyIsDefined() && Challenge.Expansion.VerifyIsDefined();

		/// <summary>
		/// The data related to the authentication challenge.
		/// </summary>
		[WireMember(1)]
		public AuthChallengeData Challenge { get; internal set; }

		/// <inheritdoc />
		public AuthLogonChallengeRequest([NotNull] AuthChallengeData challenge)
			: this()
		{
			Challenge = challenge ?? throw new ArgumentNullException(nameof(challenge));
		}

		//Serializer ctor.
		public AuthLogonChallengeRequest()
			: base(AuthOperationCode.AUTH_LOGON_CHALLENGE)
		{
			
		}
	}
}

/*typedef struct AUTH_LOGON_CHALLENGE_C
{
	uint8   cmd;
	uint8   error;
	uint16  size;
	uint8   gamename[4];
	uint8   version1;
	uint8   version2;
	uint8   version3;
	uint16  build;
	uint8   platform[4];
	uint8   os[4];
	uint8   country[4];
	uint32  timezone_bias;
	uint32  ip;
	uint8   I_len;
	uint8   I[1];
} sAuthLogonChallenge_C;*/
