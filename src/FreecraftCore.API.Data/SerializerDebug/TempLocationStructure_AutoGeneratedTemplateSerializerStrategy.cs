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
    /// code for the Type: <see cref="TempLocationStructure"/>
    /// </summary>
    public sealed partial class TempLocationStructure_AutoGeneratedTemplateSerializerStrategy
        : BaseAutoGeneratedSerializerStrategy<TempLocationStructure_AutoGeneratedTemplateSerializerStrategy, TempLocationStructure>
    {
        /// <summary>
        /// Auto-generated deserialization/read method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalRead(TempLocationStructure value, Span<byte> buffer, ref int offset)
        {
            //Type: TempLocationStructure Field: 1 Name: ZoneId Type: UInt32;
            value.ZoneId = GenericTypePrimitiveSerializerStrategy<UInt32>.Instance.Read(buffer, ref offset);
            //Type: TempLocationStructure Field: 2 Name: MapId Type: UInt32;
            value.MapId = GenericTypePrimitiveSerializerStrategy<UInt32>.Instance.Read(buffer, ref offset);
            //Type: TempLocationStructure Field: 3 Name: XPosition Type: Single;
            value.XPosition = GenericTypePrimitiveSerializerStrategy<Single>.Instance.Read(buffer, ref offset);
            //Type: TempLocationStructure Field: 4 Name: YPosition Type: Single;
            value.YPosition = GenericTypePrimitiveSerializerStrategy<Single>.Instance.Read(buffer, ref offset);
            //Type: TempLocationStructure Field: 5 Name: ZPosition Type: Single;
            value.ZPosition = GenericTypePrimitiveSerializerStrategy<Single>.Instance.Read(buffer, ref offset);
        }

        /// <summary>
        /// Auto-generated serialization/write method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalWrite(TempLocationStructure value, Span<byte> buffer, ref int offset)
        {
            //Type: TempLocationStructure Field: 1 Name: ZoneId Type: UInt32;
            GenericTypePrimitiveSerializerStrategy<UInt32>.Instance.Write(value.ZoneId, buffer, ref offset);
            //Type: TempLocationStructure Field: 2 Name: MapId Type: UInt32;
            GenericTypePrimitiveSerializerStrategy<UInt32>.Instance.Write(value.MapId, buffer, ref offset);
            //Type: TempLocationStructure Field: 3 Name: XPosition Type: Single;
            GenericTypePrimitiveSerializerStrategy<Single>.Instance.Write(value.XPosition, buffer, ref offset);
            //Type: TempLocationStructure Field: 4 Name: YPosition Type: Single;
            GenericTypePrimitiveSerializerStrategy<Single>.Instance.Write(value.YPosition, buffer, ref offset);
            //Type: TempLocationStructure Field: 5 Name: ZPosition Type: Single;
            GenericTypePrimitiveSerializerStrategy<Single>.Instance.Write(value.ZPosition, buffer, ref offset);
        }
    }
}