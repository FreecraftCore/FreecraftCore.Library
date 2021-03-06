using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using FreecraftCore.Serializer;
using FreecraftCore;
namespace FreecraftCore
{
    [AutoGeneratedWireMessageImplementationAttribute]
    public partial class ObjectUpdateDestroyObjectBlock
    {
        public override Type SerializableType => typeof(ObjectUpdateDestroyObjectBlock);
        public override ObjectUpdateBlock Read(Span<byte> buffer, ref int offset)
        {
            ObjectUpdateDestroyObjectBlock_AutoGeneratedTemplateSerializerStrategy.Instance.InternalRead(this, buffer, ref offset);
            return this;
        }
        public override void Write(ObjectUpdateBlock value, Span<byte> buffer, ref int offset)
        {
            ObjectUpdateDestroyObjectBlock_AutoGeneratedTemplateSerializerStrategy.Instance.InternalWrite(this, buffer, ref offset);
        }
    }
}

namespace FreecraftCore.Serializer
{
    //THIS CODE IS FOR AUTO-GENERATED SERIALIZERS! DO NOT MODIFY UNLESS YOU KNOW WELL!
    /// <summary>
    /// FreecraftCore.Serializer's AUTO-GENERATED (do not edit) serialization
    /// code for the Type: <see cref="ObjectUpdateDestroyObjectBlock"/>
    /// </summary>
    public sealed partial class ObjectUpdateDestroyObjectBlock_AutoGeneratedTemplateSerializerStrategy
        : BaseAutoGeneratedSerializerStrategy<ObjectUpdateDestroyObjectBlock_AutoGeneratedTemplateSerializerStrategy, ObjectUpdateDestroyObjectBlock>
    {
        /// <summary>
        /// Auto-generated deserialization/read method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalRead(ObjectUpdateDestroyObjectBlock value, Span<byte> buffer, ref int offset)
        {
            //Type: ObjectUpdateBlock Field: 1 Name: UpdateType Type: ObjectUpdateType;
            value.UpdateType = GenericPrimitiveEnumTypeSerializerStrategy<ObjectUpdateType, Byte>.Instance.Read(buffer, ref offset);
            //Type: ObjectUpdateDestroyObjectBlock Field: 1 Name: DestroyedGuids Type: PackedGuidCollection;
            value.DestroyedGuids = PackedGuidCollection_AutoGeneratedTemplateSerializerStrategy.Instance.Read(buffer, ref offset);
        }

        /// <summary>
        /// Auto-generated serialization/write method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalWrite(ObjectUpdateDestroyObjectBlock value, Span<byte> buffer, ref int offset)
        {
            //Type: ObjectUpdateBlock Field: 1 Name: UpdateType Type: ObjectUpdateType;
            GenericPrimitiveEnumTypeSerializerStrategy<ObjectUpdateType, Byte>.Instance.Write(value.UpdateType, buffer, ref offset);
            //Type: ObjectUpdateDestroyObjectBlock Field: 1 Name: DestroyedGuids Type: PackedGuidCollection;
            PackedGuidCollection_AutoGeneratedTemplateSerializerStrategy.Instance.Write(value.DestroyedGuids, buffer, ref offset);
        }
    }
}