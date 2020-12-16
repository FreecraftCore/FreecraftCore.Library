using FreecraftCore.Serializer;

namespace FreecraftCore
{
	/// <summary>
	/// Sent to the connecting user before the character list.
	/// Sent with <see cref="NetworkOperationCode.SMSG_TUTORIAL_FLAGS"/>.
	/// </summary>
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.SMSG_TUTORIAL_FLAGS)]
	public sealed partial class TutorialDataEvent : GamePacketPayload
	{
		public override bool isValid => true;

		[ReadToEnd]
		[WireMember(1)]
		public byte[] Data { get; internal set; }

		/// <summary>
		/// Serializer ctor.
		/// </summary>
		public TutorialDataEvent()
			: base(NetworkOperationCode.SMSG_TUTORIAL_FLAGS)
		{
			
		}
	}
}
