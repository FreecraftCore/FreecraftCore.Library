using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using FreecraftCore.Serializer;
using FreecraftCore;
namespace FreecraftCore
{
    [AutoGeneratedWireMessageImplementationAttribute]
    public partial class AuthRealmListRequest
    {
        public override Type SerializableType => typeof(AuthRealmListRequest);
        public override AuthenticationClientPayload Read(Span<byte> buffer, ref int offset)
        {
            AuthRealmListRequest_AutoGeneratedTemplateSerializerStrategy.Instance.InternalRead(this, buffer, ref offset);
            return this;
        }
        public override void Write(AuthenticationClientPayload value, Span<byte> buffer, ref int offset)
        {
            AuthRealmListRequest_AutoGeneratedTemplateSerializerStrategy.Instance.InternalWrite(this, buffer, ref offset);
        }
    }
}

namespace FreecraftCore.Serializer
{
    //THIS CODE IS FOR AUTO-GENERATED SERIALIZERS! DO NOT MODIFY UNLESS YOU KNOW WELL!
    /// <summary>
    /// FreecraftCore.Serializer's AUTO-GENERATED (do not edit) serialization
    /// code for the Type: <see cref="AuthRealmListRequest"/>
    /// </summary>
    public sealed partial class AuthRealmListRequest_AutoGeneratedTemplateSerializerStrategy
        : BaseAutoGeneratedSerializerStrategy<AuthRealmListRequest_AutoGeneratedTemplateSerializerStrategy, AuthRealmListRequest>
    {
        /// <summary>
        /// Auto-generated deserialization/read method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalRead(AuthRealmListRequest value, Span<byte> buffer, ref int offset)
        {
            //Type: AuthenticationClientPayload Field: 1 Name: OperationCode Type: AuthOperationCode;
            value.OperationCode = GenericPrimitiveEnumTypeSerializerStrategy<AuthOperationCode, Byte>.Instance.Read(buffer, ref offset);
            //Type: AuthRealmListRequest Field: 1 Name: unknownValue Type: Int32;
            value.unknownValue = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
        }

        /// <summary>
        /// Auto-generated serialization/write method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalWrite(AuthRealmListRequest value, Span<byte> buffer, ref int offset)
        {
            //Type: AuthenticationClientPayload Field: 1 Name: OperationCode Type: AuthOperationCode;
            GenericPrimitiveEnumTypeSerializerStrategy<AuthOperationCode, Byte>.Instance.Write(value.OperationCode, buffer, ref offset);
            //Type: AuthRealmListRequest Field: 1 Name: unknownValue Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.unknownValue, buffer, ref offset);
        }
    }
}