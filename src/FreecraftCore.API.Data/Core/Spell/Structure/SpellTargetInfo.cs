using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	[WireDataContract]
	public sealed class SpellTargetInfo
	{
		[WireMember(1)]
		public SpellCastTargetFlag TargetFlags { get; internal set; }

		public bool HasObjectTarget => (TargetFlags & (SpellCastTargetFlag.TARGET_FLAG_UNIT
			| SpellCastTargetFlag.TARGET_FLAG_UNIT_MINIPET | SpellCastTargetFlag.TARGET_FLAG_GAMEOBJECT
			| SpellCastTargetFlag.TARGET_FLAG_CORPSE_ENEMY | SpellCastTargetFlag.TARGET_FLAG_CORPSE_ALLY)) != 0;

		public bool HasItemTarget =>
			(TargetFlags & (SpellCastTargetFlag.TARGET_FLAG_ITEM | SpellCastTargetFlag.TARGET_FLAG_TRADE_ITEM)) != 0;

		public bool HasTransportSourceLocation => TargetFlags.HasFlag(SpellCastTargetFlag.TARGET_FLAG_SOURCE_LOCATION);

		public bool HasTransportDestinationLocation => TargetFlags.HasFlag(SpellCastTargetFlag.TARGET_FLAG_DEST_LOCATION);

		public bool HasTargetString => TargetFlags.HasFlag(SpellCastTargetFlag.TARGET_FLAG_STRING);

		//TODO: Can this ever have both TARGET_FLAG_SOURCE_LOCATION and TARGET_FLAG_DEST_LOCATION?
		[Optional(nameof(HasObjectTarget))]
		[WireMember(2)]
		public PackedGuid OptionalObjectTarget { get; internal set; }

		[Optional(nameof(HasItemTarget))]
		[WireMember(3)]
		public PackedGuid OptionalItemTarget { get; internal set; }

		[Optional(nameof(HasTransportSourceLocation))]
		[WireMember(4)]
		public PackedGuid OptionalTransportSourceLocation { get; internal set; }

		//Could be offset or position. It depends on if the guid is empty
		[Optional(nameof(HasTransportSourceLocation))]
		[WireMember(5)]
		public Vector3<float> OptionalTransportSourcePosition { get; internal set; }

		[Optional(nameof(HasTransportDestinationLocation))]
		[WireMember(6)]
		public PackedGuid OptionalTransportDestination { get; internal set; }

		//Could be offset or position. It depends on if the dest guid is empty.
		[Optional(nameof(HasTransportDestinationLocation))]
		[WireMember(7)]
		public Vector3<float> OptionalTransportDestinationPosition { get; internal set; }

		//Null terminator ASCII
		[Encoding(EncodingType.ASCII)]
		[Optional(nameof(HasTargetString))]
		[WireMember(8)]
		public string OptionalTargetString { get; internal set; }

		//TODO: Ctor overloads/builder.
		//TODO: Validate parameters
		public SpellTargetInfo(SpellCastTargetFlag targetFlags, PackedGuid optionalObjectTarget, PackedGuid optionalItemTarget, PackedGuid optionalTransportSourceLocation, Vector3<float> optionalTransportSourcePosition, PackedGuid optionalTransportDestination, Vector3<float> optionalTransportDestinationPosition, string optionalTargetString)
		{
			TargetFlags = targetFlags;
			OptionalObjectTarget = optionalObjectTarget;
			OptionalItemTarget = optionalItemTarget;
			OptionalTransportSourceLocation = optionalTransportSourceLocation;
			OptionalTransportSourcePosition = optionalTransportSourcePosition;
			OptionalTransportDestination = optionalTransportDestination;
			OptionalTransportDestinationPosition = optionalTransportDestinationPosition;
			OptionalTargetString = optionalTargetString;
		}

		public static SpellTargetInfo CreateSingleTargetUnitCast(ObjectGuid targetGuid)
		{
			return new SpellTargetInfo(SpellCastTargetFlag.TARGET_FLAG_UNIT, targetGuid, null, null, null, null, null, null);
		}

		/// <summary>
		/// Serializer ctor.
		/// </summary>
		public SpellTargetInfo()
		{
			
		}
	}
}
