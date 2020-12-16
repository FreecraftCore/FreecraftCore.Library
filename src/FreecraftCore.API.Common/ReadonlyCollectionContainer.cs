using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	public abstract class ReadonlyCollectionContainer<TItemType> : IEnumerable<TItemType>
	{
		/// <summary>
		/// The serializable items.
		/// </summary>
		protected abstract TItemType[] _Items { get; }

		/// <summary>
		/// The collection items.
		/// </summary>
		public IReadOnlyCollection<TItemType> Items => _Items;

		/// <inheritdoc />
		public IEnumerator<TItemType> GetEnumerator()
		{
			return Items.GetEnumerator();
		}

		/// <inheritdoc />
		IEnumerator IEnumerable.GetEnumerator()
		{
			return Items.GetEnumerator();
		}
	}
}
