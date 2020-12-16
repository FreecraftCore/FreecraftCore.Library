using System;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	/// <summary>
	/// Default payload for unknown authentication payloads.
	/// </summary>
	[WireDataContract]
	public sealed partial class DefaultAuthenticationClientPayload : AuthenticationClientPayload
	{
		/// <inheritdoc />
		public override bool isValid { get; } = false;

		/// <summary>
		/// Byte data (excluding op code) of the unknown packet.
		/// </summary>
		[WireMember(1)]
		public byte[] Data { get; internal set; }

		/// <inheritdoc />
		public DefaultAuthenticationClientPayload([NotNull] byte[] data)
			: this()
		{
			if(data == null) throw new ArgumentNullException(nameof(data));

			Data = data;
		}

		//Serializer ctor
		public DefaultAuthenticationClientPayload()
			: base(AuthOperationCode.END)
		{
			
		}
	}
}
