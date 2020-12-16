using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	[CustomTypeSerializer(typeof(CustomUpdateFieldCollectionTypeSerializer))]
	[WireDataContract]
	public sealed class UpdateFieldValueCollection
	{
		/// <summary>
		/// The update field mask that can be used to determine
		/// what values are in the <see cref="UpdateDiffValues"/>.
		/// </summary>
		public WireReadyBitArray UpdateMask { get; }

		/// <summary>
		/// The new values (diff) based on the provided mask.
		/// Each update field is suppose to be 4 bytes.
		/// </summary>
		public byte[] UpdateDiffValues { get; }

		/// <inheritdoc />
		public UpdateFieldValueCollection([NotNull] WireReadyBitArray updateMask, [NotNull] byte[] updateDiffValues)
		{
			UpdateMask = updateMask ?? throw new ArgumentNullException(nameof(updateMask));
			UpdateDiffValues = updateDiffValues ?? throw new ArgumentNullException(nameof(updateDiffValues));
		}

		public UpdateFieldValueCollection()
		{
			
		}
	}
}
