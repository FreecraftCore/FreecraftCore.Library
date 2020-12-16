using FreecraftCore.Serializer;

namespace FreecraftCore
{
	/// <summary>
	/// Response payload sent in response to the <see cref="AuthLogonProofRequest"/>.
	/// </summary>
	[WireDataContract]
	[AuthenticationServerPayload(AuthOperationCode.AUTH_LOGON_PROOF)]
	public partial class AuthLogonProofResponse : AuthenticationServerPayload
	{
		//TODO: Implement
		public override bool isValid { get; } = true;

		//Not a wire member. Pull from proof result. It eats the byte for type info
		/// <summary>
		/// Indicates the result of the Authentication attempt.
		/// </summary>
		public AuthenticationResult AuthResult => ProofResult.Result;

		/// <summary>
		/// Contains the information sent as a response to the Proof attempt.
		/// </summary>
		[WireMember(1)]
		public LogonProofResult ProofResult { get; internal set; }
		
		//TODO: Add real ctor. Right now we only implement client stuff and this is sent by server.

		//TODO: Make better ctor
		/// <inheritdoc />
		public AuthLogonProofResponse(LogonProofResult proofResult)
			: this()
		{
			ProofResult = proofResult;
		}

		public AuthLogonProofResponse()
			: base(AuthOperationCode.AUTH_LOGON_PROOF)
		{

		}
	}
}
