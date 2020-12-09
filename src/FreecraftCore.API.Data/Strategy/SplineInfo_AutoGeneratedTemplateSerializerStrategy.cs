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
    /// code for the Type: <see cref="SplineInfo"/>
    /// </summary>
    public sealed partial class SplineInfo_AutoGeneratedTemplateSerializerStrategy
        : BaseAutoGeneratedSerializerStrategy<SplineInfo_AutoGeneratedTemplateSerializerStrategy, SplineInfo>
    {
        /// <summary>
        /// Auto-generated deserialization/read method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalRead(SplineInfo value, Span<byte> buffer, ref int offset)
        {
            //Type: SplineInfo Field: 1 Name: SplineFlags Type: SplineMoveFlags;
            value.SplineFlags = GenericPrimitiveEnumTypeSerializerStrategy<SplineMoveFlags, UInt32>.Instance.Read(buffer, ref offset);
            //Type: SplineInfo Field: 2 Name: FinalTarget Type: ObjectGuid;
            if (value.HasFinalTarget)value.FinalTarget = ObjectGuid_AutoGeneratedTemplateSerializerStrategy.Instance.Read(buffer, ref offset);
            //Type: SplineInfo Field: 3 Name: FinalOrientation Type: Single;
            if (value.HasFinalOrientation)value.FinalOrientation = GenericTypePrimitiveSerializerStrategy<Single>.Instance.Read(buffer, ref offset);
            //Type: SplineInfo Field: 4 Name: FinalPoint Type: Vector3;
            if (value.HasFinalPoint)value.FinalPoint = Vector3_Single_AutoGeneratedTemplateSerializerStrategy.Instance.Read(buffer, ref offset);
            //Type: SplineInfo Field: 5 Name: SplineTime Type: Int32;
            value.SplineTime = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
            //Type: SplineInfo Field: 6 Name: SplineFullTime Type: Int32;
            value.SplineFullTime = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
            //Type: SplineInfo Field: 7 Name: SplineId Type: Int32;
            value.SplineId = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
            //Type: SplineInfo Field: 8 Name: SplineDurationMultiplier Type: Single;
            value.SplineDurationMultiplier = GenericTypePrimitiveSerializerStrategy<Single>.Instance.Read(buffer, ref offset);
            //Type: SplineInfo Field: 9 Name: SplineDurationMultiplierNext Type: Single;
            value.SplineDurationMultiplierNext = GenericTypePrimitiveSerializerStrategy<Single>.Instance.Read(buffer, ref offset);
            //Type: SplineInfo Field: 10 Name: SplineVerticalAcceleration Type: Single;
            value.SplineVerticalAcceleration = GenericTypePrimitiveSerializerStrategy<Single>.Instance.Read(buffer, ref offset);
            //Type: SplineInfo Field: 11 Name: SplineStartTime Type: Int32;
            value.SplineStartTime = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
            //Type: SplineInfo Field: 12 Name: WayPoints Type: Vector3[];
            value.WayPoints = SendSizeComplexArrayTypeSerializerStrategy<Vector3_Single_AutoGeneratedTemplateSerializerStrategy, Vector3<float>, Int32>.Instance.Read(buffer, ref offset);
            //Type: SplineInfo Field: 13 Name: Mode Type: SplineMode;
            value.Mode = GenericPrimitiveEnumTypeSerializerStrategy<SplineMode, Byte>.Instance.Read(buffer, ref offset);
            //Type: SplineInfo Field: 14 Name: SplineEndpoint Type: Vector3;
            value.SplineEndpoint = Vector3_Single_AutoGeneratedTemplateSerializerStrategy.Instance.Read(buffer, ref offset);
        }

        /// <summary>
        /// Auto-generated serialization/write method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalWrite(SplineInfo value, Span<byte> buffer, ref int offset)
        {
            //Type: SplineInfo Field: 1 Name: SplineFlags Type: SplineMoveFlags;
            GenericPrimitiveEnumTypeSerializerStrategy<SplineMoveFlags, UInt32>.Instance.Write(value.SplineFlags, buffer, ref offset);
            //Type: SplineInfo Field: 2 Name: FinalTarget Type: ObjectGuid;
            if (value.HasFinalTarget)ObjectGuid_AutoGeneratedTemplateSerializerStrategy.Instance.Write(value.FinalTarget, buffer, ref offset);
            //Type: SplineInfo Field: 3 Name: FinalOrientation Type: Single;
            if (value.HasFinalOrientation)GenericTypePrimitiveSerializerStrategy<Single>.Instance.Write(value.FinalOrientation, buffer, ref offset);
            //Type: SplineInfo Field: 4 Name: FinalPoint Type: Vector3;
            if (value.HasFinalPoint)Vector3_Single_AutoGeneratedTemplateSerializerStrategy.Instance.Write(value.FinalPoint, buffer, ref offset);
            //Type: SplineInfo Field: 5 Name: SplineTime Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.SplineTime, buffer, ref offset);
            //Type: SplineInfo Field: 6 Name: SplineFullTime Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.SplineFullTime, buffer, ref offset);
            //Type: SplineInfo Field: 7 Name: SplineId Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.SplineId, buffer, ref offset);
            //Type: SplineInfo Field: 8 Name: SplineDurationMultiplier Type: Single;
            GenericTypePrimitiveSerializerStrategy<Single>.Instance.Write(value.SplineDurationMultiplier, buffer, ref offset);
            //Type: SplineInfo Field: 9 Name: SplineDurationMultiplierNext Type: Single;
            GenericTypePrimitiveSerializerStrategy<Single>.Instance.Write(value.SplineDurationMultiplierNext, buffer, ref offset);
            //Type: SplineInfo Field: 10 Name: SplineVerticalAcceleration Type: Single;
            GenericTypePrimitiveSerializerStrategy<Single>.Instance.Write(value.SplineVerticalAcceleration, buffer, ref offset);
            //Type: SplineInfo Field: 11 Name: SplineStartTime Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.SplineStartTime, buffer, ref offset);
            //Type: SplineInfo Field: 12 Name: WayPoints Type: Vector3[];
            SendSizeComplexArrayTypeSerializerStrategy<Vector3_Single_AutoGeneratedTemplateSerializerStrategy, Vector3<float>, Int32>.Instance.Write(value.WayPoints, buffer, ref offset);
            //Type: SplineInfo Field: 13 Name: Mode Type: SplineMode;
            GenericPrimitiveEnumTypeSerializerStrategy<SplineMode, Byte>.Instance.Write(value.Mode, buffer, ref offset);
            //Type: SplineInfo Field: 14 Name: SplineEndpoint Type: Vector3;
            Vector3_Single_AutoGeneratedTemplateSerializerStrategy.Instance.Write(value.SplineEndpoint, buffer, ref offset);
        }
    }
}