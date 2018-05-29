using FreecraftCore;
using FreecraftCore.Serializer;

[GamePayloadOperationCodeAttribute(NetworkOperationCode.SMSG_CALENDAR_EVENT_UPDATED_ALERT)]
[WireDataContractAttribute]
public sealed class SMSG_CALENDAR_EVENT_UPDATED_ALERT_DTO_PROXY : GamePacketPayload, IUnimplementedGamePacketPayload
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

    public SMSG_CALENDAR_EVENT_UPDATED_ALERT_DTO_PROXY()
    {
    }
}