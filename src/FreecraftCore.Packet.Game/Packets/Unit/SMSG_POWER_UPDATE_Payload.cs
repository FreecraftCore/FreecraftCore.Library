using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	//1.12.1 servers do not send this.
	/// <summary>
	/// Send by the server to update a unit's power field.
	/// </summary>
	[GamePayloadOperationCode(NetworkOperationCode.SMSG_POWER_UPDATE)]
	[WireDataContract]
	public sealed partial class SMSG_POWER_UPDATE_Payload : GamePacketPayload
	{
		//TODO: Extract
		public enum Powers : byte
		{
			POWER_MANA = 0,
			POWER_RAGE = 1,
			POWER_FOCUS = 2,
			POWER_ENERGY = 3,
			POWER_HAPPINESS = 4,
			POWER_RUNE = 5,
			POWER_RUNIC_POWER = 6,
			MAX_POWERS = 7,
			POWER_ALL = 127,    // default for class?

			//TODO: Sent as byte but why is this on TC?
			//POWER_HEALTH = 0xFFFFFFFE    // (-2 as signed value)
		};

		/// <summary>
		/// The GUID that had the power update.
		/// </summary>
		[WireMember(1)]
		public PackedGuid UnitGuid { get; internal set; }

		/// <summary>
		/// The power type being updated.
		/// </summary>
		[WireMember(2)]
		public Powers PowerType { get; internal set; }

		/// <summary>
		/// The new power value.
		/// </summary>
		[WireMember(3)]
		public int NewValue { get; internal set; }

		/// <inheritdoc />
		public SMSG_POWER_UPDATE_Payload(PackedGuid unitGuid, Powers powerType, int newValue)
			: this()
		{
			UnitGuid = unitGuid;
			PowerType = powerType;
			NewValue = newValue;
		}

		/// <summary>
		/// Serializer ctor
		/// </summary>
		public SMSG_POWER_UPDATE_Payload()
			: base(NetworkOperationCode.SMSG_POWER_UPDATE)
		{
			
		}
	}
}
