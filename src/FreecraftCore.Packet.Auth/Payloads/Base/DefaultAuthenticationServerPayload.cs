using System;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	/// <summary>
	/// Default payload for unknown authentication payloads.
	/// </summary>
	[WireDataContract]
	public sealed partial class DefaultAuthenticationServerPayload : AuthenticationServerPayload
	{
		/// <inheritdoc />
		public override bool isValid { get; } = false;

		[WireMember(1)]
		public byte[] Data { get; internal set; }

		/// <inheritdoc />
		public DefaultAuthenticationServerPayload([NotNull] byte[] data)
			: this()
		{
			if(data == null) throw new ArgumentNullException(
				nameof(data));
			Data = data;
		}

		//Serializer ctor
		public DefaultAuthenticationServerPayload()
			: base(AuthOperationCode.END)
		{
			
		}
	}
}
