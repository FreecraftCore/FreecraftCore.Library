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
    /// code for the Type: <see cref="CharacterScreenData"/>
    /// </summary>
    public sealed partial class CharacterScreenData_AutoGeneratedTemplateSerializerStrategy
        : BaseAutoGeneratedSerializerStrategy<CharacterScreenData_AutoGeneratedTemplateSerializerStrategy, CharacterScreenData>
    {
        /// <summary>
        /// Auto-generated deserialization/read method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalRead(CharacterScreenData value, Span<byte> buffer, ref int offset)
        {
            //Type: CharacterScreenData Field: 1 Name: CharacterGuid Type: ObjectGuid;
            value.CharacterGuid = ObjectGuid_AutoGeneratedTemplateSerializerStrategy.Instance.Read(buffer, ref offset);
            //Type: CharacterScreenData Field: 2 Name: CharacterName Type: String;
            value.CharacterName = TerminatedStringTypeSerializerStrategy<ASCIIStringTypeSerializerStrategy, ASCIIStringTerminatorTypeSerializerStrategy>.Instance.Read(buffer, ref offset);
            //Type: CharacterScreenData Field: 3 Name: Race Type: CharacterRace;
            value.Race = GenericPrimitiveEnumTypeSerializerStrategy<CharacterRace, Byte>.Instance.Read(buffer, ref offset);
            //Type: CharacterScreenData Field: 4 Name: Class Type: CharacterClass;
            value.Class = GenericPrimitiveEnumTypeSerializerStrategy<CharacterClass, Byte>.Instance.Read(buffer, ref offset);
            //Type: CharacterScreenData Field: 5 Name: Gender Type: CharacterGender;
            value.Gender = GenericPrimitiveEnumTypeSerializerStrategy<CharacterGender, Byte>.Instance.Read(buffer, ref offset);
            //Type: CharacterScreenData Field: 6 Name: UnknownBytesOne Type: Byte[];
            value.UnknownBytesOne = FixedSizePrimitiveArrayTypeSerializerStrategy<byte, StaticTypedNumeric_Int32_5>.Instance.Read(buffer, ref offset);
            //Type: CharacterScreenData Field: 7 Name: CharacterLevel Type: Byte;
            value.CharacterLevel = BytePrimitiveSerializerStrategy.Instance.Read(buffer, ref offset);
            //Type: CharacterScreenData Field: 8 Name: Location Type: TempLocationStructure;
            value.Location = TempLocationStructure_AutoGeneratedTemplateSerializerStrategy.Instance.Read(buffer, ref offset);
            //Type: CharacterScreenData Field: 9 Name: GuildId Type: UInt32;
            value.GuildId = GenericTypePrimitiveSerializerStrategy<UInt32>.Instance.Read(buffer, ref offset);
            //Type: CharacterScreenData Field: 10 Name: CharacterFlags Type: UInt32;
            value.CharacterFlags = GenericTypePrimitiveSerializerStrategy<UInt32>.Instance.Read(buffer, ref offset);
        }

        /// <summary>
        /// Auto-generated serialization/write method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalWrite(CharacterScreenData value, Span<byte> buffer, ref int offset)
        {
            //Type: CharacterScreenData Field: 1 Name: CharacterGuid Type: ObjectGuid;
            ObjectGuid_AutoGeneratedTemplateSerializerStrategy.Instance.Write(value.CharacterGuid, buffer, ref offset);
            //Type: CharacterScreenData Field: 2 Name: CharacterName Type: String;
            TerminatedStringTypeSerializerStrategy<ASCIIStringTypeSerializerStrategy, ASCIIStringTerminatorTypeSerializerStrategy>.Instance.Write(value.CharacterName, buffer, ref offset);
            //Type: CharacterScreenData Field: 3 Name: Race Type: CharacterRace;
            GenericPrimitiveEnumTypeSerializerStrategy<CharacterRace, Byte>.Instance.Write(value.Race, buffer, ref offset);
            //Type: CharacterScreenData Field: 4 Name: Class Type: CharacterClass;
            GenericPrimitiveEnumTypeSerializerStrategy<CharacterClass, Byte>.Instance.Write(value.Class, buffer, ref offset);
            //Type: CharacterScreenData Field: 5 Name: Gender Type: CharacterGender;
            GenericPrimitiveEnumTypeSerializerStrategy<CharacterGender, Byte>.Instance.Write(value.Gender, buffer, ref offset);
            //Type: CharacterScreenData Field: 6 Name: UnknownBytesOne Type: Byte[];
            FixedSizePrimitiveArrayTypeSerializerStrategy<byte, StaticTypedNumeric_Int32_5>.Instance.Write(value.UnknownBytesOne, buffer, ref offset);
            //Type: CharacterScreenData Field: 7 Name: CharacterLevel Type: Byte;
            BytePrimitiveSerializerStrategy.Instance.Write(value.CharacterLevel, buffer, ref offset);
            //Type: CharacterScreenData Field: 8 Name: Location Type: TempLocationStructure;
            TempLocationStructure_AutoGeneratedTemplateSerializerStrategy.Instance.Write(value.Location, buffer, ref offset);
            //Type: CharacterScreenData Field: 9 Name: GuildId Type: UInt32;
            GenericTypePrimitiveSerializerStrategy<UInt32>.Instance.Write(value.GuildId, buffer, ref offset);
            //Type: CharacterScreenData Field: 10 Name: CharacterFlags Type: UInt32;
            GenericTypePrimitiveSerializerStrategy<UInt32>.Instance.Write(value.CharacterFlags, buffer, ref offset);
        }
        private sealed class StaticTypedNumeric_Int32_5 : StaticTypedNumeric<Int32> { public sealed override Int32 Value => 5; }
    }
}