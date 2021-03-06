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
    /// code for the Type: <see cref="AuthChallengeData"/>
    /// </summary>
    public sealed partial class AuthChallengeData_AutoGeneratedTemplateSerializerStrategy
        : BaseAutoGeneratedSerializerStrategy<AuthChallengeData_AutoGeneratedTemplateSerializerStrategy, AuthChallengeData>
    {
        /// <summary>
        /// Auto-generated deserialization/read method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalRead(AuthChallengeData value, Span<byte> buffer, ref int offset)
        {
            //Type: AuthChallengeData Field: 1 Name: Protocol Type: ProtocolVersion;
            value.Protocol = GenericPrimitiveEnumTypeSerializerStrategy<ProtocolVersion, Byte>.Instance.Read(buffer, ref offset);
            //Type: AuthChallengeData Field: 2 Name: size Type: UInt16;
            value.size = GenericTypePrimitiveSerializerStrategy<UInt16>.Instance.Read(buffer, ref offset);
            //Type: AuthChallengeData Field: 3 Name: Game Type: GameType;
            value.Game = InternalEnumExtensions.Parse<GameType>(FixedSizeStringTypeSerializerStrategy<ASCIIStringTypeSerializerStrategy, StaticTypedNumeric_Int32_4, ASCIIStringTerminatorTypeSerializerStrategy>.Instance.Read(buffer, ref offset), true);
            //Type: AuthChallengeData Field: 4 Name: ExpansionVersionId Type: Byte;
            value.ExpansionVersionId = BytePrimitiveSerializerStrategy.Instance.Read(buffer, ref offset);
            //Type: AuthChallengeData Field: 5 Name: MajorPatchVersion Type: Byte;
            value.MajorPatchVersion = BytePrimitiveSerializerStrategy.Instance.Read(buffer, ref offset);
            //Type: AuthChallengeData Field: 6 Name: MinorPatchVersion Type: Byte;
            value.MinorPatchVersion = BytePrimitiveSerializerStrategy.Instance.Read(buffer, ref offset);
            //Type: AuthChallengeData Field: 7 Name: Build Type: ClientBuild;
            value.Build = GenericPrimitiveEnumTypeSerializerStrategy<ClientBuild, UInt16>.Instance.Read(buffer, ref offset);
            //Type: AuthChallengeData Field: 8 Name: Platform Type: PlatformType;
            value.Platform = InternalEnumExtensions.Parse<PlatformType>(FixedSizeStringTypeSerializerStrategy<ReversedASCIIStringTypeSerializerStrategy, StaticTypedNumeric_Int32_4, ASCIIStringTerminatorTypeSerializerStrategy>.Instance.Read(buffer, ref offset), true);
            //Type: AuthChallengeData Field: 9 Name: OperatingSystem Type: OperatingSystemType;
            value.OperatingSystem = InternalEnumExtensions.Parse<OperatingSystemType>(FixedSizeStringTypeSerializerStrategy<ReversedASCIIStringTypeSerializerStrategy, StaticTypedNumeric_Int32_4, ASCIIStringTerminatorTypeSerializerStrategy>.Instance.Read(buffer, ref offset), true);
            //Type: AuthChallengeData Field: 10 Name: Locale Type: LocaleType;
            value.Locale = InternalEnumExtensions.Parse<LocaleType>(FixedSizeStringTypeSerializerStrategy<ReversedASCIIStringTypeSerializerStrategy, StaticTypedNumeric_Int32_4>.Instance.Read(buffer, ref offset), true);
            //Type: AuthChallengeData Field: 11 Name: TimeZoneBias Type: UInt32;
            value.TimeZoneBias = GenericTypePrimitiveSerializerStrategy<UInt32>.Instance.Read(buffer, ref offset);
            //Type: AuthChallengeData Field: 12 Name: ipAddressInBytes Type: Byte[];
            value.ipAddressInBytes = FixedSizePrimitiveArrayTypeSerializerStrategy<byte, StaticTypedNumeric_Int32_4>.Instance.Read(buffer, ref offset);
            //Type: AuthChallengeData Field: 13 Name: Identity Type: String;
            value.Identity = DontTerminateLengthPrefixedStringTypeSerializerStrategy<ASCIIStringTypeSerializerStrategy, Byte>.Instance.Read(buffer, ref offset);
        }

        /// <summary>
        /// Auto-generated serialization/write method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalWrite(AuthChallengeData value, Span<byte> buffer, ref int offset)
        {
            //Type: AuthChallengeData Field: 1 Name: Protocol Type: ProtocolVersion;
            GenericPrimitiveEnumTypeSerializerStrategy<ProtocolVersion, Byte>.Instance.Write(value.Protocol, buffer, ref offset);
            //Type: AuthChallengeData Field: 2 Name: size Type: UInt16;
            GenericTypePrimitiveSerializerStrategy<UInt16>.Instance.Write(value.size, buffer, ref offset);
            //Type: AuthChallengeData Field: 3 Name: Game Type: GameType;
            FixedSizeStringTypeSerializerStrategy<ASCIIStringTypeSerializerStrategy, StaticTypedNumeric_Int32_4, ASCIIStringTerminatorTypeSerializerStrategy>.Instance.Write(value.Game, buffer, ref offset);
            //Type: AuthChallengeData Field: 4 Name: ExpansionVersionId Type: Byte;
            BytePrimitiveSerializerStrategy.Instance.Write(value.ExpansionVersionId, buffer, ref offset);
            //Type: AuthChallengeData Field: 5 Name: MajorPatchVersion Type: Byte;
            BytePrimitiveSerializerStrategy.Instance.Write(value.MajorPatchVersion, buffer, ref offset);
            //Type: AuthChallengeData Field: 6 Name: MinorPatchVersion Type: Byte;
            BytePrimitiveSerializerStrategy.Instance.Write(value.MinorPatchVersion, buffer, ref offset);
            //Type: AuthChallengeData Field: 7 Name: Build Type: ClientBuild;
            GenericPrimitiveEnumTypeSerializerStrategy<ClientBuild, UInt16>.Instance.Write(value.Build, buffer, ref offset);
            //Type: AuthChallengeData Field: 8 Name: Platform Type: PlatformType;
            FixedSizeStringTypeSerializerStrategy<ReversedASCIIStringTypeSerializerStrategy, StaticTypedNumeric_Int32_4, ASCIIStringTerminatorTypeSerializerStrategy>.Instance.Write(value.Platform, buffer, ref offset);
            //Type: AuthChallengeData Field: 9 Name: OperatingSystem Type: OperatingSystemType;
            FixedSizeStringTypeSerializerStrategy<ReversedASCIIStringTypeSerializerStrategy, StaticTypedNumeric_Int32_4, ASCIIStringTerminatorTypeSerializerStrategy>.Instance.Write(value.OperatingSystem, buffer, ref offset);
            //Type: AuthChallengeData Field: 10 Name: Locale Type: LocaleType;
            FixedSizeStringTypeSerializerStrategy<ReversedASCIIStringTypeSerializerStrategy, StaticTypedNumeric_Int32_4>.Instance.Write(value.Locale, buffer, ref offset);
            //Type: AuthChallengeData Field: 11 Name: TimeZoneBias Type: UInt32;
            GenericTypePrimitiveSerializerStrategy<UInt32>.Instance.Write(value.TimeZoneBias, buffer, ref offset);
            //Type: AuthChallengeData Field: 12 Name: ipAddressInBytes Type: Byte[];
            FixedSizePrimitiveArrayTypeSerializerStrategy<byte, StaticTypedNumeric_Int32_4>.Instance.Write(value.ipAddressInBytes, buffer, ref offset);
            //Type: AuthChallengeData Field: 13 Name: Identity Type: String;
            DontTerminateLengthPrefixedStringTypeSerializerStrategy<ASCIIStringTypeSerializerStrategy, Byte>.Instance.Write(value.Identity, buffer, ref offset);
        }
        private sealed class StaticTypedNumeric_Int32_4 : StaticTypedNumeric<Int32> { public sealed override Int32 Value => 4; }
    }
}