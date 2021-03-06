using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Numerics;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace FreecraftCore
{
	//CreatureModelData.dbc
	/// <summary>
	/// Table model for CreatureModelData.dbc
	/// https://wowdev.wiki/DB/CreatureModelData
	/// </summary>
	[DBC]
	[WireDataContract]
	[JsonObject]
	[StringDBC(typeof(CreatureModelDataEntry<>))]
	[Table("CreatureModelData")]
	public class CreatureModelDataEntry<TStringType> : IDBCEntryIdentifiable
		where TStringType : class
	{
		[NotMapped]
		[JsonIgnore]
		public int EntryId => CreatureModelDataId;

		[Key]
		[WireMember(1)]
		public int CreatureModelDataId { get; internal set; }

		[WireMember(2)]
		public CreatureModelDataFlags Flags { get; internal set; }

		[WireMember(3)]
		public TStringType FilePath { get; internal set; }

		/// <summary>
		/// 4 got mostly big models (ragnaros, nef.) but again, not all big models got 4 ...
		/// </summary>
		[WireMember(4)]
		public int SizeClass { get; internal set; }

		/// <summary>
		/// CMD.Scale * CDI.Scale is used in CUnit.
		/// </summary>
		[WireMember(5)]
		public float ModelScale { get; internal set; }

		/// <summary>
		/// Nullable.
		/// See: <see cref="UnitBloodLevelsEntry"/>.
		/// </summary>
		[WireMember(6)]
		public int BloodLevelId { get; internal set; }

		/// <summary>
		/// Nullable
		/// See: <see cref="FootprintTexturesEntry{TStringType}"/>
		/// Defines the footpritns you leave in snow.
		/// </summary>
		[WireMember(7)]
		public int FootprintId { get; internal set; }

		/// <summary>
		/// Length and Width.
		/// Length: most time 18.0
		/// Width: mostly 12, others are 0.0 - 20.0
		/// </summary>
		[WireMember(8)]
		public Vector2<float> FootprintSize { get; internal set; }

		/// <summary>
		/// mostly 1.0, others are 0.0 - 5.0
		/// </summary>
		[WireMember(9)]
		public float FootprintParticleScale { get; internal set; }

		/// <summary>
		/// always 0.
		/// Unused??
		/// </summary>
		[WireMember(10)]
		public int FoleyMaterialId { get; internal set; }

		/// <summary>
		/// Nullable.
		/// See: <see cref="CameraShakesEntry"/>.
		/// </summary>
		[WireMember(11)]
		public int FootstepShakeId { get; internal set; }

		/// <summary>
		/// Nullable.
		/// See: <see cref="CameraShakesEntry"/>.
		/// </summary>
		[WireMember(12)]
		public int DeathThudShakeId { get; internal set; }

		/// <summary>
		/// Nullable. (rarely)
		/// See: <see cref="CreatureSoundDataEntry"/>.
		/// </summary>
		[WireMember(13)]
		public int SoundDataId { get; internal set; }

		/// <summary>
		/// Collision.
		/// Width: X - Size of collision for the model. Has to be bigger than 0.41670012920929, else "collision width is too small.".
		/// Height: Y - ZEROSCALEUNIT when 0-CollisionHeight LESSTHAN 0
		/// </summary>
		[WireMember(14)]
		public Vector2<float> Collision { get; internal set; }

		/// <summary>
		/// Other collision data?
		/// </summary>
		[WireMember(15)]
		public float MountHeight { get; internal set; }

		[WireMember(16)]
		public Vector3<float> GeoBoxMinimum { get; internal set; }

		[WireMember(17)]
		public Vector3<float> GeoBoxMaximum { get; internal set; }

		/// <summary>
		/// mostly 1.0, others are 0.03 - 0.9
		/// </summary>
		[WireMember(18)]
		public float WorldEffectScale { get; internal set; }

		/// <summary>
		/// mostly 1.0, others are 0.5 - 2.9
		/// </summary>
		[WireMember(19)]
		public float AttachedEffectScale { get; internal set; }

		[WireMember(20)]
		public float MissileCollisionRadius { get; internal set; }

		[WireMember(21)]
		public float MissileCollisionPush { get; internal set; }

		[WireMember(22)]
		public float MissileCollisionRaise { get; internal set; }

		public CreatureModelDataEntry(int creatureModelDataId, CreatureModelDataFlags flags, [NotNull] TStringType filePath, int sizeClass, float modelScale, int bloodLevelId, int footprintId, [NotNull] Vector2<float> footprintSize, float footprintParticleScale, int foleyMaterialId, int footstepShakeId, int deathThudShakeId, int soundDataId, [NotNull] Vector2<float> collision, float mountHeight, [NotNull] Vector3<float> geoBoxMinimum, [NotNull] Vector3<float> geoBoxMaximum, float worldEffectScale, float attachedEffectScale, float missileCollisionRadius, float missileCollisionPush, float missileCollisionRaise)
		{
			if (filePath == null) throw new ArgumentNullException(nameof(filePath));
			if (!Enum.IsDefined(typeof(CreatureModelDataFlags), flags)) throw new InvalidEnumArgumentException(nameof(flags), (int) flags, typeof(CreatureModelDataFlags));

			CreatureModelDataId = creatureModelDataId;
			Flags = flags;
			FilePath = filePath ?? throw new ArgumentNullException(nameof(filePath));
			SizeClass = sizeClass;
			ModelScale = modelScale;
			BloodLevelId = bloodLevelId;
			FootprintId = footprintId;
			FootprintSize = footprintSize ?? throw new ArgumentNullException(nameof(footprintSize));
			FootprintParticleScale = footprintParticleScale;
			FoleyMaterialId = foleyMaterialId;
			FootstepShakeId = footstepShakeId;
			DeathThudShakeId = deathThudShakeId;
			SoundDataId = soundDataId;
			Collision = collision ?? throw new ArgumentNullException(nameof(collision));
			MountHeight = mountHeight;
			GeoBoxMinimum = geoBoxMinimum ?? throw new ArgumentNullException(nameof(geoBoxMinimum));
			GeoBoxMaximum = geoBoxMaximum ?? throw new ArgumentNullException(nameof(geoBoxMaximum));
			WorldEffectScale = worldEffectScale;
			AttachedEffectScale = attachedEffectScale;
			MissileCollisionRadius = missileCollisionRadius;
			MissileCollisionPush = missileCollisionPush;
			MissileCollisionRaise = missileCollisionRaise;
		}

		//DBC Tools requires this to be public.
		/// <summary>
		/// Serializer ctor.
		/// </summary>
		public CreatureModelDataEntry()
		{
			
		}
	}
}
