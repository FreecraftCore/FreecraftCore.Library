using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	//Based on: https://github.com/TrinityCore/SpellWork/blob/master/SpellWork/DBC/Structure.cs
	/// <summary>
	/// Structure for the DBC file header.
	/// </summary>
	[WireMessageType]
	[WireDataContract]
	public sealed partial class DBCHeader
	{
		/// <summary>
		/// The expected signature that a DBC file should have.
		/// </summary>
		public const int ExpectedSignature = 0x43424457;

		/// <summary>
		/// The size of the DBC Header.
		/// </summary>
		public const int HeaderSize = sizeof(int) * 5;

		/// <summary>
		/// TODO what is this
		/// </summary>
		[WireMember(1)]
		public int Signature { get; internal set; }

		/// <summary>
		/// Amount of entries in the DBC.
		/// </summary>
		[WireMember(2)]
		public int RecordsCount { get; internal set; }

		/// <summary>
		/// The amount of fields in the DBC.
		/// </summary>
		[WireMember(3)]
		public int FieldsCount { get; internal set; }

		/// <summary>
		/// The size of the record.
		/// </summary>
		[WireMember(4)]
		public int RecordSize { get; internal set; }

		/// <summary>
		/// The DBC string size.
		/// </summary>
		[WireMember(5)]
		public int StringTableSize { get; internal set; }

		/// <summary>
		/// TODO: What is this
		/// </summary>
		public bool IsDBC => Signature == ExpectedSignature;

		/// <summary>
		/// The size of the DBC records.
		/// </summary>
		public long DataSize => RecordsCount * RecordSize;

		/// <summary>
		/// The starting position of the string data.
		/// </summary>
		public long StartStringPosition => DataSize + sizeof(int) * 5;

		/// <inheritdoc />
		public DBCHeader(int recordsCount, int fieldsCount, int recordSize, int stringTableSize)
		{
			//We just do this automatically, it should always be the expected signature.
			Signature = ExpectedSignature;

			RecordsCount = recordsCount;
			FieldsCount = fieldsCount;
			RecordSize = recordSize;
			StringTableSize = stringTableSize;
		}

		//Serializer ctor
		public DBCHeader()
		{
			
		}

		/// <inheritdoc />
		public override string ToString()
		{
			return $"RecordCount: {RecordsCount} FieldCount: {FieldsCount} RecordSize: {RecordSize} StringOffsetPos: {StartStringPosition}";
		}
	}
}
