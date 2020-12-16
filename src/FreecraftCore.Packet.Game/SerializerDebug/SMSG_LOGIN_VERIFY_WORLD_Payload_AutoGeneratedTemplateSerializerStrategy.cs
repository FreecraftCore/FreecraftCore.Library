using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using FreecraftCore.Serializer;
using FreecraftCore;
namespace FreecraftCore
{
    [AutoGeneratedWireMessageImplementationAttribute]
    public partial class SMSG_LOGIN_VERIFY_WORLD_Payload
    {
        public override Type SerializableType => typeof(SMSG_LOGIN_VERIFY_WORLD_Payload);
        public override GamePacketPayload Read(Span<byte> buffer, ref int offset)
        {
            SMSG_LOGIN_VERIFY_WORLD_Payload_AutoGeneratedTemplateSerializerStrategy.Instance.InternalRead(this, buffer, ref offset);
            return this;
        }
        public override void Write(GamePacketPayload value, Span<byte> buffer, ref int offset)
        {
            SMSG_LOGIN_VERIFY_WORLD_Payload_AutoGeneratedTemplateSerializerStrategy.Instance.InternalWrite(this, buffer, ref offset);
        }
    }
}

namespace FreecraftCore.Serializer
{
    //THIS CODE IS FOR AUTO-GENERATED SERIALIZERS! DO NOT MODIFY UNLESS YOU KNOW WELL!
    /// <summary>
    /// FreecraftCore.Serializer's AUTO-GENERATED (do not edit) serialization
    /// code for the Type: <see cref="SMSG_LOGIN_VERIFY_WORLD_Payload"/>
    /// </summary>
    public sealed partial class SMSG_LOGIN_VERIFY_WORLD_Payload_AutoGeneratedTemplateSerializerStrategy
        : BaseAutoGeneratedSerializerStrategy<SMSG_LOGIN_VERIFY_WORLD_Payload_AutoGeneratedTemplateSerializerStrategy, SMSG_LOGIN_VERIFY_WORLD_Payload>
    {
        /// <summary>
        /// Auto-generated deserialization/read method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalRead(SMSG_LOGIN_VERIFY_WORLD_Payload value, Span<byte> buffer, ref int offset)
        {
            //Type: GamePacketPayload Field: 1 Name: OperationCode Type: NetworkOperationCode;
            value.OperationCode = GenericPrimitiveEnumTypeSerializerStrategy<NetworkOperationCode, UInt16>.Instance.Read(buffer, ref offset);
            //Type: SMSG_LOGIN_VERIFY_WORLD_Payload Field: 1 Name: MapId Type: Int32;
            value.MapId = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
            //Type: SMSG_LOGIN_VERIFY_WORLD_Payload Field: 2 Name: Position Type: Vector3;
            value.Position = Vector3_Single_AutoGeneratedTemplateSerializerStrategy.Instance.Read(buffer, ref offset);
            //Type: SMSG_LOGIN_VERIFY_WORLD_Payload Field: 3 Name: Orientation Type: Single;
            value.Orientation = GenericTypePrimitiveSerializerStrategy<Single>.Instance.Read(buffer, ref offset);
        }

        /// <summary>
        /// Auto-generated serialization/write method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalWrite(SMSG_LOGIN_VERIFY_WORLD_Payload value, Span<byte> buffer, ref int offset)
        {
            //Type: GamePacketPayload Field: 1 Name: OperationCode Type: NetworkOperationCode;
            GenericPrimitiveEnumTypeSerializerStrategy<NetworkOperationCode, UInt16>.Instance.Write(value.OperationCode, buffer, ref offset);
            //Type: SMSG_LOGIN_VERIFY_WORLD_Payload Field: 1 Name: MapId Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.MapId, buffer, ref offset);
            //Type: SMSG_LOGIN_VERIFY_WORLD_Payload Field: 2 Name: Position Type: Vector3;
            Vector3_Single_AutoGeneratedTemplateSerializerStrategy.Instance.Write(value.Position, buffer, ref offset);
            //Type: SMSG_LOGIN_VERIFY_WORLD_Payload Field: 3 Name: Orientation Type: Single;
            GenericTypePrimitiveSerializerStrategy<Single>.Instance.Write(value.Orientation, buffer, ref offset);
        }
    }
}