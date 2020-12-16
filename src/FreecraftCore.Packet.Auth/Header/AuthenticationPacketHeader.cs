using System;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	/// <summary>
	/// The default <see cref="IAuthenticationPacketHeader"/> and only type of authentication
	/// packet header that WoW sends.
	/// </summary>
	[WireDataContract]
	public class AuthenticationPacketHeader : IAuthenticationPacketHeader
	{
		//TODO: Implement later
		/// <inheritdoc />
		public bool isValid { get; }

		/// <inheritdoc />
		[WireMember(1)]
		public AuthOperationCode OperationCode { get; internal set; }

		public AuthenticationPacketHeader(AuthOperationCode authenticationOpCode)
		{
			if (!Enum.IsDefined(typeof(AuthOperationCode), authenticationOpCode))
				throw new ArgumentOutOfRangeException(nameof(authenticationOpCode), "Value should be defined in the AuthOperationCode enum.");

			OperationCode = authenticationOpCode;
		}

		public AuthenticationPacketHeader()
		{
			//for serialization
		}
	}
}
