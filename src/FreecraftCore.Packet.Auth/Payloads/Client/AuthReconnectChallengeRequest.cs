using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	/// <summary>
	/// Payload for reconnecting challenge event.
	/// </summary>
	[WireDataContract]
	[AuthenticationClientPayload(AuthOperationCode.AUTH_RECONNECT_CHALLENGE)] //TODO: Figure out how to support linking with the limited information.
	public sealed partial class AuthReconnectChallengeRequest : AuthenticationClientPayload
	{
		//TODO: Remove this crap
		/// <inheritdoc />
		public override bool isValid => true;

		[WireMember(1)]
		public AuthChallengeData ChallengeData { get; internal set; }

		/// <inheritdoc />
		public AuthReconnectChallengeRequest([NotNull] AuthChallengeData challengeData)
			: this()
		{
			ChallengeData = challengeData ?? throw new ArgumentNullException(nameof(challengeData));
		}

		/// <summary>
		/// Serializer ctor
		/// </summary>
		public AuthReconnectChallengeRequest()
			: base(AuthOperationCode.AUTH_RECONNECT_CHALLENGE)
		{
			
		}
	}
}
