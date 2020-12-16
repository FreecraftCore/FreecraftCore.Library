using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	//These differ from 1.12.1 and 3.3.5
	[WireDataContract]
	public sealed class UpdateBlockCollection : ReadonlyCollectionContainer<ObjectUpdateBlock>
	{
		//ClientVersion.RemovedInVersion(ClientVersionBuild.V3_0_2_9056) there was a bool inbetween count and array for HasTransport.

		//We do this because the serializer currently chokes
		[SendSize(PrimitiveSizeType.Int32)]
		[WireMember(1)]
		internal ObjectUpdateBlock[] _items;

		//WPP shows this is sent as a int length prefixed collection of update blocks.
		/// <inheritdoc />
		protected override ObjectUpdateBlock[] _Items => _items;

		public UpdateBlockCollection([NotNull] ObjectUpdateBlock[] items)
		{
			_items = items ?? throw new ArgumentNullException(nameof(items));
		}

		public UpdateBlockCollection()
		{
			
		}
	}
}
