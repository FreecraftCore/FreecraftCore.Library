using System;
using System.Collections.Generic;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	[WireDataContract]
	public sealed class RealmListContainer
	{
		[SendSize(PrimitiveSizeType.UInt16)] //in 2.x and 3.x this is ushort but in 1.12.1 it's a uint32
		[WireMember(1)]
		public RealmInfo[] _Realms { get; internal set; }

		/// <summary>
		/// Collection of realm's.
		/// </summary>
		public IEnumerable<RealmInfo> Realms => _Realms;

		/// <inheritdoc />
		public RealmListContainer([NotNull] RealmInfo[] realms)
		{
			if(realms == null) throw new ArgumentNullException(nameof(realms));

			_Realms = realms;
		}

		//Serializer ctor
		public RealmListContainer()
		{
			
		}
	}
}
