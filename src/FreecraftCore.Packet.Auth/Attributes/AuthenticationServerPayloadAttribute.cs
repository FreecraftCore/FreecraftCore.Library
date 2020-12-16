using System;


namespace FreecraftCore
{
	/// <summary>
	/// Metadata marker for an authentication payload sent by the server.
	/// Inherits from RuntimeLinkAttribute which allows types to link themselves at runtime.
	/// </summary>
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)] //sometimes multiple operations will send the same payload though this is not yet supported
	public class AuthenticationServerPayloadAttribute : AuthenticationPayloadAttribute
	{
		public AuthenticationServerPayloadAttribute(AuthOperationCode operationCode)
			: base(operationCode, typeof(AuthenticationServerPayload))
		{
			if (!Enum.IsDefined(typeof(AuthOperationCode), operationCode))
				throw new ArgumentOutOfRangeException(nameof(operationCode), "Value should be defined in the AuthOperationCode enum.");
		}
		
		/// <summary>
		/// Used for testing purposes only.
		/// </summary>
		/// <param name="i">Testing index.</param>
		internal AuthenticationServerPayloadAttribute(int i)
			: base(i, typeof(AuthenticationServerPayload))
		{
			
		}
	}
}
