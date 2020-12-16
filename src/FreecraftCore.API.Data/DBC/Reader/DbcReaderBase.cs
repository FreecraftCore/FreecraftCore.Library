using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	public abstract class DbcReaderBase
	{
		/// <summary>
		/// The stream that contains the DBC data.
		/// </summary>
		protected Stream DBCStream { get; }

		/// <inheritdoc />
		protected DbcReaderBase([NotNull] Stream dbcStream)
		{
			DBCStream = dbcStream ?? throw new ArgumentNullException(nameof(dbcStream));
		}

		protected async Task ReadBytesIntoArrayFromStream(byte[] bytes)
		{
			if(DBCStream.Length - DBCStream.Position < bytes.Length)
				throw new InvalidOperationException($"Tried to read bytes from stream for reader Type: {GetType().Name} Stream Position: {DBCStream.Position} Stream Length: {DBCStream.Length} RequestedByteLength: {bytes.Length}");

			for(int offset = 0; offset < bytes.Length;)
				offset += await DBCStream.ReadAsync(bytes, offset, bytes.Length - offset);
		}

		protected async Task<DBCHeader> ReadDBCHeader([NotNull] ISerializerService serializer)
		{
			if(serializer == null) throw new ArgumentNullException(nameof(serializer));

			byte[] bytes = new byte[DBCHeader.HeaderSize];

			await ReadBytesIntoArrayFromStream(bytes);

			//Read the header, it contains some information needed to read the whole DBC
			return serializer.Read<DBCHeader>(new Span<byte>(bytes), 0);
		}
	}
}
