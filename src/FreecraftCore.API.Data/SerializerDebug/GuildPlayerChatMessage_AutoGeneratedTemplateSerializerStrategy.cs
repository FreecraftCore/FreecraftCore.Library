using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using FreecraftCore.Serializer;
using FreecraftCore;
namespace FreecraftCore
{
    [AutoGeneratedWireMessageImplementationAttribute]
    public partial class GuildPlayerChatMessage
    {
        public override Type SerializableType => typeof(GuildPlayerChatMessage);
        public override PlayerChatMessage Read(Span<byte> buffer, ref int offset)
        {
            GuildPlayerChatMessage_AutoGeneratedTemplateSerializerStrategy.Instance.InternalRead(this, buffer, ref offset);
            return this;
        }
        public override void Write(PlayerChatMessage value, Span<byte> buffer, ref int offset)
        {
            GuildPlayerChatMessage_AutoGeneratedTemplateSerializerStrategy.Instance.InternalWrite(this, buffer, ref offset);
        }
    }
}

namespace FreecraftCore.Serializer
{
    //THIS CODE IS FOR AUTO-GENERATED SERIALIZERS! DO NOT MODIFY UNLESS YOU KNOW WELL!
    /// <summary>
    /// FreecraftCore.Serializer's AUTO-GENERATED (do not edit) serialization
    /// code for the Type: <see cref="GuildPlayerChatMessage"/>
    /// </summary>
    public sealed partial class GuildPlayerChatMessage_AutoGeneratedTemplateSerializerStrategy
        : BaseAutoGeneratedSerializerStrategy<GuildPlayerChatMessage_AutoGeneratedTemplateSerializerStrategy, GuildPlayerChatMessage>
    {
        /// <summary>
        /// Auto-generated deserialization/read method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalRead(GuildPlayerChatMessage value, Span<byte> buffer, ref int offset)
        {
            //Type: PlayerChatMessage Field: 1 Name: MessageType Type: ChatMessageType;
            value.MessageType = GenericPrimitiveEnumTypeSerializerStrategy<ChatMessageType, Int32>.Instance.Read(buffer, ref offset);
            //Type: PlayerChatMessage Field: 2 Name: Language Type: ChatLanguage;
            value.Language = GenericPrimitiveEnumTypeSerializerStrategy<ChatLanguage, UInt32>.Instance.Read(buffer, ref offset);
            //Type: GuildPlayerChatMessage Field: 1 Name: Message Type: String;
            value.Message = TerminatedStringTypeSerializerStrategy<ASCIIStringTypeSerializerStrategy, ASCIIStringTerminatorTypeSerializerStrategy>.Instance.Read(buffer, ref offset);
        }

        /// <summary>
        /// Auto-generated serialization/write method.
        /// Partial method implemented from shared partial definition.
        /// </summary>
        /// <param name="value">See external doc.</param>
        /// <param name="buffer">See external doc.</param>
        /// <param name="offset">See external doc.</param>
        public override void InternalWrite(GuildPlayerChatMessage value, Span<byte> buffer, ref int offset)
        {
            //Type: PlayerChatMessage Field: 1 Name: MessageType Type: ChatMessageType;
            GenericPrimitiveEnumTypeSerializerStrategy<ChatMessageType, Int32>.Instance.Write(value.MessageType, buffer, ref offset);
            //Type: PlayerChatMessage Field: 2 Name: Language Type: ChatLanguage;
            GenericPrimitiveEnumTypeSerializerStrategy<ChatLanguage, UInt32>.Instance.Write(value.Language, buffer, ref offset);
            //Type: GuildPlayerChatMessage Field: 1 Name: Message Type: String;
            TerminatedStringTypeSerializerStrategy<ASCIIStringTypeSerializerStrategy, ASCIIStringTerminatorTypeSerializerStrategy>.Instance.Write(value.Message, buffer, ref offset);
        }
    }
}