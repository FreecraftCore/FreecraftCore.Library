using System;
using System.ComponentModel.DataAnnotations.Schema;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	/// <summary>
	/// Object block sent for near objects.
	/// </summary>
	[WireDataContract]
	public sealed partial class ObjectUpdateNearObjectsBlock : ObjectUpdateBlock
	{
		/// <summary>
		/// Collection of object GUIDS that have been destroyed.
		/// </summary>
		[WireMember(1)]
		public PackedGuidCollection NearGuids { get; internal set; }

		[NotMapped]
		public override ObjectGuid Guid => ObjectGuid.Empty;

		/// <inheritdoc />
		public ObjectUpdateNearObjectsBlock([NotNull] PackedGuidCollection nearGuids)
		{
			NearGuids = nearGuids ?? throw new ArgumentNullException(nameof(nearGuids));
		}

		public ObjectUpdateNearObjectsBlock()
		{

		}
	}
}
