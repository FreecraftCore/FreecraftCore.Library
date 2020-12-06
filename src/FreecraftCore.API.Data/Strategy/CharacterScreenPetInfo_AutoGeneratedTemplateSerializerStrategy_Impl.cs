using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using FreecraftCore.Serializer;
using FreecraftCore;
namespace FreecraftCore
{
    [AutoGeneratedWireMessageImplementationAttribute]
    public partial class CharacterScreenPetInfo : IWireMessage<CharacterScreenPetInfo>
    {
        public virtual Type SerializableType => typeof(CharacterScreenPetInfo);
        public virtual CharacterScreenPetInfo Read(Span<byte> buffer, ref int offset)
        {
            CharacterScreenPetInfo_AutoGeneratedTemplateSerializerStrategy.Instance.InternalRead(this, buffer, ref offset);
            return this;
        }
        public virtual void Write(CharacterScreenPetInfo value, Span<byte> buffer, ref int offset)
        {
            CharacterScreenPetInfo_AutoGeneratedTemplateSerializerStrategy.Instance.InternalWrite(this, buffer, ref offset);
        }
    }
}

namespace FreecraftCore.Serializer
{
    //THIS CODE IS FOR AUTO-GENERATED SERIALIZERS! DO NOT MODIFY UNLESS YOU KNOW WELL!
    /// <summary>
    /// FreecraftCore.Serializer's AUTO-GENERATED (do not edit) serialization
    /// code for the Type: <see cref="CharacterScreenPetInfo"/>
    /// </summary>
    public sealed partial class CharacterScreenPetInfo_AutoGeneratedTemplateSerializerStrategy
        : BaseAutoGeneratedSerializerStrategy<CharacterScreenPetInfo_AutoGeneratedTemplateSerializerStrategy, CharacterScreenPetInfo>
    {
        /// <summary>
        /// Auto-generated deserialization/read method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalRead(CharacterScreenPetInfo value, Span<byte> buffer, ref int offset)
        {
            //Type: CharacterScreenPetInfo Field: 1 Name: PetInformationId Type: UInt32;
            value.PetInformationId = GenericTypePrimitiveSerializerStrategy<UInt32>.Instance.Read(buffer, ref offset);
            //Type: CharacterScreenPetInfo Field: 2 Name: PetLevel Type: UInt32;
            value.PetLevel = GenericTypePrimitiveSerializerStrategy<UInt32>.Instance.Read(buffer, ref offset);
            //Type: CharacterScreenPetInfo Field: 3 Name: PetFamilyId Type: UInt32;
            value.PetFamilyId = GenericTypePrimitiveSerializerStrategy<UInt32>.Instance.Read(buffer, ref offset);
        }

        /// <summary>
        /// Auto-generated serialization/write method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalWrite(CharacterScreenPetInfo value, Span<byte> buffer, ref int offset)
        {
            //Type: CharacterScreenPetInfo Field: 1 Name: PetInformationId Type: UInt32;
            GenericTypePrimitiveSerializerStrategy<UInt32>.Instance.Write(value.PetInformationId, buffer, ref offset);
            //Type: CharacterScreenPetInfo Field: 2 Name: PetLevel Type: UInt32;
            GenericTypePrimitiveSerializerStrategy<UInt32>.Instance.Write(value.PetLevel, buffer, ref offset);
            //Type: CharacterScreenPetInfo Field: 3 Name: PetFamilyId Type: UInt32;
            GenericTypePrimitiveSerializerStrategy<UInt32>.Instance.Write(value.PetFamilyId, buffer, ref offset);
        }
    }
}