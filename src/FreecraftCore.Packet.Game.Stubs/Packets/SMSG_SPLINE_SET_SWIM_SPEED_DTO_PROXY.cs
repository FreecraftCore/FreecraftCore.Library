using FreecraftCore;
using FreecraftCore.Serializer;

[GamePayloadOperationCodeAttribute(NetworkOperationCode.SMSG_SPLINE_SET_SWIM_SPEED)]
[WireDataContractAttribute]
public sealed class SMSG_SPLINE_SET_SWIM_SPEED_DTO_PROXY : GamePacketPayload, IUnimplementedGamePacketPayload
{
    [ReadToEndAttribute]
    [WireMemberAttribute(1)]
    private byte[] _Data;
    public byte[] Data
    {
        get
        {
            return Data;
        }

        set
        {
            Data = value;
        }
    }

    public SMSG_SPLINE_SET_SWIM_SPEED_DTO_PROXY()
    {
    }
}