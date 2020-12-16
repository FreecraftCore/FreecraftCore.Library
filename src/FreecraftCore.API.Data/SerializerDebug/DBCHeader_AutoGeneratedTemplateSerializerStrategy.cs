using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using FreecraftCore.Serializer;
using FreecraftCore;
namespace FreecraftCore
{
    [AutoGeneratedWireMessageImplementationAttribute]
    public partial class DBCHeader : IWireMessage<DBCHeader>
    {
        public Type SerializableType => typeof(DBCHeader);
        public DBCHeader Read(Span<byte> buffer, ref int offset)
        {
            DBCHeader_AutoGeneratedTemplateSerializerStrategy.Instance.InternalRead(this, buffer, ref offset);
            return this;
        }
        public void Write(DBCHeader value, Span<byte> buffer, ref int offset)
        {
            DBCHeader_AutoGeneratedTemplateSerializerStrategy.Instance.InternalWrite(this, buffer, ref offset);
        }
    }
}

namespace FreecraftCore.Serializer
{
    //THIS CODE IS FOR AUTO-GENERATED SERIALIZERS! DO NOT MODIFY UNLESS YOU KNOW WELL!
    /// <summary>
    /// FreecraftCore.Serializer's AUTO-GENERATED (do not edit) serialization
    /// code for the Type: <see cref="DBCHeader"/>
    /// </summary>
    public sealed partial class DBCHeader_AutoGeneratedTemplateSerializerStrategy
        : BaseAutoGeneratedSerializerStrategy<DBCHeader_AutoGeneratedTemplateSerializerStrategy, DBCHeader>
    {
        /// <summary>
        /// Auto-generated deserialization/read method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalRead(DBCHeader value, Span<byte> buffer, ref int offset)
        {
            //Type: DBCHeader Field: 1 Name: Signature Type: Int32;
            value.Signature = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
            //Type: DBCHeader Field: 2 Name: RecordsCount Type: Int32;
            value.RecordsCount = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
            //Type: DBCHeader Field: 3 Name: FieldsCount Type: Int32;
            value.FieldsCount = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
            //Type: DBCHeader Field: 4 Name: RecordSize Type: Int32;
            value.RecordSize = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
            //Type: DBCHeader Field: 5 Name: StringTableSize Type: Int32;
            value.StringTableSize = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
        }

        /// <summary>
        /// Auto-generated serialization/write method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalWrite(DBCHeader value, Span<byte> buffer, ref int offset)
        {
            //Type: DBCHeader Field: 1 Name: Signature Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.Signature, buffer, ref offset);
            //Type: DBCHeader Field: 2 Name: RecordsCount Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.RecordsCount, buffer, ref offset);
            //Type: DBCHeader Field: 3 Name: FieldsCount Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.FieldsCount, buffer, ref offset);
            //Type: DBCHeader Field: 4 Name: RecordSize Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.RecordSize, buffer, ref offset);
            //Type: DBCHeader Field: 5 Name: StringTableSize Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.StringTableSize, buffer, ref offset);
        }
    }
}