using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using FreecraftCore.Serializer;
using FreecraftCore;
namespace FreecraftCore
{
    [AutoGeneratedWireMessageImplementationAttribute]
    public partial class LogonProofResult : IWireMessage<LogonProofResult>
    {
        public virtual Type SerializableType => typeof(LogonProofResult);
        public virtual LogonProofResult Read(Span<byte> buffer, ref int offset)
        {
            LogonProofResult_AutoGeneratedTemplateSerializerStrategy.Instance.InternalRead(this, buffer, ref offset);
            return this;
        }
        public virtual void Write(LogonProofResult value, Span<byte> buffer, ref int offset)
        {
            LogonProofResult_AutoGeneratedTemplateSerializerStrategy.Instance.InternalWrite(this, buffer, ref offset);
        }
    }
}

namespace FreecraftCore.Serializer
{
    //THIS CODE IS FOR AUTO-GENERATED SERIALIZERS! DO NOT MODIFY UNLESS YOU KNOW WELL!
    /// <summary>
    /// FreecraftCore.Serializer's AUTO-GENERATED (do not edit) serialization
    /// code for the Type: <see cref="LogonProofResult"/>
    /// </summary>
    public sealed partial class LogonProofResult_AutoGeneratedTemplateSerializerStrategy
        : BasePolymorphicAutoGeneratedSerializerStrategy<LogonProofResult_AutoGeneratedTemplateSerializerStrategy, LogonProofResult, Byte>
    {
        protected override LogonProofResult CreateType(int key)
        {
            switch (key)
            {
                case 0:
                    return new LogonProofSuccess();
                case 4:
                    return new LogonProofFailure();
                default:
                    throw new NotImplementedException($"Encountered unimplemented sub-type for Type: {nameof(LogonProofResult)} with Key: {key}");
            }
        }
    }
}