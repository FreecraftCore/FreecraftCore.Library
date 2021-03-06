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
    /// code for the Type: <see cref="StatInfo"/>
    /// </summary>
    public sealed partial class StatInfo_AutoGeneratedTemplateSerializerStrategy
        : BaseAutoGeneratedSerializerStrategy<StatInfo_AutoGeneratedTemplateSerializerStrategy, StatInfo>
    {
        /// <summary>
        /// Auto-generated deserialization/read method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalRead(StatInfo value, Span<byte> buffer, ref int offset)
        {
            //Type: StatInfo Field: 1 Name: StatType Type: ItemModType;
            value.StatType = GenericPrimitiveEnumTypeSerializerStrategy<ItemModType, Int32>.Instance.Read(buffer, ref offset);
        }

        /// <summary>
        /// Auto-generated serialization/write method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalWrite(StatInfo value, Span<byte> buffer, ref int offset)
        {
            //Type: StatInfo Field: 1 Name: StatType Type: ItemModType;
            GenericPrimitiveEnumTypeSerializerStrategy<ItemModType, Int32>.Instance.Write(value.StatType, buffer, ref offset);
        }
    }
}