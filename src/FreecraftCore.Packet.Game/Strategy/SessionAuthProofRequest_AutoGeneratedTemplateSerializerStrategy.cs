using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using FreecraftCore.Serializer;
using FreecraftCore;
namespace FreecraftCore
{
    [AutoGeneratedWireMessageImplementationAttribute]
    public partial class SessionAuthProofRequest
    {
        public override Type SerializableType => typeof(SessionAuthProofRequest);
        public override GamePacketPayload Read(Span<byte> buffer, ref int offset)
        {
            SessionAuthProofRequest_AutoGeneratedTemplateSerializerStrategy.Instance.InternalRead(this, buffer, ref offset);
            return this;
        }
        public override void Write(GamePacketPayload value, Span<byte> buffer, ref int offset)
        {
            SessionAuthProofRequest_AutoGeneratedTemplateSerializerStrategy.Instance.InternalWrite(this, buffer, ref offset);
        }
    }
}

namespace FreecraftCore.Serializer
{
    //THIS CODE IS FOR AUTO-GENERATED SERIALIZERS! DO NOT MODIFY UNLESS YOU KNOW WELL!
    /// <summary>
    /// FreecraftCore.Serializer's AUTO-GENERATED (do not edit) serialization
    /// code for the Type: <see cref="SessionAuthProofRequest"/>
    /// </summary>
    public sealed partial class SessionAuthProofRequest_AutoGeneratedTemplateSerializerStrategy
        : BaseAutoGeneratedSerializerStrategy<SessionAuthProofRequest_AutoGeneratedTemplateSerializerStrategy, SessionAuthProofRequest>
    {
        /// <summary>
        /// Auto-generated deserialization/read method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalRead(SessionAuthProofRequest value, Span<byte> buffer, ref int offset)
        {
            //Type: GamePacketPayload Field: 1 Name: OperationCode Type: NetworkOperationCode;
            value.OperationCode = GenericPrimitiveEnumTypeSerializerStrategy<NetworkOperationCode, UInt16>.Instance.Read(buffer, ref offset);
            //Type: SessionAuthProofRequest Field: 1 Name: ClientBuildNumber Type: ClientBuild;
            value.ClientBuildNumber = GenericPrimitiveEnumTypeSerializerStrategy<ClientBuild, UInt16>.Instance.Read(buffer, ref offset);
            //Type: SessionAuthProofRequest Field: 2 Name: unknownOne Type: Int16;
            value.unknownOne = GenericTypePrimitiveSerializerStrategy<Int16>.Instance.Read(buffer, ref offset);
            //Type: SessionAuthProofRequest Field: 3 Name: LoginServiceId Type: Int32;
            value.LoginServiceId = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
            //Type: SessionAuthProofRequest Field: 4 Name: AccountName Type: String;
            value.AccountName = TerminatedStringTypeSerializerStrategy<ASCIIStringTypeSerializerStrategy, ASCIIStringTerminatorTypeSerializerStrategy>.Instance.Read(buffer, ref offset);
            //Type: SessionAuthProofRequest Field: 5 Name: LoginServerType Type: UInt32;
            value.LoginServerType = GenericTypePrimitiveSerializerStrategy<UInt32>.Instance.Read(buffer, ref offset);
            //Type: SessionAuthProofRequest Field: 6 Name: RandomSeedBytes Type: Byte[];
            value.RandomSeedBytes = FixedSizePrimitiveArrayTypeSerializerStrategy<byte, StaticTypedNumeric_Int32_4>.Instance.Read(buffer, ref offset);
            //Type: SessionAuthProofRequest Field: 7 Name: RealmIdentity Type: RealmIdentification;
            value.RealmIdentity = RealmIdentification_AutoGeneratedTemplateSerializerStrategy.Instance.Read(buffer, ref offset);
            //Type: SessionAuthProofRequest Field: 8 Name: DosResponse Type: UInt64;
            value.DosResponse = GenericTypePrimitiveSerializerStrategy<UInt64>.Instance.Read(buffer, ref offset);
            //Type: SessionAuthProofRequest Field: 9 Name: SessionDigest Type: Byte[];
            value.SessionDigest = FixedSizePrimitiveArrayTypeSerializerStrategy<byte, StaticTypedNumeric_Int32_20>.Instance.Read(buffer, ref offset);
            //Type: SessionAuthProofRequest Field: 10 Name: BlizzardAddonVerificationContainer Type: AddonChecksumsContainer;
            value.BlizzardAddonVerificationContainer = AddonChecksumsContainer_AutoGeneratedTemplateSerializerStrategy.Instance.Read(buffer, ref offset);
        }

        /// <summary>
        /// Auto-generated serialization/write method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalWrite(SessionAuthProofRequest value, Span<byte> buffer, ref int offset)
        {
            //Type: GamePacketPayload Field: 1 Name: OperationCode Type: NetworkOperationCode;
            GenericPrimitiveEnumTypeSerializerStrategy<NetworkOperationCode, UInt16>.Instance.Write(value.OperationCode, buffer, ref offset);
            //Type: SessionAuthProofRequest Field: 1 Name: ClientBuildNumber Type: ClientBuild;
            GenericPrimitiveEnumTypeSerializerStrategy<ClientBuild, UInt16>.Instance.Write(value.ClientBuildNumber, buffer, ref offset);
            //Type: SessionAuthProofRequest Field: 2 Name: unknownOne Type: Int16;
            GenericTypePrimitiveSerializerStrategy<Int16>.Instance.Write(value.unknownOne, buffer, ref offset);
            //Type: SessionAuthProofRequest Field: 3 Name: LoginServiceId Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.LoginServiceId, buffer, ref offset);
            //Type: SessionAuthProofRequest Field: 4 Name: AccountName Type: String;
            TerminatedStringTypeSerializerStrategy<ASCIIStringTypeSerializerStrategy, ASCIIStringTerminatorTypeSerializerStrategy>.Instance.Write(value.AccountName, buffer, ref offset);
            //Type: SessionAuthProofRequest Field: 5 Name: LoginServerType Type: UInt32;
            GenericTypePrimitiveSerializerStrategy<UInt32>.Instance.Write(value.LoginServerType, buffer, ref offset);
            //Type: SessionAuthProofRequest Field: 6 Name: RandomSeedBytes Type: Byte[];
            FixedSizePrimitiveArrayTypeSerializerStrategy<byte, StaticTypedNumeric_Int32_4>.Instance.Write(value.RandomSeedBytes, buffer, ref offset);
            //Type: SessionAuthProofRequest Field: 7 Name: RealmIdentity Type: RealmIdentification;
            RealmIdentification_AutoGeneratedTemplateSerializerStrategy.Instance.Write(value.RealmIdentity, buffer, ref offset);
            //Type: SessionAuthProofRequest Field: 8 Name: DosResponse Type: UInt64;
            GenericTypePrimitiveSerializerStrategy<UInt64>.Instance.Write(value.DosResponse, buffer, ref offset);
            //Type: SessionAuthProofRequest Field: 9 Name: SessionDigest Type: Byte[];
            FixedSizePrimitiveArrayTypeSerializerStrategy<byte, StaticTypedNumeric_Int32_20>.Instance.Write(value.SessionDigest, buffer, ref offset);
            //Type: SessionAuthProofRequest Field: 10 Name: BlizzardAddonVerificationContainer Type: AddonChecksumsContainer;
            AddonChecksumsContainer_AutoGeneratedTemplateSerializerStrategy.Instance.Write(value.BlizzardAddonVerificationContainer, buffer, ref offset);
        }
        private sealed class StaticTypedNumeric_Int32_4 : StaticTypedNumeric<Int32> { public sealed override Int32 Value => 4; }
        private sealed class StaticTypedNumeric_Int32_20 : StaticTypedNumeric<Int32> { public sealed override Int32 Value => 20; }
    }
}