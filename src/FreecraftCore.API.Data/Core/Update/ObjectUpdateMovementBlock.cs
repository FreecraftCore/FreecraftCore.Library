using System.ComponentModel.DataAnnotations.Schema;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	//See: https://github.com/TrinityCore/WowPacketParser/blob/master/WowPacketParser/Parsing/Parsers/UpdateHandler.cs#L2527
	[WireDataContract]
	public sealed partial class ObjectUpdateMovementBlock : ObjectUpdateBlock
	{
		//ClientVersion.AddedInVersion(ClientVersionBuild.V3_1_2_9901). Pre 3.1 it was a non-packed guid
		[WireMember(1)]
		public PackedGuid MovementGuid { get; internal set; }

		[WireMember(2)]
		public MovementBlockData MovementData { get; internal set; }

		[NotMapped]
		public override ObjectGuid Guid => MovementGuid;

		/// <inheritdoc />
		public ObjectUpdateMovementBlock(PackedGuid movementGuid, MovementBlockData movementData)
		{
			MovementGuid = movementGuid;
			MovementData = movementData;
		}

		public ObjectUpdateMovementBlock()
		{
			
		}
	}
}
