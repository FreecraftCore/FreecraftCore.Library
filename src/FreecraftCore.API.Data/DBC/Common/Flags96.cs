using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using Microsoft.EntityFrameworkCore;

namespace FreecraftCore
{
	/// <summary>
	/// Based on Trinitycore's Flags96.
	/// It is a 3 int sizes flags field.
	/// </summary>
	[Owned]
	[WireDataContract]
	public sealed class Flags96<TFlagsType>
		where TFlagsType : struct
	{
		//This might seem ridiclous that we don't use arrays BUT EF does not support arrays
		//for the models so we MUST use seperate fields.
		[WireMember(1)]
		public TFlagsType One { get; internal set; }

		[WireMember(2)]
		public TFlagsType Two { get; internal set; }

		[WireMember(3)]
		public TFlagsType Three { get; internal set; }

		/// <inheritdoc />
		public Flags96(TFlagsType one, TFlagsType two, TFlagsType three)
		{
			One = one;
			Two = two;
			Three = three;
		}

		/// <summary>
		/// Serializer ctor.
		/// </summary>
		public Flags96()
		{
			
		}
	}
}
