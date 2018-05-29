using FreecraftCore;
using FreecraftCore.Serializer;

[GamePayloadOperationCodeAttribute(NetworkOperationCode.SMSG_GAMEOBJECT_PAGETEXT)]
[WireDataContractAttribute]
public sealed class SMSG_GAMEOBJECT_PAGETEXT_DTO_PROXY : GamePacketPayload, IUnimplementedGamePacketPayload
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

    public SMSG_GAMEOBJECT_PAGETEXT_DTO_PROXY()
    {
    }
}