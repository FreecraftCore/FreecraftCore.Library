using System;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	/// <summary>
	/// Sent by the server when a logon proof request was successful.
	/// Only for >= 2.x.x clients. 1.12.1 clients recieve something slightly different.
	/// </summary>
	[WireDataContract]
	public partial class LogonProofSuccess : LogonProofResult
	{
		/// <summary>
		/// SRP6 M2. See http://srp.stanford.edu/design.html for more information.
		/// (M2 = H(A, M (computed by client), K) where K is H(S) and S is session key. M2 proves server computed same K and recieved M1/M
		/// </summary>
		[WireMember(1)]
		[KnownSize(20)]
		public byte[] M2 { get; internal set; }

		//TODO: Accountflags? Trinitycore says this is:  0x01 = GM, 0x08 = Trial, 0x00800000 = Pro pass (arena tournament) but they always send "Pro Pass"?
		/// <summary>
		/// Indicates the authorization the client was granted.
		/// </summary>
		[WireMember(2)] //sent as a uint32
		public AccountAuthorizationFlags AccountAuthorization { get; internal set; }

		//TODO: What is survey ID? Always 0 on Trinitycore. Check mangos and EmberEmu
		[WireMember(3)]
		internal uint surveyId { get; set; } = 0;

		//TODO: What is this? Always 0 from Trinitycore.
		[WireMember(4)]
		internal ushort unk3 { get; set; } = 0;

		//TODO: Proper Ctor. Right now we only implement client stuff. Server sends this.

		public LogonProofSuccess([NotNull] byte[] m2Value)
			: this()
		{
			if(m2Value == null) throw new ArgumentNullException(nameof(m2Value));
			if(m2Value.Length != 20) throw new ArgumentException("Value cannot be a collection with size not equal to 20.", nameof(m2Value));

			M2 = m2Value;
		}

		public LogonProofSuccess()
			: base(AuthenticationResult.Success)
		{

		}
	}

	/*uint8   M2[20];
	uint32  AccountFlags;
	uint32  SurveyId;
	uint16  unk3;*/
}
