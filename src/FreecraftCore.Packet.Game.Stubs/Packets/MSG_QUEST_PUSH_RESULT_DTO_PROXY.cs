using FreecraftCore;
using FreecraftCore.Serializer;

[GamePayloadOperationCodeAttribute(NetworkOperationCode.MSG_QUEST_PUSH_RESULT)]
[WireDataContractAttribute]
public sealed class MSG_QUEST_PUSH_RESULT_DTO_PROXY : GamePacketPayload, IUnimplementedGamePacketPayload
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

    public MSG_QUEST_PUSH_RESULT_DTO_PROXY()
    {
    }
}