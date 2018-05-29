using FreecraftCore;
using FreecraftCore.Serializer;

[GamePayloadOperationCodeAttribute(NetworkOperationCode.SMSG_SPELL_UPDATE_CHAIN_TARGETS)]
[WireDataContractAttribute]
public sealed class SMSG_SPELL_UPDATE_CHAIN_TARGETS_DTO_PROXY : GamePacketPayload, IUnimplementedGamePacketPayload
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

    public SMSG_SPELL_UPDATE_CHAIN_TARGETS_DTO_PROXY()
    {
    }
}