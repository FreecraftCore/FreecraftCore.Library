﻿using FreecraftCore;
using FreecraftCore.Serializer;
using System;
using System.CodeDom;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using FreecraftCore;


namespace FreecraftCore
{
	/// <summary>
	/// Authentication payload base type that is used to wire children for serialization purposes.
	/// This version of the Authentication Payload is for payloads sent by the server.
	/// </summary>
	[ProtocolGrouping(ProtocolCode.Authentication)] //we can put this on the base type because all auth packets have the same protocol.
	[DefaultChild(typeof(DefaultAuthenticationServerPayload))]
	[WireDataContract(WireDataContractAttribute.KeyType.Byte, true)] //expect runtime linking
	public abstract class AuthenticationServerPayload : IAuthenticationPayload
	{
		/// <inheritdoc />
		public abstract bool isValid { get; }
	}
}
