using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using FreecraftCore.Serializer;
using FreecraftCore;
namespace FreecraftCore
{
    [AutoGeneratedWireMessageImplementationAttribute]
    public partial class SMSG_TRANSFER_PENDING_Payload
    {
        public override Type SerializableType => typeof(SMSG_TRANSFER_PENDING_Payload);
        public override GamePacketPayload Read(Span<byte> buffer, ref int offset)
        {
            SMSG_TRANSFER_PENDING_Payload_AutoGeneratedTemplateSerializerStrategy.Instance.InternalRead(this, buffer, ref offset);
            return this;
        }
        public override void Write(GamePacketPayload value, Span<byte> buffer, ref int offset)
        {
            SMSG_TRANSFER_PENDING_Payload_AutoGeneratedTemplateSerializerStrategy.Instance.InternalWrite(this, buffer, ref offset);
        }
    }
}

namespace FreecraftCore.Serializer
{
    //THIS CODE IS FOR AUTO-GENERATED SERIALIZERS! DO NOT MODIFY UNLESS YOU KNOW WELL!
    /// <summary>
    /// FreecraftCore.Serializer's AUTO-GENERATED (do not edit) serialization
    /// code for the Type: <see cref="SMSG_TRANSFER_PENDING_Payload"/>
    /// </summary>
    public sealed partial class SMSG_TRANSFER_PENDING_Payload_AutoGeneratedTemplateSerializerStrategy
        : BaseAutoGeneratedSerializerStrategy<SMSG_TRANSFER_PENDING_Payload_AutoGeneratedTemplateSerializerStrategy, SMSG_TRANSFER_PENDING_Payload>
    {
        /// <summary>
        /// Auto-generated deserialization/read method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalRead(SMSG_TRANSFER_PENDING_Payload value, Span<byte> buffer, ref int offset)
        {
            //Type: GamePacketPayload Field: 1 Name: OperationCode Type: NetworkOperationCode;
            value.OperationCode = GenericPrimitiveEnumTypeSerializerStrategy<NetworkOperationCode, UInt16>.Instance.Read(buffer, ref offset);
            //Type: SMSG_TRANSFER_PENDING_Payload Field: 1 Name: MapId Type: Int32;
            value.MapId = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
        }

        /// <summary>
        /// Auto-generated serialization/write method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalWrite(SMSG_TRANSFER_PENDING_Payload value, Span<byte> buffer, ref int offset)
        {
            //Type: GamePacketPayload Field: 1 Name: OperationCode Type: NetworkOperationCode;
            GenericPrimitiveEnumTypeSerializerStrategy<NetworkOperationCode, UInt16>.Instance.Write(value.OperationCode, buffer, ref offset);
            //Type: SMSG_TRANSFER_PENDING_Payload Field: 1 Name: MapId Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.MapId, buffer, ref offset);
        }
    }
}