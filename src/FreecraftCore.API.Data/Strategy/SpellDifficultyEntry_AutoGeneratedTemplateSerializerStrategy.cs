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
    /// code for the Type: <see cref="SpellDifficultyEntry"/>
    /// </summary>
    public sealed partial class SpellDifficultyEntry_AutoGeneratedTemplateSerializerStrategy
        : BaseAutoGeneratedSerializerStrategy<SpellDifficultyEntry_AutoGeneratedTemplateSerializerStrategy, SpellDifficultyEntry>
    {
        /// <summary>
        /// Auto-generated deserialization/read method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalRead(SpellDifficultyEntry value, Span<byte> buffer, ref int offset)
        {
            //Type: SpellDifficultyEntry Field: 1 Name: SpellDifficultyId Type: Int32;
            value.SpellDifficultyId = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
            //Type: SpellDifficultyEntry Field: 2 Name: Normal10manSpellId Type: Int32;
            value.Normal10manSpellId = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
            //Type: SpellDifficultyEntry Field: 3 Name: Normal25manSpellId Type: Int32;
            value.Normal25manSpellId = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
            //Type: SpellDifficultyEntry Field: 4 Name: Heroic10manSpellId Type: Int32;
            value.Heroic10manSpellId = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
            //Type: SpellDifficultyEntry Field: 5 Name: Heroic25manSpellId Type: Int32;
            value.Heroic25manSpellId = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
        }

        /// <summary>
        /// Auto-generated serialization/write method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalWrite(SpellDifficultyEntry value, Span<byte> buffer, ref int offset)
        {
            //Type: SpellDifficultyEntry Field: 1 Name: SpellDifficultyId Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.SpellDifficultyId, buffer, ref offset);
            //Type: SpellDifficultyEntry Field: 2 Name: Normal10manSpellId Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.Normal10manSpellId, buffer, ref offset);
            //Type: SpellDifficultyEntry Field: 3 Name: Normal25manSpellId Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.Normal25manSpellId, buffer, ref offset);
            //Type: SpellDifficultyEntry Field: 4 Name: Heroic10manSpellId Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.Heroic10manSpellId, buffer, ref offset);
            //Type: SpellDifficultyEntry Field: 5 Name: Heroic25manSpellId Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.Heroic25manSpellId, buffer, ref offset);
        }
    }
}