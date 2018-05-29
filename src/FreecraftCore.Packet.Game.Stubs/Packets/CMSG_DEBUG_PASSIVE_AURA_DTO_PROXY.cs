using FreecraftCore;
using FreecraftCore.Serializer;

[GamePayloadOperationCodeAttribute(NetworkOperationCode.CMSG_DEBUG_PASSIVE_AURA)]
[WireDataContractAttribute]
public sealed class CMSG_DEBUG_PASSIVE_AURA_DTO_PROXY : GamePacketPayload, IUnimplementedGamePacketPayload
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

    public CMSG_DEBUG_PASSIVE_AURA_DTO_PROXY()
    {
    }
}