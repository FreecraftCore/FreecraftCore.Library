using FreecraftCore.Serializer;

namespace FreecraftCore
{
	/// <summary>
	/// Represents an unknown game payload.
	/// </summary>
	[ProtocolGrouping(ProtocolCode.None)] //Unknown has no protocol
	[WireDataContract]
	public partial class UnknownGamePayload : GamePacketPayload
	{
		public override bool isValid => true;

		/// <summary>
		/// Unknown binary payload data.
		/// </summary>
		[ReadToEnd]
		[WireMember(1)]
		public byte[] Data { get; internal set; }

		public UnknownGamePayload()
			: base(NetworkOperationCode.END)
		{
			//Don't need to initialize anything
			//it's unknown so just check the OpCode to see what it is.
		}
	}
}
