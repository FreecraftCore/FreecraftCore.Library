using FreecraftCore.Serializer;


namespace FreecraftCore
{
	//Check Trinitycore's AuthSession.cpp for more information
	/// <summary>
	/// Enumeration of all authentication operations.
	/// </summary>
	[WireDataContract]
	public enum AuthOperationCode : byte //Auth OPCodes are bytes (uint8) unlike other op codes
	{
		//TODO: Document
		AUTH_LOGON_CHALLENGE = 0x00,
		AUTH_LOGON_PROOF = 0x01,
		AUTH_RECONNECT_CHALLENGE = 0x02,
		AUTH_RECONNECT_PROOF = 0x03,
		REALM_LIST = 0x10,
		XFER_INITIATE = 0x30,
		XFER_DATA = 0x31,
		XFER_ACCEPT = 0x32,
		XFER_RESUME = 0x33,
		XFER_CANCEL = 0x34,
		END = 0x35
	}
}
