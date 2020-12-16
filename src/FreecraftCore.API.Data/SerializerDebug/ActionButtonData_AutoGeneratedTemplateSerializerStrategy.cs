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
    /// code for the Type: <see cref="ActionButtonData"/>
    /// </summary>
    public sealed partial class ActionButtonData_AutoGeneratedTemplateSerializerStrategy
        : BaseAutoGeneratedSerializerStrategy<ActionButtonData_AutoGeneratedTemplateSerializerStrategy, ActionButtonData>
    {
        /// <summary>
        /// Auto-generated deserialization/read method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalRead(ActionButtonData value, Span<byte> buffer, ref int offset)
        {
            //Type: ActionButtonData Field: 1 Name: PackedActionData Type: UInt32;
            value.PackedActionData = GenericTypePrimitiveSerializerStrategy<UInt32>.Instance.Read(buffer, ref offset);
        }

        /// <summary>
        /// Auto-generated serialization/write method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalWrite(ActionButtonData value, Span<byte> buffer, ref int offset)
        {
            //Type: ActionButtonData Field: 1 Name: PackedActionData Type: UInt32;
            GenericTypePrimitiveSerializerStrategy<UInt32>.Instance.Write(value.PackedActionData, buffer, ref offset);
        }
    }
}