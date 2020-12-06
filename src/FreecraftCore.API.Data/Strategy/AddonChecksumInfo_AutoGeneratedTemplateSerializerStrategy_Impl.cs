using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using FreecraftCore.Serializer;
using FreecraftCore;
namespace FreecraftCore
{
    [AutoGeneratedWireMessageImplementationAttribute]
    public partial class AddonChecksumInfo : IWireMessage<AddonChecksumInfo>
    {
        public virtual Type SerializableType => typeof(AddonChecksumInfo);
        public virtual AddonChecksumInfo Read(Span<byte> buffer, ref int offset)
        {
            AddonChecksumInfo_AutoGeneratedTemplateSerializerStrategy.Instance.InternalRead(this, buffer, ref offset);
            return this;
        }
        public virtual void Write(AddonChecksumInfo value, Span<byte> buffer, ref int offset)
        {
            AddonChecksumInfo_AutoGeneratedTemplateSerializerStrategy.Instance.InternalWrite(this, buffer, ref offset);
        }
    }
}

namespace FreecraftCore.Serializer
{
    //THIS CODE IS FOR AUTO-GENERATED SERIALIZERS! DO NOT MODIFY UNLESS YOU KNOW WELL!
    /// <summary>
    /// FreecraftCore.Serializer's AUTO-GENERATED (do not edit) serialization
    /// code for the Type: <see cref="AddonChecksumInfo"/>
    /// </summary>
    public sealed partial class AddonChecksumInfo_AutoGeneratedTemplateSerializerStrategy
        : BaseAutoGeneratedSerializerStrategy<AddonChecksumInfo_AutoGeneratedTemplateSerializerStrategy, AddonChecksumInfo>
    {
        /// <summary>
        /// Auto-generated deserialization/read method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalRead(AddonChecksumInfo value, Span<byte> buffer, ref int offset)
        {
            //Type: AddonChecksumInfo Field: 1 Name: AddonName Type: String;
            value.AddonName = TerminatedStringTypeSerializerStrategy<ASCIIStringTypeSerializerStrategy, ASCIIStringTerminatorTypeSerializerStrategy>.Instance.Read(buffer, ref offset);
            //Type: AddonChecksumInfo Field: 2 Name: UsesPublicKeyCRC Type: Boolean;
            value.UsesPublicKeyCRC = GenericTypePrimitiveSerializerStrategy<Boolean>.Instance.Read(buffer, ref offset);
            //Type: AddonChecksumInfo Field: 3 Name: CRCHash Type: UInt32;
            value.CRCHash = GenericTypePrimitiveSerializerStrategy<UInt32>.Instance.Read(buffer, ref offset);
            //Type: AddonChecksumInfo Field: 4 Name: URLFileCRC Type: UInt32;
            value.URLFileCRC = GenericTypePrimitiveSerializerStrategy<UInt32>.Instance.Read(buffer, ref offset);
        }

        /// <summary>
        /// Auto-generated serialization/write method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalWrite(AddonChecksumInfo value, Span<byte> buffer, ref int offset)
        {
            //Type: AddonChecksumInfo Field: 1 Name: AddonName Type: String;
            TerminatedStringTypeSerializerStrategy<ASCIIStringTypeSerializerStrategy, ASCIIStringTerminatorTypeSerializerStrategy>.Instance.Write(value.AddonName, buffer, ref offset);
            //Type: AddonChecksumInfo Field: 2 Name: UsesPublicKeyCRC Type: Boolean;
            GenericTypePrimitiveSerializerStrategy<Boolean>.Instance.Write(value.UsesPublicKeyCRC, buffer, ref offset);
            //Type: AddonChecksumInfo Field: 3 Name: CRCHash Type: UInt32;
            GenericTypePrimitiveSerializerStrategy<UInt32>.Instance.Write(value.CRCHash, buffer, ref offset);
            //Type: AddonChecksumInfo Field: 4 Name: URLFileCRC Type: UInt32;
            GenericTypePrimitiveSerializerStrategy<UInt32>.Instance.Write(value.URLFileCRC, buffer, ref offset);
        }
    }
}