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
    /// code for the Type: <see cref="CreatureSoundDataEntry"/>
    /// </summary>
    public sealed partial class CreatureSoundDataEntry_AutoGeneratedTemplateSerializerStrategy
        : BaseAutoGeneratedSerializerStrategy<CreatureSoundDataEntry_AutoGeneratedTemplateSerializerStrategy, CreatureSoundDataEntry>
    {
        /// <summary>
        /// Auto-generated deserialization/read method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalRead(CreatureSoundDataEntry value, Span<byte> buffer, ref int offset)
        {
            //Type: CreatureSoundDataEntry Field: 1 Name: CreatureSoundDataId Type: Int32;
            value.CreatureSoundDataId = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 2 Name: SoundExertionId Type: Int32;
            value.SoundExertionId = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 3 Name: SoundExertionCriticalId Type: Int32;
            value.SoundExertionCriticalId = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 4 Name: SoundInjuryId Type: Int32;
            value.SoundInjuryId = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 5 Name: SoundInjuryCriticalId Type: Int32;
            value.SoundInjuryCriticalId = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 6 Name: SoundInjuryCrushingBlowId Type: Int32;
            value.SoundInjuryCrushingBlowId = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 7 Name: SoundDeathId Type: Int32;
            value.SoundDeathId = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 8 Name: SoundStunId Type: Int32;
            value.SoundStunId = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 9 Name: SoundStandId Type: Int32;
            value.SoundStandId = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 10 Name: SoundFootstepId Type: Int32;
            value.SoundFootstepId = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 11 Name: SoundAggroId Type: Int32;
            value.SoundAggroId = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 12 Name: SoundWingFlapId Type: Int32;
            value.SoundWingFlapId = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 13 Name: SoundWingGlideId Type: Int32;
            value.SoundWingGlideId = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 14 Name: SoundAlertId Type: Int32;
            value.SoundAlertId = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 15 Name: SoundFidgetId Type: GenericStaticallySizedArrayChunkFive;
            value.SoundFidgetId = GenericStaticallySizedArrayChunkFive_Int32_AutoGeneratedTemplateSerializerStrategy.Instance.Read(buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 16 Name: CustomAttackId Type: GenericStaticallySizedArrayChunkFour;
            value.CustomAttackId = GenericStaticallySizedArrayChunkFour_Int32_AutoGeneratedTemplateSerializerStrategy.Instance.Read(buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 17 Name: NPCSoundId Type: Int32;
            value.NPCSoundId = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 18 Name: LoopSoundId Type: Int32;
            value.LoopSoundId = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 19 Name: CreatureImpactType Type: Int32;
            value.CreatureImpactType = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 20 Name: SoundJumpStartId Type: Int32;
            value.SoundJumpStartId = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 21 Name: SoundJumpEndId Type: Int32;
            value.SoundJumpEndId = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 22 Name: SoundPetAttackId Type: Int32;
            value.SoundPetAttackId = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 23 Name: SoundPetOrderId Type: Int32;
            value.SoundPetOrderId = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 24 Name: SoundPetDismissId Type: Int32;
            value.SoundPetDismissId = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 25 Name: FidgetDelaySecondsMinimum Type: Single;
            value.FidgetDelaySecondsMinimum = GenericTypePrimitiveSerializerStrategy<Single>.Instance.Read(buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 26 Name: FidgetDelaySecondsMaximum Type: Single;
            value.FidgetDelaySecondsMaximum = GenericTypePrimitiveSerializerStrategy<Single>.Instance.Read(buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 27 Name: BirthSoundId Type: Int32;
            value.BirthSoundId = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 28 Name: SpellCastDirectedSoundId Type: Int32;
            value.SpellCastDirectedSoundId = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 29 Name: SubmergeSoundId Type: Int32;
            value.SubmergeSoundId = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 30 Name: SubmergedSoundId Type: Int32;
            value.SubmergedSoundId = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 31 Name: CreatureSoundDataIdPet Type: Int32;
            value.CreatureSoundDataIdPet = GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Read(buffer, ref offset);
        }

        /// <summary>
        /// Auto-generated serialization/write method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalWrite(CreatureSoundDataEntry value, Span<byte> buffer, ref int offset)
        {
            //Type: CreatureSoundDataEntry Field: 1 Name: CreatureSoundDataId Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.CreatureSoundDataId, buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 2 Name: SoundExertionId Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.SoundExertionId, buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 3 Name: SoundExertionCriticalId Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.SoundExertionCriticalId, buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 4 Name: SoundInjuryId Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.SoundInjuryId, buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 5 Name: SoundInjuryCriticalId Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.SoundInjuryCriticalId, buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 6 Name: SoundInjuryCrushingBlowId Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.SoundInjuryCrushingBlowId, buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 7 Name: SoundDeathId Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.SoundDeathId, buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 8 Name: SoundStunId Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.SoundStunId, buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 9 Name: SoundStandId Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.SoundStandId, buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 10 Name: SoundFootstepId Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.SoundFootstepId, buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 11 Name: SoundAggroId Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.SoundAggroId, buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 12 Name: SoundWingFlapId Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.SoundWingFlapId, buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 13 Name: SoundWingGlideId Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.SoundWingGlideId, buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 14 Name: SoundAlertId Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.SoundAlertId, buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 15 Name: SoundFidgetId Type: GenericStaticallySizedArrayChunkFive;
            GenericStaticallySizedArrayChunkFive_Int32_AutoGeneratedTemplateSerializerStrategy.Instance.Write(value.SoundFidgetId, buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 16 Name: CustomAttackId Type: GenericStaticallySizedArrayChunkFour;
            GenericStaticallySizedArrayChunkFour_Int32_AutoGeneratedTemplateSerializerStrategy.Instance.Write(value.CustomAttackId, buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 17 Name: NPCSoundId Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.NPCSoundId, buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 18 Name: LoopSoundId Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.LoopSoundId, buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 19 Name: CreatureImpactType Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.CreatureImpactType, buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 20 Name: SoundJumpStartId Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.SoundJumpStartId, buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 21 Name: SoundJumpEndId Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.SoundJumpEndId, buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 22 Name: SoundPetAttackId Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.SoundPetAttackId, buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 23 Name: SoundPetOrderId Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.SoundPetOrderId, buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 24 Name: SoundPetDismissId Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.SoundPetDismissId, buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 25 Name: FidgetDelaySecondsMinimum Type: Single;
            GenericTypePrimitiveSerializerStrategy<Single>.Instance.Write(value.FidgetDelaySecondsMinimum, buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 26 Name: FidgetDelaySecondsMaximum Type: Single;
            GenericTypePrimitiveSerializerStrategy<Single>.Instance.Write(value.FidgetDelaySecondsMaximum, buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 27 Name: BirthSoundId Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.BirthSoundId, buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 28 Name: SpellCastDirectedSoundId Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.SpellCastDirectedSoundId, buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 29 Name: SubmergeSoundId Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.SubmergeSoundId, buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 30 Name: SubmergedSoundId Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.SubmergedSoundId, buffer, ref offset);
            //Type: CreatureSoundDataEntry Field: 31 Name: CreatureSoundDataIdPet Type: Int32;
            GenericTypePrimitiveSerializerStrategy<Int32>.Instance.Write(value.CreatureSoundDataIdPet, buffer, ref offset);
        }
    }
}