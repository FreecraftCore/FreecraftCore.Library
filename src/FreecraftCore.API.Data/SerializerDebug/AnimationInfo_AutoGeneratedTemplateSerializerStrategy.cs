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
    /// code for the Type: <see cref="AnimationInfo"/>
    /// </summary>
    public sealed partial class AnimationInfo_AutoGeneratedTemplateSerializerStrategy
        : BaseAutoGeneratedSerializerStrategy<AnimationInfo_AutoGeneratedTemplateSerializerStrategy, AnimationInfo>
    {
        /// <summary>
        /// Auto-generated deserialization/read method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalRead(AnimationInfo value, Span<byte> buffer, ref int offset)
        {
            //Type: AnimationInfo Field: 1 Name: AnimationId Type: Byte;
            value.AnimationId = BytePrimitiveSerializerStrategy.Instance.Read(buffer, ref offset);
            //Type: AnimationInfo Field: 2 Name: StartTime Type: Int32;
            value.StartTime = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
        }

        /// <summary>
        /// Auto-generated serialization/write method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalWrite(AnimationInfo value, Span<byte> buffer, ref int offset)
        {
            //Type: AnimationInfo Field: 1 Name: AnimationId Type: Byte;
            BytePrimitiveSerializerStrategy.Instance.Write(value.AnimationId, buffer, ref offset);
            //Type: AnimationInfo Field: 2 Name: StartTime Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.StartTime, buffer, ref offset);
        }
    }
}