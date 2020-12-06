using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using FreecraftCore.Serializer;
using FreecraftCore;
namespace System
{
    [AutoGeneratedWireMessageImplementationAttribute]
    public partial class CharacterRaceMask
    {
        public override Type SerializableType => typeof(CharacterRaceMask);
        public override ValueType Read(Span<byte> buffer, ref int offset)
        {
            CharacterRaceMask_AutoGeneratedTemplateSerializerStrategy.Instance.InternalRead(this, buffer, ref offset);
            return this;
        }
        public override void Write(ValueType value, Span<byte> buffer, ref int offset)
        {
            CharacterRaceMask_AutoGeneratedTemplateSerializerStrategy.Instance.InternalWrite(this, buffer, ref offset);
        }
    }
}

namespace FreecraftCore.Serializer
{
    //THIS CODE IS FOR AUTO-GENERATED SERIALIZERS! DO NOT MODIFY UNLESS YOU KNOW WELL!
    /// <summary>
    /// FreecraftCore.Serializer's AUTO-GENERATED (do not edit) serialization
    /// code for the Type: <see cref="CharacterRaceMask"/>
    /// </summary>
    public sealed partial class CharacterRaceMask_AutoGeneratedTemplateSerializerStrategy
        : BaseAutoGeneratedSerializerStrategy<CharacterRaceMask_AutoGeneratedTemplateSerializerStrategy, CharacterRaceMask>
    {
        /// <summary>
        /// Auto-generated deserialization/read method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalRead(CharacterRaceMask value, Span<byte> buffer, ref int offset)
        {
        }

        /// <summary>
        /// Auto-generated serialization/write method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalWrite(CharacterRaceMask value, Span<byte> buffer, ref int offset)
        {

        }
    }
}