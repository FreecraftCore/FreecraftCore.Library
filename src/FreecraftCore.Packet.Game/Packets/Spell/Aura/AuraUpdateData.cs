using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace FreecraftCore
{
	[WireDataContract]
	public sealed class AuraUpdateData
	{
		/// <summary>
		/// The 8-bit slot identifier of the aura application.
		/// Auras can range from slot 0-255. Meaning there is a maximum aura application cap of 255.
		/// </summary>
		[WireMember(1)]
		public byte SlotIndex { get; internal set; }

		/// <summary>
		/// The id of the spell associated with this aura.
		/// </summary>
		[WireMember(2)]
		public int AuraSpellId { get; internal set; }

		//TrinityCore sends SpellId 0 if the application slot is removed.
		[JsonIgnore]
		[NotMapped]
		public bool IsAuraRemoved => AuraSpellId == 0;

		/// <summary>
		/// Internal: Indicates if the aura has state data.
		/// </summary>
		[JsonIgnore]
		[NotMapped]
		internal bool HasAuraStateData => !IsAuraRemoved;

		/// <summary>
		/// Represents the optional state of the aura application.
		/// Optional: Null if <see cref="AuraSpellId"/> is 0 or if <see cref="IsAuraRemoved"/> is true.
		/// </summary>
		[Optional(nameof(HasAuraStateData))]
		[WireMember(3)]
		public AuraApplicationStateUpdate State { get; internal set; }

		/// <summary>
		/// Creates a new aura update state data structure.
		/// </summary>
		/// <param name="slotIndex">The slot index.</param>
		/// <param name="auraSpellId">The spell id.</param>
		/// <param name="state">The application state data.</param>
		public AuraUpdateData(byte slotIndex, int auraSpellId, [NotNull] AuraApplicationStateUpdate state)
		{
			//Cannot be 0 if the aura has state.
			if (auraSpellId <= 0) throw new ArgumentOutOfRangeException(nameof(auraSpellId));

			SlotIndex = slotIndex;
			AuraSpellId = auraSpellId;
			State = state ?? throw new ArgumentNullException(nameof(state));
		}

		public AuraUpdateData(byte slotIndex)
		{
			SlotIndex = slotIndex;
			AuraSpellId = 0;
			State = null;
		}

		/// <summary>
		/// Serializer ctor.
		/// </summary>
		public AuraUpdateData()
		{
			
		}
	}
}
