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
    /// code for the Type: <see cref="ItemDamageDefinition"/>
    /// </summary>
    public sealed partial class ItemDamageDefinition_AutoGeneratedTemplateSerializerStrategy
        : BaseAutoGeneratedSerializerStrategy<ItemDamageDefinition_AutoGeneratedTemplateSerializerStrategy, ItemDamageDefinition>
    {
        /// <summary>
        /// Auto-generated deserialization/read method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalRead(ItemDamageDefinition value, Span<byte> buffer, ref int offset)
        {
            //Type: ItemDamageDefinition Field: 1 Name: DamageMinimum Type: Int32;
            value.DamageMinimum = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
            //Type: ItemDamageDefinition Field: 2 Name: DamageMaximum Type: Int32;
            value.DamageMaximum = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
            //Type: ItemDamageDefinition Field: 3 Name: ResistId Type: Int32;
            value.ResistId = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
        }

        /// <summary>
        /// Auto-generated serialization/write method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalWrite(ItemDamageDefinition value, Span<byte> buffer, ref int offset)
        {
            //Type: ItemDamageDefinition Field: 1 Name: DamageMinimum Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.DamageMinimum, buffer, ref offset);
            //Type: ItemDamageDefinition Field: 2 Name: DamageMaximum Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.DamageMaximum, buffer, ref offset);
            //Type: ItemDamageDefinition Field: 3 Name: ResistId Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.ResistId, buffer, ref offset);
        }
    }
}