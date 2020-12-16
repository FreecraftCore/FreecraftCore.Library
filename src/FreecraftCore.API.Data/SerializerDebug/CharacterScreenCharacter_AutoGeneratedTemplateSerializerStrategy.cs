using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using FreecraftCore.Serializer;
using FreecraftCore;

namespace FreecraftCore.Serializer
{
    //THIS CODE IS FOR AUTO-GENERATED SERIALIZERS! DO NOT MODIFY UNLESS YOU KNOW WELL!
    /// <summary>
    /// FreecraftCore.Serializer's AUTO-GENERATED (do not edit) serialization
    /// code for the Type: <see cref="CharacterScreenCharacter"/>
    /// </summary>
    public sealed partial class CharacterScreenCharacter_AutoGeneratedTemplateSerializerStrategy
        : BaseAutoGeneratedSerializerStrategy<CharacterScreenCharacter_AutoGeneratedTemplateSerializerStrategy, CharacterScreenCharacter>
    {
        /// <summary>
        /// Auto-generated deserialization/read method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalRead(CharacterScreenCharacter value, Span<byte> buffer, ref int offset)
        {
            //Type: CharacterScreenCharacter Field: 1 Name: Data Type: CharacterScreenData;
            value.Data = CharacterScreenData_AutoGeneratedTemplateSerializerStrategy.Instance.Read(buffer, ref offset);
            //Type: CharacterScreenCharacter Field: 11 Name: SelectionFlags Type: UInt32;
            value.SelectionFlags = GenericTypePrimitiveSerializerStrategy<UInt32>.Instance.Read(buffer, ref offset);
            //Type: CharacterScreenCharacter Field: 12 Name: isFirstLogin Type: Boolean;
            value.isFirstLogin = GenericTypePrimitiveSerializerStrategy<Boolean>.Instance.Read(buffer, ref offset);
            //Type: CharacterScreenCharacter Field: 13 Name: PetInformation Type: CharacterScreenPetInfo;
            value.PetInformation = CharacterScreenPetInfo_AutoGeneratedTemplateSerializerStrategy.Instance.Read(buffer, ref offset);
            //Type: CharacterScreenCharacter Field: 14 Name: _VisualEquipmentItems Type: CharacterScreenItem[];
            value._VisualEquipmentItems = FixedSizeComplexArrayTypeSerializerStrategy<CharacterScreenItem_AutoGeneratedTemplateSerializerStrategy, CharacterScreenItem, StaticTypedNumeric_Int32_19>.Instance.Read(buffer, ref offset);
            //Type: CharacterScreenCharacter Field: 15 Name: _Bags Type: CharacterScreenBag[];
            value._Bags = FixedSizeComplexArrayTypeSerializerStrategy<CharacterScreenBag_AutoGeneratedTemplateSerializerStrategy, CharacterScreenBag, StaticTypedNumeric_Int32_4>.Instance.Read(buffer, ref offset);
        }

        /// <summary>
        /// Auto-generated serialization/write method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalWrite(CharacterScreenCharacter value, Span<byte> buffer, ref int offset)
        {
            //Type: CharacterScreenCharacter Field: 1 Name: Data Type: CharacterScreenData;
            CharacterScreenData_AutoGeneratedTemplateSerializerStrategy.Instance.Write(value.Data, buffer, ref offset);
            //Type: CharacterScreenCharacter Field: 11 Name: SelectionFlags Type: UInt32;
            GenericTypePrimitiveSerializerStrategy<UInt32>.Instance.Write(value.SelectionFlags, buffer, ref offset);
            //Type: CharacterScreenCharacter Field: 12 Name: isFirstLogin Type: Boolean;
            GenericTypePrimitiveSerializerStrategy<Boolean>.Instance.Write(value.isFirstLogin, buffer, ref offset);
            //Type: CharacterScreenCharacter Field: 13 Name: PetInformation Type: CharacterScreenPetInfo;
            CharacterScreenPetInfo_AutoGeneratedTemplateSerializerStrategy.Instance.Write(value.PetInformation, buffer, ref offset);
            //Type: CharacterScreenCharacter Field: 14 Name: _VisualEquipmentItems Type: CharacterScreenItem[];
            FixedSizeComplexArrayTypeSerializerStrategy<CharacterScreenItem_AutoGeneratedTemplateSerializerStrategy, CharacterScreenItem, StaticTypedNumeric_Int32_19>.Instance.Write(value._VisualEquipmentItems, buffer, ref offset);
            //Type: CharacterScreenCharacter Field: 15 Name: _Bags Type: CharacterScreenBag[];
            FixedSizeComplexArrayTypeSerializerStrategy<CharacterScreenBag_AutoGeneratedTemplateSerializerStrategy, CharacterScreenBag, StaticTypedNumeric_Int32_4>.Instance.Write(value._Bags, buffer, ref offset);
        }
        private sealed class StaticTypedNumeric_Int32_19 : StaticTypedNumeric<Int32> { public sealed override Int32 Value => 19; }
        private sealed class StaticTypedNumeric_Int32_4 : StaticTypedNumeric<Int32> { public sealed override Int32 Value => 4; }
    }
}