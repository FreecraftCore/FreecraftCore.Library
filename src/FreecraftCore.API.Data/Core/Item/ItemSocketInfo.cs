using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	[WireDataContract]
	public sealed class ItemSocketInfo
	{
		[KnownSize(3)]
		[WireMember(1)]
		public SocketEntry[] Sockets { get; internal set; }

		[WireMember(2)]
		public int SocketBonus { get; internal set; }

		[WireMember(3)]
		public int GemProperties { get; internal set; }

		/// <inheritdoc />
		public ItemSocketInfo(SocketEntry[] sockets, int socketBonus, int gemProperties)
		{
			Sockets = sockets;
			SocketBonus = socketBonus;
			GemProperties = gemProperties;
		}

		public ItemSocketInfo()
		{
			
		}
	}
}
