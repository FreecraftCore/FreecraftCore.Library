using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using FreecraftCore.Serializer;
using FreecraftCore;
namespace FreecraftCore
{
    [AutoGeneratedWireMessageImplementationAttribute]
    public partial class RealmSplitResponse
    {
        public override Type SerializableType => typeof(RealmSplitResponse);
        public override GamePacketPayload Read(Span<byte> buffer, ref int offset)
        {
            RealmSplitResponse_AutoGeneratedTemplateSerializerStrategy.Instance.InternalRead(this, buffer, ref offset);
            return this;
        }
        public override void Write(GamePacketPayload value, Span<byte> buffer, ref int offset)
        {
            RealmSplitResponse_AutoGeneratedTemplateSerializerStrategy.Instance.InternalWrite(this, buffer, ref offset);
        }
    }
}

namespace FreecraftCore.Serializer
{
    //THIS CODE IS FOR AUTO-GENERATED SERIALIZERS! DO NOT MODIFY UNLESS YOU KNOW WELL!
    /// <summary>
    /// FreecraftCore.Serializer's AUTO-GENERATED (do not edit) serialization
    /// code for the Type: <see cref="RealmSplitResponse"/>
    /// </summary>
    public sealed partial class RealmSplitResponse_AutoGeneratedTemplateSerializerStrategy
        : BaseAutoGeneratedSerializerStrategy<RealmSplitResponse_AutoGeneratedTemplateSerializerStrategy, RealmSplitResponse>
    {
        /// <summary>
        /// Auto-generated deserialization/read method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalRead(RealmSplitResponse value, Span<byte> buffer, ref int offset)
        {
            //Type: GamePacketPayload Field: 1 Name: OperationCode Type: NetworkOperationCode;
            value.OperationCode = GenericPrimitiveEnumTypeSerializerStrategy<NetworkOperationCode, UInt16>.Instance.Read(buffer, ref offset);
            //Type: RealmSplitResponse Field: 1 Name: Unk Type: Int32;
            value.Unk = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
            //Type: RealmSplitResponse Field: 2 Name: SplitState Type: RealmSplitState;
            value.SplitState = GenericPrimitiveEnumTypeSerializerStrategy<FreecraftCore.RealmSplitResponse.RealmSplitState, Int32>.Instance.Read(buffer, ref offset);
            //Type: RealmSplitResponse Field: 3 Name: SplitDate Type: String;
            value.SplitDate = TerminatedStringTypeSerializerStrategy<ASCIIStringTypeSerializerStrategy, ASCIIStringTerminatorTypeSerializerStrategy>.Instance.Read(buffer, ref offset);
        }

        /// <summary>
        /// Auto-generated serialization/write method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalWrite(RealmSplitResponse value, Span<byte> buffer, ref int offset)
        {
            //Type: GamePacketPayload Field: 1 Name: OperationCode Type: NetworkOperationCode;
            GenericPrimitiveEnumTypeSerializerStrategy<NetworkOperationCode, UInt16>.Instance.Write(value.OperationCode, buffer, ref offset);
            //Type: RealmSplitResponse Field: 1 Name: Unk Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.Unk, buffer, ref offset);
            //Type: RealmSplitResponse Field: 2 Name: SplitState Type: RealmSplitState;
            GenericPrimitiveEnumTypeSerializerStrategy<FreecraftCore.RealmSplitResponse.RealmSplitState, Int32>.Instance.Write(value.SplitState, buffer, ref offset);
            //Type: RealmSplitResponse Field: 3 Name: SplitDate Type: String;
            TerminatedStringTypeSerializerStrategy<ASCIIStringTypeSerializerStrategy, ASCIIStringTerminatorTypeSerializerStrategy>.Instance.Write(value.SplitDate, buffer, ref offset);
        }
    }
}