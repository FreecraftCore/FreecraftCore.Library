using System;

namespace FreecraftCore
{
	/// <summary>
	/// Metadata marker for an authentication payload sent by the client.
	/// Inherits from RuntimeLinkAttribute which allows types to link themselves at runtime.
	/// </summary>
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)] //sometimes multiple operations will send the same payload though this is not yet supported
	public class AuthenticationClientPayloadAttribute : AuthenticationPayloadAttribute
	{
		public AuthenticationClientPayloadAttribute(AuthOperationCode operationCode)
			: base(operationCode, typeof(AuthenticationClientPayload))
		{
			if(!Enum.IsDefined(typeof(AuthOperationCode), operationCode))
				throw new ArgumentOutOfRangeException(nameof(operationCode), "Value should be defined in the AuthOperationCode enum.");
		}

		/// <summary>
		/// Used for testing purposes only.
		/// </summary>
		/// <param name="i">Testing index.</param>
		internal AuthenticationClientPayloadAttribute(int i)
			: base(i, typeof(AuthenticationClientPayload))
		{

		}
	}
}