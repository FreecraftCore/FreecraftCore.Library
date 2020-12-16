using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	//Cmangos and Mangos do not handle this on 1.12.1. Vanilla format does not matter.
	/// <summary>
	/// Sent by the client to set some client data.
	/// </summary>
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.CMSG_UPDATE_ACCOUNT_DATA)]
	public sealed partial class CMSG_UPDATE_ACCOUNT_DATA_PAYLOAD : GamePacketPayload
	{
		//TODO: Extract out of the class
		public enum AccountDataType : int
		{
			GLOBAL_CONFIG_CACHE = 0,                    // 0x01 g
			PER_CHARACTER_CONFIG_CACHE = 1,                    // 0x02 p
			GLOBAL_BINDINGS_CACHE = 2,                    // 0x04 g
			PER_CHARACTER_BINDINGS_CACHE = 3,                    // 0x08 p
			GLOBAL_MACROS_CACHE = 4,                    // 0x10 g
			PER_CHARACTER_MACROS_CACHE = 5,                    // 0x20 p
			PER_CHARACTER_LAYOUT_CACHE = 6,                    // 0x40 p
			PER_CHARACTER_CHAT_CACHE = 7                     // 0x80 p
		}

		/// <summary>
		/// The type of data.
		/// </summary>
		[WireMember(1)]
		public AccountDataType DataType { get; internal set; }

		//TODO: Create timestamp type.
		/// <summary>
		/// The time stamp? Maybe when the client created the data?
		/// </summary>
		[Encoding(EncodingType.ASCII)]
		[WireMember(2)]
		public string TimeStamp { get; internal set; }

		//Some compressed data here
		//On TC it appears to be a string. Might be planitext LUA? Config text?
		/// <summary>
		/// Text-based configuration data.
		/// </summary>
		[Compress]
		[Encoding(EncodingType.ASCII)]
		[WireMember(3)]
		public string ConfigData { get; internal set; }

		/// <inheritdoc />
		public CMSG_UPDATE_ACCOUNT_DATA_PAYLOAD(AccountDataType dataType, [NotNull] string timeStamp, [NotNull] string configData)
			: this()
		{
			DataType = dataType;
			TimeStamp = timeStamp ?? throw new ArgumentNullException(nameof(timeStamp));
			ConfigData = configData ?? throw new ArgumentNullException(nameof(configData));
		}


		public CMSG_UPDATE_ACCOUNT_DATA_PAYLOAD()
			: base(NetworkOperationCode.CMSG_UPDATE_ACCOUNT_DATA)
		{
			
		}
	}
}
