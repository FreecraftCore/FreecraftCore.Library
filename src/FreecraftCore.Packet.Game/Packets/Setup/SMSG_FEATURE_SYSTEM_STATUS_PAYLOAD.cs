using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	//Not sent in 1.12.1. TC says this is about enabling features such as voice chat.
	/// <summary>
	/// Packet sent by the server during a session login.
	/// It indicates a feature is enabled or disabled.
	/// </summary>
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.SMSG_FEATURE_SYSTEM_STATUS)]
	public sealed partial class SMSG_FEATURE_SYSTEM_STATUS_PAYLOAD : GamePacketPayload
	{
		//TODO: What is this?
		/// <summary>
		/// Unknown value. Maybe the feature type.
		/// </summary>
		[WireMember(1)]
		public byte Unk { get; internal set; } = 2;

		/// <summary>
		/// Indicates if the feature is enabled.
		/// </summary>
		[WireMember(2)]
		public bool isFeatureEnabled { get; internal set; }

		/// <inheritdoc />
		public SMSG_FEATURE_SYSTEM_STATUS_PAYLOAD(bool isFeatureEnabled)
			: this()
		{
			this.isFeatureEnabled = isFeatureEnabled;
		}

		public SMSG_FEATURE_SYSTEM_STATUS_PAYLOAD()
			: base(NetworkOperationCode.SMSG_FEATURE_SYSTEM_STATUS)
		{
			
		}
	}
}
