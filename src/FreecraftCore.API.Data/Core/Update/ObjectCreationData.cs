using FreecraftCore.Serializer;

namespace FreecraftCore
{
	[WireDataContract]
	public sealed class ObjectCreationData
	{
		/// <summary>
		/// Indicates the <see cref="ObjectGuid"/> type of the creation
		/// update block.
		/// </summary>
		[WireMember(1)]
		public PackedGuid CreationGuid { get; internal set; }

		/// <summary>
		/// The object type of the creation.
		/// </summary>
		[WireMember(2)]
		public ObjectType CreationObjectType { get; internal set; }

		/// <summary>
		/// The movement data.
		/// </summary>
		[WireMember(3)]
		public MovementBlockData MovementData { get; internal set; }

		//Move comes before this
		/// <summary>
		/// The object field values of the created object.
		/// </summary>
		[WireMember(4)]
		public UpdateFieldValueCollection ObjectValuesCollection { get; internal set; }

		/// <inheritdoc />
		public ObjectCreationData(PackedGuid creationGuid, ObjectType creationObjectType, MovementBlockData movementData, UpdateFieldValueCollection objectValuesCollection)
		{
			CreationGuid = creationGuid;
			CreationObjectType = creationObjectType;
			MovementData = movementData;
			ObjectValuesCollection = objectValuesCollection;
		}

		public ObjectCreationData()
		{
			
		}
	}
}
