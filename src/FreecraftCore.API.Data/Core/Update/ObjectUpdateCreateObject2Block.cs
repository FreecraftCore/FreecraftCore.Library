using System.ComponentModel.DataAnnotations.Schema;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	/// <summary>
	/// The update block involved with object creation.
	/// Used when an object is being copied or respawned.
	/// </summary>
	[WireDataContract]
	public sealed partial class ObjectUpdateCreateObject2Block : ObjectUpdateBlock, IObjectCreationBlock
	{
		/// <summary>
		/// The creation data.
		/// </summary>
		[WireMember(1)]
		public ObjectCreationData CreationData { get; internal set; }

		[NotMapped]
		public override ObjectGuid Guid => CreationData.CreationGuid;

		/// <inheritdoc />
		public ObjectUpdateCreateObject2Block(ObjectCreationData creationData)
		{
			CreationData = creationData;
		}

		/// <summary>
		/// Serializer ctor.
		/// </summary>
		public ObjectUpdateCreateObject2Block()
		{

		}
	}
}
