using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using FreecraftCore.Serializer;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace FreecraftCore
{
	/// <summary>
	/// GDBC format is simply a 4 byte length-prefixed
	/// array of WoW DBC entries/rows.
	/// </summary>
	/// <typeparam name="TEntryType">The DBC entry type.</typeparam>
	[WireDataContract]
	public sealed class GDBCCollection<TEntryType> : IGDBCCollection<TEntryType>
		where TEntryType : IDBCEntryIdentifiable
	{
		/// <summary>
		/// The DBC entries.
		/// Hidden/private to prevent mutability.
		/// </summary>
		[SendSize(PrimitiveSizeType.Int32)]
		[WireMember(1)]
		internal TEntryType[] Entries { get; set; } //setter for serializer purposes

		/// <summary>
		/// Internally managed readonly collection of DBC entries.
		/// </summary>
		[JsonIgnore]
		[NotMapped]
		private Lazy<ReadOnlyDictionary<int, TEntryType>> DBCCollectionMap { get; }

		/// <inheritdoc />
		[JsonIgnore]
		[NotMapped]
		public bool isInitialized => DBCCollectionMap.IsValueCreated;

		/// <inheritdoc />
		[JsonIgnore]
		[NotMapped]
		public IEnumerable<int> Keys
		{
			get
			{
				foreach (TEntryType entry in Entries)
					yield return entry.EntryId;

				yield break;
			}
		}

		[JsonIgnore]
		[NotMapped]
		public IEnumerable<TEntryType> Values => Entries;

		public GDBCCollection([NotNull] TEntryType[] entries)
			: this()
		{
			Entries = entries ?? throw new ArgumentNullException(nameof(entries));
		}

		/// <summary>
		/// Serializer ctor.
		/// </summary>
		public GDBCCollection()
		{
			DBCCollectionMap = new Lazy<ReadOnlyDictionary<int, TEntryType>>(ComputeDBCMap, LazyThreadSafetyMode.ExecutionAndPublication);
		}

		private ReadOnlyDictionary<int, TEntryType> ComputeDBCMap()
		{
			Dictionary<int, TEntryType> dbcMap = new Dictionary<int, TEntryType>();

			foreach (var entry in Entries)
				dbcMap[entry.EntryId] = entry;

			return new ReadOnlyDictionary<int, TEntryType>(dbcMap);
		}

		//Should never be used.
		IEnumerator<KeyValuePair<int, TEntryType>> IEnumerable<KeyValuePair<int, TEntryType>>.GetEnumerator()
		{
			return DBCCollectionMap.Value.GetEnumerator();
		}

		/// <inheritdoc />
		IEnumerator<TEntryType> IEnumerable<TEntryType>.GetEnumerator()
		{
			return Values.GetEnumerator();
		}

		/// <inheritdoc />
		IEnumerator IEnumerable.GetEnumerator()
		{
			return Values.GetEnumerator();
		}

		/// <inheritdoc />
		public int Count => Entries.Length;

		/// <inheritdoc />
		public bool ContainsKey(int key)
		{
			return DBCCollectionMap.Value.ContainsKey(key);
		}

		/// <inheritdoc />
		public bool TryGetValue(int key, out TEntryType value)
		{
			return DBCCollectionMap.Value.TryGetValue(key, out value);
		}

		/// <inheritdoc />
		public TEntryType this[int key]
		{
			get
			{
				try
				{
					return DBCCollectionMap.Value[key];
				}
				catch (Exception e)
				{
					throw new KeyNotFoundException($"Key: {key} not found in DBC: {typeof(TEntryType).Name}. Error: {e.Message}", e);
				}
			}
		}

		//Never know when JIT may optimize this away one day.
		/// <inheritdoc />
		[MethodImpl(MethodImplOptions.NoOptimization)]
		public void Initialize()
		{
			//Just access the lazy init map so it's created.
			int i = DBCCollectionMap.Value.Count;
		}
	}
}
