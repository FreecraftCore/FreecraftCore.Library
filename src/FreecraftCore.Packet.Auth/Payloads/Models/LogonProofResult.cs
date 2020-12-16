using FreecraftCore.Serializer;

namespace FreecraftCore
{
	//TODO: Check mangos 1.12.1 for other possible LoginProof results. Also, we need to implement 1.12.1 result. Only have 3.3.5 at the moment.
	/// <summary>
	/// Contract for all proof results.
	/// </summary>
	[WireDataContract(PrimitiveSizeType.Byte)] //the type information is sent as a byte
	[WireDataContractBaseType((int)AuthenticationResult.Success, typeof(LogonProofSuccess))] //0 in the stream means success
	[WireDataContractBaseType((int)AuthenticationResult.FailUnknownAccount, typeof(LogonProofFailure))] //4 means token failure.
	public abstract partial class LogonProofResult
	{
		/// <summary>
		/// Indicates the result of the proof.
		/// </summary>
		[EnumSize(PrimitiveSizeType.Byte)]
		[WireMember(1)]
		public AuthenticationResult Result { get; internal set; }

		protected LogonProofResult(AuthenticationResult result)
		{
			Result = result;
		}
	}
}
