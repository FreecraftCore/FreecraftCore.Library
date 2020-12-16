using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	[WireDataContract]
	public sealed partial class ObjectUpdateValuesObjectBlock : ObjectUpdateBlock
	{
		/// <summary>
		/// The GUID of the object that should have its values updated.
		/// </summary>
		[WireMember(1)]
		public PackedGuid ObjectToUpdate { get; internal set; }

		/// <summary>
		/// The diff of the object values.
		/// </summary>
		[WireMember(2)]
		public UpdateFieldValueCollection UpdateValuesCollection { get; internal set; }

		[NotMapped]
		public override ObjectGuid Guid => ObjectToUpdate;

		/// <inheritdoc />
		public ObjectUpdateValuesObjectBlock(PackedGuid objectToUpdate, UpdateFieldValueCollection updateValuesCollection)
		{
			ObjectToUpdate = objectToUpdate;
			UpdateValuesCollection = updateValuesCollection;
		}

		/// <summary>
		/// Serializer ctor.
		/// </summary>
		public ObjectUpdateValuesObjectBlock()
		{
			
		}
	}
}
