using FreecraftCore.Serializer;

namespace FreecraftCore
{

	//Trinitycore
	/*    std::string split_date = "01/01/01";

	WorldPacket data(SMSG_REALM_SPLIT, 4+4+split_date.size()+1);
	data << unk;
	data << uint32(0x00000000);                             // realm split state
	// split states:
	// 0x0 realm normal
	// 0x1 realm split
	// 0x2 realm split pending
	data << split_date;*/
	/// <summary>
	/// Sent to the connecting during character list
	/// in response to <see cref="NetworkOperationCode.CMSG_REALM_SPLIT"/>.
	/// Sent with <see cref="NetworkOperationCode.SMSG_REALM_SPLIT"/>.
	/// </summary>
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.SMSG_REALM_SPLIT)]
	public sealed partial class RealmSplitResponse : GamePacketPayload
	{
		//TODO: Extrat this.
		/// <summary>
		/// Enumeration of all valid realm split states.
		/// </summary>
		public enum RealmSplitState : int
		{
			//TODO: Doc?
			Normal = 0,
			RealmSplit = 1,
			Pending = 2,
		}

		/// <summary>
		/// SHOULD match the Unk in <see cref="RealmSplitRequest"/>.
		/// Don't know if it has to.
		/// </summary>
		[WireMember(1)]
		public int Unk { get; internal set; }

		/// <summary>
		/// Indicates the split state.
		/// </summary>
		[WireMember(2)]
		public RealmSplitState SplitState { get; internal set; } = RealmSplitState.Normal;
	
		//TC default to "01/01/01"
		/// <summary>
		/// Null terminated split date.
		/// Ignore if not split.
		/// </summary>
		[Encoding(EncodingType.ASCII)]
		[WireMember(3)]
		public string SplitDate { get; internal set; } = "01/01/01";

		/// <summary>
		/// 
		/// </summary>
		/// <param name="unk">Unk should match the unk in the <see cref="RealmSplitRequest"/>.</param>
		public RealmSplitResponse(int unk)
			: this()
		{
			Unk = unk;
		}

		public RealmSplitResponse()
			: base(NetworkOperationCode.SMSG_REALM_SPLIT)
		{
			
		}
	}
}
