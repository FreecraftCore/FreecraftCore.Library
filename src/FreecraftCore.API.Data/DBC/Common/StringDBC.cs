using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	[WireDataContract]
	public sealed class StringDBC
	{
		/// <summary>
		/// Null terminated ASCII string.
		/// </summary>
		[Encoding(EncodingType.UTF8)]
		[WireMember(1)]
		public string StringValue { get; internal set; }

		/// <inheritdoc />
		public StringDBC(string stringValue)
		{
			StringValue = stringValue ?? "";
		}

		/// <summary>
		/// Serializer ctor.
		/// </summary>
		protected StringDBC()
		{
			
		}
	}
}
