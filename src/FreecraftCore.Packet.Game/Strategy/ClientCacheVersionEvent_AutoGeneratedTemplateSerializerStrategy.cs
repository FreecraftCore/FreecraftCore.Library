using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using FreecraftCore.Serializer;
using FreecraftCore;
namespace FreecraftCore
{
    [AutoGeneratedWireMessageImplementationAttribute]
    public partial class ClientCacheVersionEvent
    {
        public override Type SerializableType => typeof(ClientCacheVersionEvent);
        public override GamePacketPayload Read(Span<byte> buffer, ref int offset)
        {
            ClientCacheVersionEvent_AutoGeneratedTemplateSerializerStrategy.Instance.InternalRead(this, buffer, ref offset);
            return this;
        }
        public override void Write(GamePacketPayload value, Span<byte> buffer, ref int offset)
        {
            ClientCacheVersionEvent_AutoGeneratedTemplateSerializerStrategy.Instance.InternalWrite(this, buffer, ref offset);
        }
    }
}

namespace FreecraftCore.Serializer
{
    //THIS CODE IS FOR AUTO-GENERATED SERIALIZERS! DO NOT MODIFY UNLESS YOU KNOW WELL!
    /// <summary>
    /// FreecraftCore.Serializer's AUTO-GENERATED (do not edit) serialization
    /// code for the Type: <see cref="ClientCacheVersionEvent"/>
    /// </summary>
    public sealed partial class ClientCacheVersionEvent_AutoGeneratedTemplateSerializerStrategy
        : BaseAutoGeneratedSerializerStrategy<ClientCacheVersionEvent_AutoGeneratedTemplateSerializerStrategy, ClientCacheVersionEvent>
    {
        /// <summary>
        /// Auto-generated deserialization/read method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalRead(ClientCacheVersionEvent value, Span<byte> buffer, ref int offset)
        {
            //Type: GamePacketPayload Field: 1 Name: OperationCode Type: NetworkOperationCode;
            value.OperationCode = GenericPrimitiveEnumTypeSerializerStrategy<NetworkOperationCode, UInt16>.Instance.Read(buffer, ref offset);
            //Type: ClientCacheVersionEvent Field: 1 Name: Data Type: Byte[];
            value.Data = PrimitiveArrayTypeSerializerStrategy<byte>.Instance.Read(buffer, ref offset);
        }

        /// <summary>
        /// Auto-generated serialization/write method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalWrite(ClientCacheVersionEvent value, Span<byte> buffer, ref int offset)
        {
            //Type: GamePacketPayload Field: 1 Name: OperationCode Type: NetworkOperationCode;
            GenericPrimitiveEnumTypeSerializerStrategy<NetworkOperationCode, UInt16>.Instance.Write(value.OperationCode, buffer, ref offset);
            //Type: ClientCacheVersionEvent Field: 1 Name: Data Type: Byte[];
            PrimitiveArrayTypeSerializerStrategy<byte>.Instance.Write(value.Data, buffer, ref offset);
        }
    }
}