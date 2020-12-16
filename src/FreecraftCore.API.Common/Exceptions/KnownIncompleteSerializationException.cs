using System;
using System.Collections.Generic;
using System.Text;
using JetBrains.Annotations;

namespace FreecraftCore
{
	public sealed class KnownIncompleteSerializationException : Exception
	{
		public Type SerializableType { get; }

		public static Exception Create<T>(string message)
			where T : class
		{
			return new KnownIncompleteSerializationException(typeof(T), message);
		}

		public KnownIncompleteSerializationException([NotNull] Type serializableType, string message)
			: base(message)
		{
			SerializableType = serializableType ?? throw new ArgumentNullException(nameof(serializableType));
		}
	}
}
