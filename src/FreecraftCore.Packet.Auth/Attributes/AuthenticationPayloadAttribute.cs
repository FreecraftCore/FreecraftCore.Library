using System;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	/// <summary>
	/// Metadata marker for an authentication payload.
	/// Inherits from RuntimeLinkAttribute which allows types to link themselves at runtime.
	/// </summary>
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)] //sometimes multiple operations will send the same payload though this is not yet supported
	public abstract class AuthenticationPayloadAttribute : WireDataContractBaseLinkAttribute, IOperationCodeProvidable<AuthOperationCode>, IPayloadAttribute
	{
		/// <summary>
		/// Represents the authentication operation (or Auth Command in Mangos/Trinitycore)
		/// </summary>
		public AuthOperationCode OperationCode => (AuthOperationCode)this.Index;

		/// <inheritdoc />
		public Type BaseType { get; }

		protected AuthenticationPayloadAttribute(AuthOperationCode operationCode, Type payloadBaseType)
			: base((int)operationCode)
		{
			if(!Enum.IsDefined(typeof(AuthOperationCode), operationCode))
				throw new ArgumentOutOfRangeException(nameof(operationCode), "Value should be defined in the AuthOperationCode enum.");

			BaseType = payloadBaseType;
		}

		/// <summary>
		/// Used for testing purposes only.
		/// </summary>
		/// <param name="i">Testing index.</param>
		/// <param name="payloadBaseType"></param>
		internal AuthenticationPayloadAttribute(int i, Type payloadBaseType)
			: base(i)
		{
			BaseType = payloadBaseType;
		}

		
	}
}