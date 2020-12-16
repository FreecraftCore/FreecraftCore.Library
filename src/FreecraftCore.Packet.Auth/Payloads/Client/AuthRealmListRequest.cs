using FreecraftCore.Serializer;

namespace FreecraftCore
{
	/// <summary>
	/// Payload for requesting the realm list.
	/// </summary>
	[WireDataContract]
	[AuthenticationClientPayload(AuthOperationCode.REALM_LIST)] //TODO: Figure out how to support linking with the limited information.
	public partial class AuthRealmListRequest : AuthenticationClientPayload
	{
		//TODO: Implement
		public override bool isValid { get; } = true;

		//For some reason this is 5 bytes long (remove one for byte sized op code)

		//I can only guess what this is for.
		//This is what EmberEmu had to say: https://github.com/EmberEmu/Ember/blob/spark-new/src/login/grunt/client/RequestRealmList.h
		[WireMember(1)]
		internal int unknownValue = 0; // hardcoded to zero in public client
		
		public AuthRealmListRequest()
			: base(AuthOperationCode.REALM_LIST)
		{
			//Don't need to send anything.
		}
	}
}
