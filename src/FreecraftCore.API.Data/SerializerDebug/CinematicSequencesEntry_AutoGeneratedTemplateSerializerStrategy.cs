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
    /// code for the Type: <see cref="CinematicSequencesEntry"/>
    /// </summary>
    public sealed partial class CinematicSequencesEntry_AutoGeneratedTemplateSerializerStrategy
        : BaseAutoGeneratedSerializerStrategy<CinematicSequencesEntry_AutoGeneratedTemplateSerializerStrategy, CinematicSequencesEntry>
    {
        /// <summary>
        /// Auto-generated deserialization/read method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalRead(CinematicSequencesEntry value, Span<byte> buffer, ref int offset)
        {
            //Type: CinematicSequencesEntry Field: 1 Name: SequenceId Type: Int32;
            value.SequenceId = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
            //Type: CinematicSequencesEntry Field: 2 Name: SoundId Type: Int32;
            value.SoundId = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
            //Type: CinematicSequencesEntry Field: 3 Name: CameraId Type: Int32;
            value.CameraId = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
            //Type: CinematicSequencesEntry Field: 4 Name: UnusedCameraId Type: GenericStaticallySizedArrayChunkSeven;
            value.UnusedCameraId = GenericStaticallySizedArrayChunkSeven_Int32_AutoGeneratedTemplateSerializerStrategy.Instance.Read(buffer, ref offset);
        }

        /// <summary>
        /// Auto-generated serialization/write method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalWrite(CinematicSequencesEntry value, Span<byte> buffer, ref int offset)
        {
            //Type: CinematicSequencesEntry Field: 1 Name: SequenceId Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.SequenceId, buffer, ref offset);
            //Type: CinematicSequencesEntry Field: 2 Name: SoundId Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.SoundId, buffer, ref offset);
            //Type: CinematicSequencesEntry Field: 3 Name: CameraId Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.CameraId, buffer, ref offset);
            //Type: CinematicSequencesEntry Field: 4 Name: UnusedCameraId Type: GenericStaticallySizedArrayChunkSeven;
            GenericStaticallySizedArrayChunkSeven_Int32_AutoGeneratedTemplateSerializerStrategy.Instance.Write(value.UnusedCameraId, buffer, ref offset);
        }
    }
}