using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using FreecraftCore.Serializer;
using FreecraftCore;
namespace FreecraftCore
{
    [AutoGeneratedWireMessageImplementationAttribute]
    public partial class MSG_MOVE_START_PITCH_UP_Payload
    {
        public override Type SerializableType => typeof(MSG_MOVE_START_PITCH_UP_Payload);
        public override GamePacketPayload Read(Span<byte> buffer, ref int offset)
        {
            MSG_MOVE_START_PITCH_UP_Payload_AutoGeneratedTemplateSerializerStrategy.Instance.InternalRead(this, buffer, ref offset);
            return this;
        }
        public override void Write(GamePacketPayload value, Span<byte> buffer, ref int offset)
        {
            MSG_MOVE_START_PITCH_UP_Payload_AutoGeneratedTemplateSerializerStrategy.Instance.InternalWrite(this, buffer, ref offset);
        }
    }
}

namespace FreecraftCore.Serializer
{
    //THIS CODE IS FOR AUTO-GENERATED SERIALIZERS! DO NOT MODIFY UNLESS YOU KNOW WELL!
    /// <summary>
    /// FreecraftCore.Serializer's AUTO-GENERATED (do not edit) serialization
    /// code for the Type: <see cref="MSG_MOVE_START_PITCH_UP_Payload"/>
    /// </summary>
    public sealed partial class MSG_MOVE_START_PITCH_UP_Payload_AutoGeneratedTemplateSerializerStrategy
        : BaseAutoGeneratedSerializerStrategy<MSG_MOVE_START_PITCH_UP_Payload_AutoGeneratedTemplateSerializerStrategy, MSG_MOVE_START_PITCH_UP_Payload>
    {
        /// <summary>
        /// Auto-generated deserialization/read method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalRead(MSG_MOVE_START_PITCH_UP_Payload value, Span<byte> buffer, ref int offset)
        {
            //Type: GamePacketPayload Field: 1 Name: OperationCode Type: NetworkOperationCode;
            value.OperationCode = GenericPrimitiveEnumTypeSerializerStrategy<NetworkOperationCode, UInt16>.Instance.Read(buffer, ref offset);
            //Type: MSG_MOVE_START_PITCH_UP_Payload Field: 1 Name: MovementGuid Type: PackedGuid;
            value.MovementGuid = CustomPackedGuidTypeSerializer.Instance.Read(buffer, ref offset);
            //Type: MSG_MOVE_START_PITCH_UP_Payload Field: 2 Name: MoveInfo Type: MovementInfo;
            value.MoveInfo = MovementInfo_AutoGeneratedTemplateSerializerStrategy.Instance.Read(buffer, ref offset);
        }

        /// <summary>
        /// Auto-generated serialization/write method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalWrite(MSG_MOVE_START_PITCH_UP_Payload value, Span<byte> buffer, ref int offset)
        {
            //Type: GamePacketPayload Field: 1 Name: OperationCode Type: NetworkOperationCode;
            GenericPrimitiveEnumTypeSerializerStrategy<NetworkOperationCode, UInt16>.Instance.Write(value.OperationCode, buffer, ref offset);
            //Type: MSG_MOVE_START_PITCH_UP_Payload Field: 1 Name: MovementGuid Type: PackedGuid;
            CustomPackedGuidTypeSerializer.Instance.Write(value.MovementGuid, buffer, ref offset);
            //Type: MSG_MOVE_START_PITCH_UP_Payload Field: 2 Name: MoveInfo Type: MovementInfo;
            MovementInfo_AutoGeneratedTemplateSerializerStrategy.Instance.Write(value.MoveInfo, buffer, ref offset);
        }
    }
}