using System;

namespace FreecraftCore
{
	public interface IOperationCodeProvidable
	{

	}

	/// <summary>
	/// Contract for operation code providers. 
	/// </summary>
	/// <typeparam name="TOperationCodeType">The operation code enum.</typeparam>
	public interface IOperationCodeProvidable<out TOperationCodeType> : IOperationCodeProvidable
		where TOperationCodeType : Enum
	{
		/// <summary>
		/// Operations code.
		/// </summary>
		TOperationCodeType OperationCode { get; }
	}
}
