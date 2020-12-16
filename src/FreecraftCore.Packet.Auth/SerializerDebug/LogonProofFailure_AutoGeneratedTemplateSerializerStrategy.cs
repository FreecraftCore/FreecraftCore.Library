using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using FreecraftCore.Serializer;
using FreecraftCore;
namespace FreecraftCore
{
    [AutoGeneratedWireMessageImplementationAttribute]
    public partial class LogonProofFailure
    {
        public override Type SerializableType => typeof(LogonProofFailure);
        public override LogonProofResult Read(Span<byte> buffer, ref int offset)
        {
            LogonProofFailure_AutoGeneratedTemplateSerializerStrategy.Instance.InternalRead(this, buffer, ref offset);
            return this;
        }
        public override void Write(LogonProofResult value, Span<byte> buffer, ref int offset)
        {
            LogonProofFailure_AutoGeneratedTemplateSerializerStrategy.Instance.InternalWrite(this, buffer, ref offset);
        }
    }
}

namespace FreecraftCore.Serializer
{
    //THIS CODE IS FOR AUTO-GENERATED SERIALIZERS! DO NOT MODIFY UNLESS YOU KNOW WELL!
    /// <summary>
    /// FreecraftCore.Serializer's AUTO-GENERATED (do not edit) serialization
    /// code for the Type: <see cref="LogonProofFailure"/>
    /// </summary>
    public sealed partial class LogonProofFailure_AutoGeneratedTemplateSerializerStrategy
        : BaseAutoGeneratedSerializerStrategy<LogonProofFailure_AutoGeneratedTemplateSerializerStrategy, LogonProofFailure>
    {
        /// <summary>
        /// Auto-generated deserialization/read method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalRead(LogonProofFailure value, Span<byte> buffer, ref int offset)
        {
            //Type: LogonProofResult Field: 1 Name: Result Type: AuthenticationResult;
            value.Result = GenericPrimitiveEnumTypeSerializerStrategy<AuthenticationResult, Byte>.Instance.Read(buffer, ref offset);
            //Type: LogonProofFailure Field: 1 Name: unknownOne Type: Byte;
            value.unknownOne = BytePrimitiveSerializerStrategy.Instance.Read(buffer, ref offset);
            //Type: LogonProofFailure Field: 2 Name: unknownTwo Type: Byte;
            value.unknownTwo = BytePrimitiveSerializerStrategy.Instance.Read(buffer, ref offset);
        }

        /// <summary>
        /// Auto-generated serialization/write method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalWrite(LogonProofFailure value, Span<byte> buffer, ref int offset)
        {
            //Type: LogonProofResult Field: 1 Name: Result Type: AuthenticationResult;
            GenericPrimitiveEnumTypeSerializerStrategy<AuthenticationResult, Byte>.Instance.Write(value.Result, buffer, ref offset);
            //Type: LogonProofFailure Field: 1 Name: unknownOne Type: Byte;
            BytePrimitiveSerializerStrategy.Instance.Write(value.unknownOne, buffer, ref offset);
            //Type: LogonProofFailure Field: 2 Name: unknownTwo Type: Byte;
            BytePrimitiveSerializerStrategy.Instance.Write(value.unknownTwo, buffer, ref offset);
        }
    }
}