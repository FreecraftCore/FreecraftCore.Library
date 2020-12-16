using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	public sealed class DbcStringReader : DbcReaderBase, IDbcStringReadable
	{
		/// <summary>
		/// The serializer
		/// </summary>
		private ISerializerService Serializer { get; }

		/// <inheritdoc />
		public DbcStringReader([NotNull] Stream dbcStream, [NotNull] ISerializerService serializer) 
			: base(dbcStream)
		{
			Serializer = serializer ?? throw new ArgumentNullException(nameof(serializer));
		}

		/// <inheritdoc />
		public async Task<IReadOnlyDictionary<uint, string>> ParseOnlyStrings()
		{
			return await ReadDBCStringBlock(await this.ReadDBCHeader(Serializer));
		}

		//TODO: Does this work for 0 length blocks?
		private async Task<Dictionary<uint, string>> ReadDBCStringBlock(DBCHeader header)
		{
			DBCStream.Position = header.StartStringPosition;
			byte[] bytes = new byte[DBCStream.Length - DBCStream.Position];

			await ReadBytesIntoArrayFromStream(bytes);

			return ReadStringEntries(bytes);
		}

		private Dictionary<uint, string> ReadStringEntries(byte[] bytes)
		{
			Dictionary<uint, string> stringMap = new Dictionary<uint, string>(1000);
			int offset = 0;

			for(int currentOffset = 0; currentOffset < bytes.Length;)
			{
				string readString = Serializer.Read<StringDBC>(new Span<byte>(bytes), ref offset).StringValue;

				stringMap.Add((uint)currentOffset, readString);

				//We must move the offset forward length + null terminator
				currentOffset += Encoding.UTF8.GetByteCount(readString) + 1;
			}

			return stringMap;
		}
	}
}
