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
    /// code for the Type: <see cref="SpellFailureData"/>
    /// </summary>
    public sealed partial class SpellFailureData_AutoGeneratedTemplateSerializerStrategy
        : BaseAutoGeneratedSerializerStrategy<SpellFailureData_AutoGeneratedTemplateSerializerStrategy, SpellFailureData>
    {
        /// <summary>
        /// Auto-generated deserialization/read method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalRead(SpellFailureData value, Span<byte> buffer, ref int offset)
        {
            //Type: SpellFailureData Field: 1 Name: Caster Type: PackedGuid;
            value.Caster = CustomPackedGuidTypeSerializer.Instance.Read(buffer, ref offset);
            //Type: SpellFailureData Field: 2 Name: SpellCastCount Type: Byte;
            value.SpellCastCount = BytePrimitiveSerializerStrategy.Instance.Read(buffer, ref offset);
            //Type: SpellFailureData Field: 3 Name: SpellId Type: Int32;
            value.SpellId = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
            //Type: SpellFailureData Field: 4 Name: Result Type: Byte;
            value.Result = BytePrimitiveSerializerStrategy.Instance.Read(buffer, ref offset);
        }

        /// <summary>
        /// Auto-generated serialization/write method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalWrite(SpellFailureData value, Span<byte> buffer, ref int offset)
        {
            //Type: SpellFailureData Field: 1 Name: Caster Type: PackedGuid;
            CustomPackedGuidTypeSerializer.Instance.Write(value.Caster, buffer, ref offset);
            //Type: SpellFailureData Field: 2 Name: SpellCastCount Type: Byte;
            BytePrimitiveSerializerStrategy.Instance.Write(value.SpellCastCount, buffer, ref offset);
            //Type: SpellFailureData Field: 3 Name: SpellId Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.SpellId, buffer, ref offset);
            //Type: SpellFailureData Field: 4 Name: Result Type: Byte;
            BytePrimitiveSerializerStrategy.Instance.Write(value.Result, buffer, ref offset);
        }
    }
}