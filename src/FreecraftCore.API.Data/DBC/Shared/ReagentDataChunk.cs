using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using Microsoft.EntityFrameworkCore;

namespace FreecraftCore
{
	[Owned]
	[WireDataContract]
	public sealed class ReagentDataChunk<TDataType>
	{
		[WireMember(1)]
		public TDataType One { get; internal set; }

		[WireMember(2)]
		public TDataType Two { get; internal set; }

		[WireMember(3)]
		public TDataType Three { get; internal set; }

		[WireMember(4)]
		public TDataType Four { get; internal set; }

		[WireMember(5)]
		public TDataType Five { get; internal set; }

		[WireMember(6)]
		public TDataType Six { get; internal set; }

		[WireMember(7)]
		public TDataType Seven { get; internal set; }

		[WireMember(8)]
		public TDataType Eight { get; internal set; }

		/// <inheritdoc />
		public ReagentDataChunk(TDataType one, TDataType two, TDataType three, TDataType four, TDataType five, TDataType six, TDataType seven, TDataType eight)
		{
			One = one;
			Two = two;
			Three = three;
			Four = four;
			Five = five;
			Six = six;
			Seven = seven;
			Eight = eight;
		}

		public ReagentDataChunk()
		{
			
		}
	}
}
