using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using FreecraftCore.Serializer;
using FreecraftCore;
namespace FreecraftCore
{
    [AutoGeneratedWireMessageImplementationAttribute]
    public partial class AuthLogonProofRequest
    {
        public override Type SerializableType => typeof(AuthLogonProofRequest);
        public override AuthenticationClientPayload Read(Span<byte> buffer, ref int offset)
        {
            AuthLogonProofRequest_AutoGeneratedTemplateSerializerStrategy.Instance.InternalRead(this, buffer, ref offset);
            return this;
        }
        public override void Write(AuthenticationClientPayload value, Span<byte> buffer, ref int offset)
        {
            AuthLogonProofRequest_AutoGeneratedTemplateSerializerStrategy.Instance.InternalWrite(this, buffer, ref offset);
        }
    }
}

namespace FreecraftCore.Serializer
{
    //THIS CODE IS FOR AUTO-GENERATED SERIALIZERS! DO NOT MODIFY UNLESS YOU KNOW WELL!
    /// <summary>
    /// FreecraftCore.Serializer's AUTO-GENERATED (do not edit) serialization
    /// code for the Type: <see cref="AuthLogonProofRequest"/>
    /// </summary>
    public sealed partial class AuthLogonProofRequest_AutoGeneratedTemplateSerializerStrategy
        : BaseAutoGeneratedSerializerStrategy<AuthLogonProofRequest_AutoGeneratedTemplateSerializerStrategy, AuthLogonProofRequest>
    {
        /// <summary>
        /// Auto-generated deserialization/read method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalRead(AuthLogonProofRequest value, Span<byte> buffer, ref int offset)
        {
            //Type: AuthenticationClientPayload Field: 1 Name: OperationCode Type: AuthOperationCode;
            value.OperationCode = GenericPrimitiveEnumTypeSerializerStrategy<AuthOperationCode, Byte>.Instance.Read(buffer, ref offset);
            //Type: AuthLogonProofRequest Field: 1 Name: A Type: Byte[];
            value.A = FixedSizePrimitiveArrayTypeSerializerStrategy<byte, StaticTypedNumeric_Int32_32>.Instance.Read(buffer, ref offset);
            //Type: AuthLogonProofRequest Field: 2 Name: M1 Type: Byte[];
            value.M1 = FixedSizePrimitiveArrayTypeSerializerStrategy<byte, StaticTypedNumeric_Int32_20>.Instance.Read(buffer, ref offset);
            //Type: AuthLogonProofRequest Field: 3 Name: EphemeralClientFileHash Type: Byte[];
            value.EphemeralClientFileHash = FixedSizePrimitiveArrayTypeSerializerStrategy<byte, StaticTypedNumeric_Int32_20>.Instance.Read(buffer, ref offset);
            //Type: AuthLogonProofRequest Field: 4 Name: KeyCount Type: Byte;
            value.KeyCount = BytePrimitiveSerializerStrategy.Instance.Read(buffer, ref offset);
            //Type: AuthLogonProofRequest Field: 5 Name: securityFlags Type: Byte;
            value.securityFlags = BytePrimitiveSerializerStrategy.Instance.Read(buffer, ref offset);
        }

        /// <summary>
        /// Auto-generated serialization/write method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalWrite(AuthLogonProofRequest value, Span<byte> buffer, ref int offset)
        {
            //Type: AuthenticationClientPayload Field: 1 Name: OperationCode Type: AuthOperationCode;
            GenericPrimitiveEnumTypeSerializerStrategy<AuthOperationCode, Byte>.Instance.Write(value.OperationCode, buffer, ref offset);
            //Type: AuthLogonProofRequest Field: 1 Name: A Type: Byte[];
            FixedSizePrimitiveArrayTypeSerializerStrategy<byte, StaticTypedNumeric_Int32_32>.Instance.Write(value.A, buffer, ref offset);
            //Type: AuthLogonProofRequest Field: 2 Name: M1 Type: Byte[];
            FixedSizePrimitiveArrayTypeSerializerStrategy<byte, StaticTypedNumeric_Int32_20>.Instance.Write(value.M1, buffer, ref offset);
            //Type: AuthLogonProofRequest Field: 3 Name: EphemeralClientFileHash Type: Byte[];
            FixedSizePrimitiveArrayTypeSerializerStrategy<byte, StaticTypedNumeric_Int32_20>.Instance.Write(value.EphemeralClientFileHash, buffer, ref offset);
            //Type: AuthLogonProofRequest Field: 4 Name: KeyCount Type: Byte;
            BytePrimitiveSerializerStrategy.Instance.Write(value.KeyCount, buffer, ref offset);
            //Type: AuthLogonProofRequest Field: 5 Name: securityFlags Type: Byte;
            BytePrimitiveSerializerStrategy.Instance.Write(value.securityFlags, buffer, ref offset);
        }
        private sealed class StaticTypedNumeric_Int32_32 : StaticTypedNumeric<Int32> { public sealed override Int32 Value => 32; }
        private sealed class StaticTypedNumeric_Int32_20 : StaticTypedNumeric<Int32> { public sealed override Int32 Value => 20; }
    }
}