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
    /// code for the Type: <see cref="StringDBCReference"/>
    /// </summary>
    public sealed partial class StringDBCReference_AutoGeneratedTemplateSerializerStrategy
        : BaseAutoGeneratedSerializerStrategy<StringDBCReference_AutoGeneratedTemplateSerializerStrategy, StringDBCReference>
    {
        /// <summary>
        /// Auto-generated deserialization/read method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalRead(StringDBCReference value, Span<byte> buffer, ref int offset)
        {
            //Type: StringDBCReference Field: 1 Name: StringReferenceOffset Type: UInt32;
            value.StringReferenceOffset = GenericTypePrimitiveSerializerStrategy<UInt32>.Instance.Read(buffer, ref offset);
        }

        /// <summary>
        /// Auto-generated serialization/write method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalWrite(StringDBCReference value, Span<byte> buffer, ref int offset)
        {
            //Type: StringDBCReference Field: 1 Name: StringReferenceOffset Type: UInt32;
            GenericTypePrimitiveSerializerStrategy<UInt32>.Instance.Write(value.StringReferenceOffset, buffer, ref offset);
        }
    }
}