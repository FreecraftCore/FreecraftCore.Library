using System;
using System.ComponentModel.DataAnnotations.Schema;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	/// <summary>
	/// Block of destroyed object guids.
	/// </summary>
	[WireDataContract]
	public sealed partial class ObjectUpdateDestroyObjectBlock : ObjectUpdateBlock
	{
		/// <summary>
		/// Collection of object GUIDS that have been destroyed.
		/// </summary>
		[WireMember(1)]
		public PackedGuidCollection DestroyedGuids { get; internal set; }

		[NotMapped]
		public override ObjectGuid Guid => ObjectGuid.Empty;

		/// <inheritdoc />
		public ObjectUpdateDestroyObjectBlock([NotNull] PackedGuidCollection destroyedGuids)
		{
			DestroyedGuids = destroyedGuids ?? throw new ArgumentNullException(nameof(destroyedGuids));
		}

		public ObjectUpdateDestroyObjectBlock()
		{

		}
	}
}
