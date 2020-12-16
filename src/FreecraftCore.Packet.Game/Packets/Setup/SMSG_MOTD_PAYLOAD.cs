using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	//TC says new in 2.0.1 which leads me to believe 3.3.5 and 1.12.1 will have differing structures.
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.SMSG_MOTD)]
	public sealed partial class SMSG_MOTD_PAYLOAD : GamePacketPayload
	{
		//the MOTD on Trinitycore is implemented as a tokenized string
		//They split by the token and then it becomes a length-prefixed array of null terminated ASCII
		//strings meaning we can easily handle that.
		[Encoding(EncodingType.ASCII)]
		[WireMember(1)]
		[SendSize(PrimitiveSizeType.Int32)]
		internal string[] MessageOfTheDayByLines { get; set; }

		/// <summary>
		/// The message of the day split onto individual lines.
		/// </summary>
		public IReadOnlyCollection<string> MessageOfTheDay => MessageOfTheDayByLines;

		/// <inheritdoc />
		public SMSG_MOTD_PAYLOAD([NotNull] string[] messageOfTheDayByLines)
			: this()
		{
			MessageOfTheDayByLines = messageOfTheDayByLines ?? throw new ArgumentNullException(nameof(messageOfTheDayByLines));
		}

		/// <summary>
		/// Serializer ctor.
		/// </summary>
		public SMSG_MOTD_PAYLOAD()
			: base(NetworkOperationCode.SMSG_MOTD)
		{
			
		}
	}
}
