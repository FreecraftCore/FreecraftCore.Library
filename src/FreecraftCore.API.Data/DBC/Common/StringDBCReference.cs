using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	public interface IStringPointerReferenceable
	{
		uint StringReferenceOffset { get; }
	}

	[WireDataContract]
	public sealed class StringDBCReference : IStringPointerReferenceable
	{
		[WireMember(1)]
		public uint StringReferenceOffset { get; internal set; }

		/// <inheritdoc />
		public StringDBCReference(uint stringReferenceOffset)
		{
			StringReferenceOffset = stringReferenceOffset;
		}

		/// <summary>
		/// Serializer ctor.
		/// </summary>
		public StringDBCReference()
		{
			
		}
	}

	//TContainedType is there to carry DBC type information.
	[WireDataContract]
	public sealed class StringDBCReference<TContainedType> : IStringPointerReferenceable
	{
		[WireMember(1)]
		public uint StringReferenceOffset { get; internal set; }

		/// <inheritdoc />
		public StringDBCReference(uint stringReferenceOffset)
		{
			StringReferenceOffset = stringReferenceOffset;
		}

		/// <summary>
		/// Serializer ctor.
		/// </summary>
		protected StringDBCReference()
		{

		}
	}
}
