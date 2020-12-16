using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace FreecraftCore
{
	//AreaTrigger.dbc
	/// <summary>
	/// Table model for AreTrigger.dbc
	/// https://wowdev.wiki/DB/AreaTrigger
	/// </summary>
	[DBC]
	[WireDataContract]
	[JsonObject]
	[Table("AreaTrigger")]
	public class AreaTriggerEntry : IDBCEntryIdentifiable
	{
		/// <inheritdoc />
		[JsonIgnore]
		public int EntryId => AreaTriggerId;

		[Key]
		[WireMember(1)]
		public int AreaTriggerId { get; internal set; }

		//TODO: Ref nav prop to Map.dbc
		/// <summary>
		/// Reference to Map.dbc of the map this <see cref="AreaTriggerEntry"/> is in.
		/// </summary>
		[WireMember(2)]
		public int MapId { get; internal set; }

		[JsonIgnore]
		[ForeignKey(nameof(MapId))]
		public virtual MapEntry<string> Map { get; internal set; }

		/// <summary>
		/// Seems to be a box of size yards with center at x,y,z.
		/// </summary>
		[WireMember(3)]
		public Vector3<float> Position { get; internal set; }

		/// <summary>
		/// Seems to be a box of size yards with center at x,y,z
		/// </summary>
		[WireMember(4)]
		public float Radius { get; internal set; }

		/// <summary>
		/// Indicates if the box is a radius-based axis-aligned bounding box trigger.
		/// </summary>
		[NotMapped]
		[JsonIgnore]
		public bool isAxisAlignedBox => Math.Abs(Radius) > 0.0001f;

		//Most commonly used when size is 0, but not always
		/// <summary>
		/// When <see cref="Radius"/> is 0 this is sometimes used to define
		/// a non-uniform axis-aligned bounding box. Think a rectangular prism.
		/// BoxLength Float Most commonly used when size is 0, but not always
		/// BoxWidth Float
		/// BoxHeight Float
		/// </summary>
		[WireMember(5)]
		public Vector3<float> UnalignedBoxDimension { get; internal set; }

		//Most commonly used when size is 0, but not always
		/// <summary>
		/// Y-axis rotation.
		/// </summary>
		[WireMember(6)]
		public float Orientation { get; internal set; }

		public AreaTriggerEntry(int areaTriggerId, int mapId, [NotNull] Vector3<float> position, float radius, [NotNull] Vector3<float> unalignedBoxDimension, float orientation)
		{
			//Blizzlike DBC sometimes 0, so dumb!
			if (mapId < 0) throw new ArgumentOutOfRangeException(nameof(mapId));

			AreaTriggerId = areaTriggerId;
			MapId = mapId;
			Position = position ?? throw new ArgumentNullException(nameof(position));
			Radius = radius;
			UnalignedBoxDimension = unalignedBoxDimension ?? throw new ArgumentNullException(nameof(unalignedBoxDimension));
			Orientation = orientation;
		}

		/// <summary>
		/// Serializer ctor
		/// </summary>
		public AreaTriggerEntry()
		{

		}
	}
}
