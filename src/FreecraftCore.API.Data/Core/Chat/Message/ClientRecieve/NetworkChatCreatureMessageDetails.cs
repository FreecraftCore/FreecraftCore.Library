using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	[WireDataContract]
	public sealed class NetworkChatCreatureMessageDetails
	{
		/// <summary>
		/// The addressing details containing the
		/// To and From about the message.
		/// </summary>
		[WireMember(1)]
		public MessageAddressingDetails<string> AddressingDetails { get; internal set; }

		//Optional data depending on the object type
		public bool HasRecieverName => !AddressingDetails.RecieverGuid.isEmpty()
			&& !AddressingDetails.RecieverGuid.isType(EntityGuidMask.Player)
			&& !AddressingDetails.RecieverGuid.isType(EntityGuidMask.Pet);

		[SendSize(PrimitiveSizeType.Int32)]
		[Encoding(EncodingType.ASCII)]
		[Optional(nameof(HasRecieverName))]
		[WireMember(3)]
		public string RecieverName { get; internal set; }

		//TODO: Validate CTOR inputs
		/// <inheritdoc />
		public NetworkChatCreatureMessageDetails([NotNull] MessageAddressingDetails<string> addressingDetails, string recieverName)
		{
			AddressingDetails = addressingDetails ?? throw new ArgumentNullException(nameof(addressingDetails));
			RecieverName = recieverName;
		}

		/// <inheritdoc />
		public NetworkChatCreatureMessageDetails(MessageAddressingDetails<string> addressingDetails)
		{
			AddressingDetails = addressingDetails;
		}

		public NetworkChatCreatureMessageDetails()
		{
			
		}
	}
}
