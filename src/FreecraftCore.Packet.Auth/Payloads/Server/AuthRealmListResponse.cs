using FreecraftCore.Serializer;
using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace FreecraftCore
{
	/// <summary>
	/// Response payload contains the realm list.
	/// Response to the request <see cref="AuthRealmListRequest"/>.
	/// </summary>
	[WireDataContract]
	[AuthenticationServerPayload(AuthOperationCode.REALM_LIST)] //TODO: Figure out how to support linking with the limited information.
	public partial class AuthRealmListResponse : AuthenticationServerPayload
	{
		//TODO: Implement
		public override bool isValid { get; } = true;

		/// <summary>
		/// The size of the payload.
		/// </summary>
		[WireMember(1)]
		public ushort PayloadSize { get; internal set; }

		//Unknown field. Trinitycore always sends 0.
		//I think EmberEmu said it's expected as 0 in the client? Can't recall
		[WireMember(2)]
		internal uint unknownOne { get; set; }

		/// <summary>
		/// Realm information.
		/// </summary>
		[SendSize(PrimitiveSizeType.UInt16)] //in 2.x and 3.x this is ushort but in 1.12.1 it's a uint32
		[WireMember(3)]
		internal RealmInfo[] realms { get; set; }

		/// <summary>
		/// Collection of realm's.
		/// </summary>
		public IEnumerable<RealmInfo> Realms => realms;

		//2.x and 3.x clients send byte 16 and 0
		//1.12.1 clients send 0 and 2.
		//EmberEmu has no information on what it is.
		[WireMember(4)]
		internal short unknownTwo { get; set; }

		/// <summary>
		/// Creates a new realm list response. Which MUST include the actual realm list payload size.
		/// This isn't possible for the serializer/DTO to compute itself. Since it would need to know its own
		/// size which is not possible.
		/// </summary>
		/// <param name="payloadSize">The size of the payload.</param>
		/// <param name="realms">The realms</param>
		public AuthRealmListResponse(ushort payloadSize, [NotNull] RealmInfo[] realms)
			: this()
		{
			this.realms = realms ?? throw new ArgumentNullException(nameof(realms));
			PayloadSize = payloadSize;
			this.unknownOne = 0;
			unknownTwo = 16;
		}

		public AuthRealmListResponse()
			: base(AuthOperationCode.REALM_LIST)
		{

		}
	}
}
