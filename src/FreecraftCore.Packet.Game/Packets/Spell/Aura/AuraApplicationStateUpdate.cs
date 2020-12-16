using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using FreecraftCore.Serializer;
using Newtonsoft.Json;

namespace FreecraftCore
{
	[WireDataContract]
	public sealed class AuraApplicationStateUpdate
	{
		/// <summary>
		/// The aura flags for the application.
		/// </summary>
		[WireMember(3)]
		public AuraFlags Flags { get; internal set; }

		/// <summary>
		/// Indicates if the <see cref="AuraApplicationStateUpdate"/> has an associated
		/// caster guid.
		/// If it doesn't have a caster guid than the target is likely the caster.
		/// </summary>
		[JsonIgnore]
		[NotMapped]
		public bool HasCasterGuid => !Flags.HasFlag(AuraFlags.CASTER);

		/// <summary>
		/// Indicates if the <see cref="AuraApplicationStateUpdate"/> will sent duration data.
		/// </summary>
		[NotMapped]
		[JsonIgnore]
		public bool HasDuration => Flags.HasFlag(AuraFlags.DURATION);

		/// <summary>
		/// The level of the aura caster.
		/// </summary>
		[WireMember(4)]
		public byte CasterLevel { get; internal set; }

		/// <summary>
		/// The stack amount of charge amount for the aura application.
		/// Send stack amount for aura which could be stacked (never 0 - causes incorrect display) or charges
		/// Stack amount has priority over charges (checked on retail with spell 50262).
		/// </summary>
		[WireMember(5)]
		public byte CounterAmount { get; internal set; }

		/// <summary>
		/// Set if <see cref="HasCasterGuid"/> is true. <see cref="AuraFlags.CASTER"/>
		/// Optional: Will be empty if not sent. Meaning it either has no caster or the target is the caster.
		/// </summary>
		[Optional(nameof(HasCasterGuid))]
		[WireMember(6)]
		public PackedGuid CasterGuid { get; internal set; }

		/// <summary>
		/// Represents the total duration of the aura in milliseconds.
		/// </summary>
		[Optional(nameof(HasDuration))]
		[WireMember(7)]
		public int MaximumAuraDuration { get; internal set; }

		/// <summary>
		/// Represents the duration, counting down from <see cref="MaximumAuraDuration"/>
		/// </summary>
		[Optional(nameof(HasDuration))]
		[WireMember(8)]
		public int CurrentAuraDuration { get; internal set; }

		/// <summary>
		/// Indicates the percentage aura complete duration from 0.0f to 1.0f;
		/// </summary>
		[NotMapped]
		[JsonIgnore]
		public float AuraDurationPercentage
		{
			get
			{
				if (HasDuration)
					return (float) CurrentAuraDuration / MaximumAuraDuration;
				else
					return 0.0f; //it will be 0 / 0 otherwise.
			}
		}

		public AuraApplicationStateUpdate(AuraFlags flags, byte casterLevel, byte counterAmount, PackedGuid casterGuid, int maximumAuraDuration, int currentAuraDuration)
			: this(casterLevel, counterAmount, casterGuid, maximumAuraDuration, currentAuraDuration)
		{
			Flags = flags;

			if (!HasCasterGuid)
				throw new InvalidOperationException($"Cannot create: {nameof(AuraApplicationStateUpdate)} with Caster Guid without Flags: {AuraFlags.CASTER}.");

			if(!HasDuration)
				throw new InvalidOperationException($"Cannot create: {nameof(AuraApplicationStateUpdate)} with Duration without Flags: {AuraFlags.DURATION}.");
		}

		public AuraApplicationStateUpdate(AuraFlags flags, byte casterLevel, byte counterAmount, PackedGuid casterGuid)
			: this(casterLevel, counterAmount, casterGuid, 0, 0)
		{
			Flags = flags;

			if(!HasCasterGuid)
				throw new InvalidOperationException($"Cannot create: {nameof(AuraApplicationStateUpdate)} with Caster Guid without Flags: {AuraFlags.CASTER}.");
		}

		public AuraApplicationStateUpdate(AuraFlags flags, byte casterLevel, byte counterAmount, int maximumAuraDuration, int currentAuraDuration)
			: this(casterLevel, counterAmount, PackedGuid.Empty, maximumAuraDuration, currentAuraDuration)
		{
			Flags = flags;

			if(!HasDuration)
				throw new InvalidOperationException($"Cannot create: {nameof(AuraApplicationStateUpdate)} with Duration without Flags: {AuraFlags.DURATION}.");
		}

		internal AuraApplicationStateUpdate(byte casterLevel, byte counterAmount, PackedGuid casterGuid, int maximumAuraDuration, int currentAuraDuration)
		{
			CasterLevel = casterLevel;
			CounterAmount = counterAmount;
			CasterGuid = casterGuid;
			MaximumAuraDuration = maximumAuraDuration;
			CurrentAuraDuration = currentAuraDuration;
		}

		/// <summary>
		/// Serializer ctor.
		/// </summary>
		public AuraApplicationStateUpdate()
		{
			CasterGuid = PackedGuid.Empty;
		}
	}
}
