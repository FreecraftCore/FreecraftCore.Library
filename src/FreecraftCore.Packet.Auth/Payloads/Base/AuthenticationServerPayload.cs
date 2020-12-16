using FreecraftCore.Serializer;


namespace FreecraftCore
{
	/// <summary>
	/// Authentication payload base type that is used to wire children for serialization purposes.
	/// This version of the Authentication Payload is for payloads sent by the server.
	/// </summary>
	[ProtocolGrouping(ProtocolCode.Authentication)] //we can put this on the base type because all auth packets have the same protocol.
	[DefaultChild(typeof(DefaultAuthenticationServerPayload))]
	[WireDataContract(PrimitiveSizeType.Byte)] //expect runtime linking
	public abstract partial class AuthenticationServerPayload : IAuthenticationPayload
	{
		/// <inheritdoc />
		public abstract bool isValid { get; }

		[EnumSize(PrimitiveSizeType.Byte)]
		[WireMember(1)]
		public AuthOperationCode OperationCode { get; internal set; }

		protected AuthenticationServerPayload(AuthOperationCode operationCode)
		{
			OperationCode = operationCode;
		}
	}
}
