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
    /// code for the Type: <see cref="Vector3<Int32>"/>
    /// </summary>
    public sealed partial class Vector3_Int32_AutoGeneratedTemplateSerializerStrategy
        : BaseAutoGeneratedSerializerStrategy<Vector3_Int32_AutoGeneratedTemplateSerializerStrategy, Vector3<Int32>>
    {
        /// <summary>
        /// Auto-generated deserialization/read method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalRead(Vector3<Int32> value, Span<byte> buffer, ref int offset)
        {
            //Type: Vector3 Field: 1 Name: X Type: Int32;
            value.X = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
            //Type: Vector3 Field: 2 Name: Y Type: Int32;
            value.Y = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
            //Type: Vector3 Field: 3 Name: Z Type: Int32;
            value.Z = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
        }

        /// <summary>
        /// Auto-generated serialization/write method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalWrite(Vector3<Int32> value, Span<byte> buffer, ref int offset)
        {
            //Type: Vector3 Field: 1 Name: X Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.X, buffer, ref offset);
            //Type: Vector3 Field: 2 Name: Y Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.Y, buffer, ref offset);
            //Type: Vector3 Field: 3 Name: Z Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.Z, buffer, ref offset);
        }
    }
}