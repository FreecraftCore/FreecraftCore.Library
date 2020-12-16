using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using FreecraftCore.Serializer;
using FreecraftCore;

namespace FreecraftCore.Serializer
{
    //THIS CODE IS FOR AUTO-GENERATED SERIALIZERS! DO NOT MODIFY UNLESS YOU KNOW WELL!
    /// <summary>
    /// FreecraftCore.Serializer's AUTO-GENERATED (do not edit) serialization
    /// code for the Type: <see cref="StartSpellCastData"/>
    /// </summary>
    public sealed partial class StartSpellCastData_AutoGeneratedTemplateSerializerStrategy
        : BaseAutoGeneratedSerializerStrategy<StartSpellCastData_AutoGeneratedTemplateSerializerStrategy, StartSpellCastData>
    {
        /// <summary>
        /// Auto-generated deserialization/read method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalRead(StartSpellCastData value, Span<byte> buffer, ref int offset)
        {
            //Type: SpellCastData Field: 1 Name: SpellSource Type: PackedGuid;
            value.SpellSource = CustomPackedGuidTypeSerializer.Instance.Read(buffer, ref offset);
            //Type: SpellCastData Field: 2 Name: SpellTarget Type: PackedGuid;
            value.SpellTarget = CustomPackedGuidTypeSerializer.Instance.Read(buffer, ref offset);
            //Type: SpellCastData Field: 3 Name: SpellCastCount Type: Byte;
            value.SpellCastCount = BytePrimitiveSerializerStrategy.Instance.Read(buffer, ref offset);
            //Type: SpellCastData Field: 4 Name: SpellId Type: Int32;
            value.SpellId = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
            //Type: SpellCastData Field: 5 Name: CastFlags Type: SpellCastFlag;
            value.CastFlags = GenericPrimitiveEnumTypeSerializerStrategy<SpellCastFlag, UInt32>.Instance.Read(buffer, ref offset);
            //Type: SpellCastData Field: 6 Name: TimeDiff Type: UInt32;
            value.TimeDiff = GenericTypePrimitiveSerializerStrategy<UInt32>.Instance.Read(buffer, ref offset);
            //Type: SpellCastData Field: 7 Name: HitTargets Type: ObjectGuid[];
            if (value.HasHitInformation)value.HitTargets = SendSizeComplexArrayTypeSerializerStrategy<ObjectGuid_AutoGeneratedTemplateSerializerStrategy, ObjectGuid, Byte>.Instance.Read(buffer, ref offset);
            //Type: SpellCastData Field: 8 Name: SpellMisses Type: SpellMissInfo[];
            if (value.HasHitInformation)value.SpellMisses = SendSizeComplexArrayTypeSerializerStrategy<SpellMissInfo_AutoGeneratedTemplateSerializerStrategy, SpellMissInfo, Byte>.Instance.Read(buffer, ref offset);
            //Type: SpellCastData Field: 9 Name: TargetInfo Type: SpellTargetInfo;
            value.TargetInfo = SpellTargetInfo_AutoGeneratedTemplateSerializerStrategy.Instance.Read(buffer, ref offset);
            //Type: SpellCastData Field: 10 Name: PowerValue Type: Int32;
            if (value.HasPowerInformation)value.PowerValue = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
            //Type: SpellCastData Field: 11 Name: OptionalAdjustableMissle Type: AdjustableSpellMissleInfo;
            if (value.HasAdjustableMissle)value.OptionalAdjustableMissle = AdjustableSpellMissleInfo_AutoGeneratedTemplateSerializerStrategy.Instance.Read(buffer, ref offset);
            //Type: SpellCastData Field: 12 Name: AmunitionInformation Type: AmmoInfo;
            if (value.HasAmmo)value.AmunitionInformation = AmmoInfo_AutoGeneratedTemplateSerializerStrategy.Instance.Read(buffer, ref offset);
            //Type: SpellCastData Field: 13 Name: OptionalVisualChainData Type: UInt64;
            if (value.HasVisualChainData)value.OptionalVisualChainData = GenericTypePrimitiveSerializerStrategy<UInt64>.Instance.Read(buffer, ref offset);
            //Type: SpellCastData Field: 14 Name: UnkownTargetDestByte Type: Byte;
            if (value.HasTargetUnknownByte)value.UnkownTargetDestByte = BytePrimitiveSerializerStrategy.Instance.Read(buffer, ref offset);
        }

        /// <summary>
        /// Auto-generated serialization/write method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalWrite(StartSpellCastData value, Span<byte> buffer, ref int offset)
        {
            //Type: SpellCastData Field: 1 Name: SpellSource Type: PackedGuid;
            CustomPackedGuidTypeSerializer.Instance.Write(value.SpellSource, buffer, ref offset);
            //Type: SpellCastData Field: 2 Name: SpellTarget Type: PackedGuid;
            CustomPackedGuidTypeSerializer.Instance.Write(value.SpellTarget, buffer, ref offset);
            //Type: SpellCastData Field: 3 Name: SpellCastCount Type: Byte;
            BytePrimitiveSerializerStrategy.Instance.Write(value.SpellCastCount, buffer, ref offset);
            //Type: SpellCastData Field: 4 Name: SpellId Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.SpellId, buffer, ref offset);
            //Type: SpellCastData Field: 5 Name: CastFlags Type: SpellCastFlag;
            GenericPrimitiveEnumTypeSerializerStrategy<SpellCastFlag, UInt32>.Instance.Write(value.CastFlags, buffer, ref offset);
            //Type: SpellCastData Field: 6 Name: TimeDiff Type: UInt32;
            GenericTypePrimitiveSerializerStrategy<UInt32>.Instance.Write(value.TimeDiff, buffer, ref offset);
            //Type: SpellCastData Field: 7 Name: HitTargets Type: ObjectGuid[];
            if (value.HasHitInformation)SendSizeComplexArrayTypeSerializerStrategy<ObjectGuid_AutoGeneratedTemplateSerializerStrategy, ObjectGuid, Byte>.Instance.Write(value.HitTargets, buffer, ref offset);
            //Type: SpellCastData Field: 8 Name: SpellMisses Type: SpellMissInfo[];
            if (value.HasHitInformation)SendSizeComplexArrayTypeSerializerStrategy<SpellMissInfo_AutoGeneratedTemplateSerializerStrategy, SpellMissInfo, Byte>.Instance.Write(value.SpellMisses, buffer, ref offset);
            //Type: SpellCastData Field: 9 Name: TargetInfo Type: SpellTargetInfo;
            SpellTargetInfo_AutoGeneratedTemplateSerializerStrategy.Instance.Write(value.TargetInfo, buffer, ref offset);
            //Type: SpellCastData Field: 10 Name: PowerValue Type: Int32;
            if (value.HasPowerInformation)GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.PowerValue, buffer, ref offset);
            //Type: SpellCastData Field: 11 Name: OptionalAdjustableMissle Type: AdjustableSpellMissleInfo;
            if (value.HasAdjustableMissle)AdjustableSpellMissleInfo_AutoGeneratedTemplateSerializerStrategy.Instance.Write(value.OptionalAdjustableMissle, buffer, ref offset);
            //Type: SpellCastData Field: 12 Name: AmunitionInformation Type: AmmoInfo;
            if (value.HasAmmo)AmmoInfo_AutoGeneratedTemplateSerializerStrategy.Instance.Write(value.AmunitionInformation, buffer, ref offset);
            //Type: SpellCastData Field: 13 Name: OptionalVisualChainData Type: UInt64;
            if (value.HasVisualChainData)GenericTypePrimitiveSerializerStrategy<UInt64>.Instance.Write(value.OptionalVisualChainData, buffer, ref offset);
            //Type: SpellCastData Field: 14 Name: UnkownTargetDestByte Type: Byte;
            if (value.HasTargetUnknownByte)BytePrimitiveSerializerStrategy.Instance.Write(value.UnkownTargetDestByte, buffer, ref offset);
        }
    }
}