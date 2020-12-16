using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	[WireDataContract]
	public sealed class NetworkChatDefaultMessageDetails
	{
		//TODO: Why is this reciever?
		/// <summary>
		/// The reciever guid.
		/// </summary>
		[WireMember(1)]
		public ObjectGuid RecieverGuid { get; internal set; }

		/// <inheritdoc />
		public NetworkChatDefaultMessageDetails([NotNull] ObjectGuid recieverGuid)
		{
			RecieverGuid = recieverGuid ?? throw new ArgumentNullException(nameof(recieverGuid));
		}

		public NetworkChatDefaultMessageDetails()
		{
			
		}
	}
}
