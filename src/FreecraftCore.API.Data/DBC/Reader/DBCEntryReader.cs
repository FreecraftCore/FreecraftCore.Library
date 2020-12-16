using FreecraftCore.Serializer;
using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace FreecraftCore
{
	public static class DBCEntryReader
	{
		public static IEnumerable<Type> RequiredSerializeableTypes => new Type[2] { typeof(DBCHeader), typeof(StringDBC) };
	}

	/// <summary>
	/// DBC file/stream reader.
	/// Providing ability to read/parse a DBC file from a stream.
	/// </summary>
	/// <typeparam name="TDBCEntryType">The entry type.</typeparam>
	public sealed class DBCEntryReader<TDBCEntryType> : DbcReaderBase, IDbcEntryReader<TDBCEntryType>
		where TDBCEntryType : IDBCEntryIdentifiable, ITypeSerializerReadingStrategy<TDBCEntryType>
	{
		/// <summary>
		/// The serializer
		/// </summary>
		private ISerializerService Serializer { get; }

		/// <inheritdoc />
		public DBCEntryReader([NotNull] Stream dbcStream, [NotNull] ISerializerService serializer) 
			: base(dbcStream)
		{
			Serializer = serializer ?? throw new ArgumentNullException(nameof(serializer));
		}

		public async Task<ParsedDBCFile<TDBCEntryType>> Parse()
		{
			DBCHeader header = null;
			try
			{
				header = await ReadDBCHeader(Serializer);
			}
			catch(Exception e)
			{
				throw new InvalidOperationException($"Failed to read {nameof(DBCHeader)} for Type: {typeof(TDBCEntryType).Name}. Exception: {e.Message} \n\n Stack: {e.StackTrace}", e);
			}

			//The below is from the: https://github.com/TrinityCore/SpellWork/blob/master/SpellWork/DBC/DBCReader.cs
			if(!header.IsDBC)
				throw new InvalidOperationException($"Failed to load DBC for DBC Type: {typeof(TDBCEntryType)} Signature: {header.Signature}");

			//TODO: Implement DBC string reading
			return new ParsedDBCFile<TDBCEntryType>(await ReadDBCEntryBlock(header).ConfigureAwait(false));
		}

		private async Task<Dictionary<int, TDBCEntryType>> ReadDBCEntryBlock(DBCHeader header)
		{
			//Guessing the size here, no way to know.
			Dictionary<int, TDBCEntryType> entryMap = new Dictionary<int, TDBCEntryType>(header.RecordsCount);

			int offset = 0;
			byte[] bytes = new byte[header.RecordSize * header.RecordsCount];

			//Lock for safety, we don't want anyone else accessing the stream while we read it.
			await ReadBytesIntoArrayFromStream(bytes);

			for(int i = 0; i < header.RecordsCount; i++)
			{
				try
				{
					TDBCEntryType entry = Serializer.Read<TDBCEntryType>(new Span<byte>(bytes), ref offset);
					entryMap.Add((int)entry.EntryId, entry);
				}
				catch(Exception e)
				{
					throw new InvalidOperationException($"Encountered error reading entry Type: {typeof(TDBCEntryType).Name} at Entry count: {i} Exception: {e.Message} \n\n Stack: {e.StackTrace}", e);
				}
			}

			return entryMap;
		}
	}
}
