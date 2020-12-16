using System;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	[DefaultChild(typeof(UnknownGamePayload))] //if we encounter something not handled we'll be able to produce an unknown payload
	[WireDataContract(PrimitiveSizeType.UInt16)] //enable runtime linking with second arg
	public abstract partial class GamePacketPayload : IGamePacketPayload
	{
		/// <inheritdoc />
		[Obsolete("This should not longer be used to check the payload validity. Data validation framework will replace it.")]
		public virtual bool isValid { get; } = true;

		[EnumSize(PrimitiveSizeType.UInt16)]
		[WireMember(1)]
		public NetworkOperationCode OperationCode { get; internal set; }

		protected GamePacketPayload(NetworkOperationCode operationCode)
		{
			OperationCode = operationCode;
		}
	}
}
