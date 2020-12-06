using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using FreecraftCore.Serializer;
using FreecraftCore;
namespace FreecraftCore
{
    [AutoGeneratedWireMessageImplementationAttribute]
    public partial class RealmEndpoint : IWireMessage<RealmEndpoint>
    {
        public virtual Type SerializableType => typeof(RealmEndpoint);
        public virtual RealmEndpoint Read(Span<byte> buffer, ref int offset)
        {
            RealmEndpoint_AutoGeneratedTemplateSerializerStrategy.Instance.InternalRead(this, buffer, ref offset);
            return this;
        }
        public virtual void Write(RealmEndpoint value, Span<byte> buffer, ref int offset)
        {
            RealmEndpoint_AutoGeneratedTemplateSerializerStrategy.Instance.InternalWrite(this, buffer, ref offset);
        }
    }
}

namespace FreecraftCore.Serializer
{
    //THIS CODE IS FOR AUTO-GENERATED SERIALIZERS! DO NOT MODIFY UNLESS YOU KNOW WELL!
    /// <summary>
    /// FreecraftCore.Serializer's AUTO-GENERATED (do not edit) serialization
    /// code for the Type: <see cref="RealmEndpoint"/>
    /// </summary>
    public sealed partial class RealmEndpoint_AutoGeneratedTemplateSerializerStrategy
        : BaseAutoGeneratedSerializerStrategy<RealmEndpoint_AutoGeneratedTemplateSerializerStrategy, RealmEndpoint>
    {
        /// <summary>
        /// Auto-generated deserialization/read method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalRead(RealmEndpoint value, Span<byte> buffer, ref int offset)
        {
            //Type: RealmEndpoint Field: 1 Name: RealmEndpointInformation Type: String;
            value.RealmEndpointInformation = TerminatedStringTypeSerializerStrategy<ASCIIStringTypeSerializerStrategy, ASCIIStringTerminatorTypeSerializerStrategy>.Instance.Read(buffer, ref offset);
        }

        /// <summary>
        /// Auto-generated serialization/write method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalWrite(RealmEndpoint value, Span<byte> buffer, ref int offset)
        {
            //Type: RealmEndpoint Field: 1 Name: RealmEndpointInformation Type: String;
            TerminatedStringTypeSerializerStrategy<ASCIIStringTypeSerializerStrategy, ASCIIStringTerminatorTypeSerializerStrategy>.Instance.Write(value.RealmEndpointInformation, buffer, ref offset);
        }
    }
}