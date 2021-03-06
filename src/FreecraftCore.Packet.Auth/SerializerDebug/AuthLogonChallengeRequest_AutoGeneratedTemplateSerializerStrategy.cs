using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using FreecraftCore.Serializer;
using FreecraftCore;
namespace FreecraftCore
{
    [AutoGeneratedWireMessageImplementationAttribute]
    public partial class AuthLogonChallengeRequest
    {
        public override Type SerializableType => typeof(AuthLogonChallengeRequest);
        public override AuthenticationClientPayload Read(Span<byte> buffer, ref int offset)
        {
            AuthLogonChallengeRequest_AutoGeneratedTemplateSerializerStrategy.Instance.InternalRead(this, buffer, ref offset);
            return this;
        }
        public override void Write(AuthenticationClientPayload value, Span<byte> buffer, ref int offset)
        {
            AuthLogonChallengeRequest_AutoGeneratedTemplateSerializerStrategy.Instance.InternalWrite(this, buffer, ref offset);
        }
    }
}

namespace FreecraftCore.Serializer
{
    //THIS CODE IS FOR AUTO-GENERATED SERIALIZERS! DO NOT MODIFY UNLESS YOU KNOW WELL!
    /// <summary>
    /// FreecraftCore.Serializer's AUTO-GENERATED (do not edit) serialization
    /// code for the Type: <see cref="AuthLogonChallengeRequest"/>
    /// </summary>
    public sealed partial class AuthLogonChallengeRequest_AutoGeneratedTemplateSerializerStrategy
        : BaseAutoGeneratedSerializerStrategy<AuthLogonChallengeRequest_AutoGeneratedTemplateSerializerStrategy, AuthLogonChallengeRequest>
    {
        /// <summary>
        /// Auto-generated deserialization/read method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalRead(AuthLogonChallengeRequest value, Span<byte> buffer, ref int offset)
        {
            //Type: AuthenticationClientPayload Field: 1 Name: OperationCode Type: AuthOperationCode;
            value.OperationCode = GenericPrimitiveEnumTypeSerializerStrategy<AuthOperationCode, Byte>.Instance.Read(buffer, ref offset);
            //Type: AuthLogonChallengeRequest Field: 1 Name: Challenge Type: AuthChallengeData;
            value.Challenge = AuthChallengeData_AutoGeneratedTemplateSerializerStrategy.Instance.Read(buffer, ref offset);
        }

        /// <summary>
        /// Auto-generated serialization/write method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalWrite(AuthLogonChallengeRequest value, Span<byte> buffer, ref int offset)
        {
            //Type: AuthenticationClientPayload Field: 1 Name: OperationCode Type: AuthOperationCode;
            GenericPrimitiveEnumTypeSerializerStrategy<AuthOperationCode, Byte>.Instance.Write(value.OperationCode, buffer, ref offset);
            //Type: AuthLogonChallengeRequest Field: 1 Name: Challenge Type: AuthChallengeData;
            AuthChallengeData_AutoGeneratedTemplateSerializerStrategy.Instance.Write(value.Challenge, buffer, ref offset);
        }
    }
}