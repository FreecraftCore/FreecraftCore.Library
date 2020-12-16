using FreecraftCore.Serializer;

namespace FreecraftCore
{
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.CMSG_BEGIN_TRADE)]
	public sealed partial class CMSG_BEGIN_TRADE_Payload : GamePacketPayload
	{
		/// <summary>
		/// This packet is just empty?? TC handles no data from it.
		/// </summary>
		public CMSG_BEGIN_TRADE_Payload()
			: base(NetworkOperationCode.CMSG_BEGIN_TRADE)
		{

		}
	}
}
