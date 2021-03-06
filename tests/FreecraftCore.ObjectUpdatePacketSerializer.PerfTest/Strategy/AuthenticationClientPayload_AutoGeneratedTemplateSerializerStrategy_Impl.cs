using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using FreecraftCore.Serializer;
using FreecraftCore;
namespace FreecraftCore
{
    [AutoGeneratedWireMessageImplementationAttribute]
    public partial class AuthenticationClientPayload : IWireMessage<AuthenticationClientPayload>
    {
        public virtual Type SerializableType => typeof(AuthenticationClientPayload);
        public virtual AuthenticationClientPayload Read(Span<byte> buffer, ref int offset)
        {
            AuthenticationClientPayload_AutoGeneratedTemplateSerializerStrategy.Instance.InternalRead(this, buffer, ref offset);
            return this;
        }
        public virtual void Write(AuthenticationClientPayload value, Span<byte> buffer, ref int offset)
        {
            AuthenticationClientPayload_AutoGeneratedTemplateSerializerStrategy.Instance.InternalWrite(this, buffer, ref offset);
        }
    }
}

namespace FreecraftCore.Serializer
{
    //THIS CODE IS FOR AUTO-GENERATED SERIALIZERS! DO NOT MODIFY UNLESS YOU KNOW WELL!
    /// <summary>
    /// FreecraftCore.Serializer's AUTO-GENERATED (do not edit) serialization
    /// code for the Type: <see cref="AuthenticationClientPayload"/>
    /// </summary>
    public sealed partial class AuthenticationClientPayload_AutoGeneratedTemplateSerializerStrategy
        : BasePolymorphicAutoGeneratedSerializerStrategy<AuthenticationClientPayload_AutoGeneratedTemplateSerializerStrategy, AuthenticationClientPayload, Byte>
    {
        protected override AuthenticationClientPayload CreateType(int key)
        {
            switch (key)
            {
                default:
                    return new DefaultAuthenticationClientPayload();
            }
        }
    }
}