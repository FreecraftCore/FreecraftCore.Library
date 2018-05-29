using FreecraftCore;
using FreecraftCore.Serializer;

[GamePayloadOperationCodeAttribute(NetworkOperationCode.CMSG_AUTH_SRP6_BEGIN)]
[WireDataContractAttribute]
public sealed class CMSG_AUTH_SRP6_BEGIN_DTO_PROXY : GamePacketPayload, IUnimplementedGamePacketPayload
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

    public CMSG_AUTH_SRP6_BEGIN_DTO_PROXY()
    {
    }
}