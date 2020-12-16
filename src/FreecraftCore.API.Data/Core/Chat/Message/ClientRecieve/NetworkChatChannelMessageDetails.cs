using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	[WireDataContract]
	public sealed class NetworkChatChannelMessageDetails
	{
		/// <summary>
		/// Null terminate channel name.
		/// </summary>
		[Encoding(EncodingType.ASCII)]
		[WireMember(1)]
		public string ChannelName { get; internal set; }

		//TODO: Why is this reciever?
		[WireMember(2)]
		public ObjectGuid RecieverGuid { get; internal set; }

		/// <inheritdoc />
		public NetworkChatChannelMessageDetails([NotNull] string channelName, [NotNull] ObjectGuid recieverGuid)
		{
			ChannelName = channelName ?? throw new ArgumentNullException(nameof(channelName));
			RecieverGuid = recieverGuid ?? throw new ArgumentNullException(nameof(recieverGuid));
		}

		public NetworkChatChannelMessageDetails()
		{
			
		}
	}
}
