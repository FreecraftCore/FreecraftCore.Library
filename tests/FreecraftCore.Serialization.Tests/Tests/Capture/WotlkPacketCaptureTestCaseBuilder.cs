using System;
using System.Collections.Generic;
using System.Linq;
using Castle.Core.Internal;

namespace FreecraftCore
{
	public sealed class WotlkPacketCaptureTestCaseBuilder : PacketCaptureTestCaseCaptureBuilder
	{
		/// <inheritdoc />
		public override Expansions Expac { get; } = Expansions.WRATH_OF_THE_LICH_KING;

		public WotlkPacketCaptureTestCaseBuilder()
		{
			
		}

		/// <inheritdoc />
		public override IEnumerable<Type> BuildSerializableTypes()
		{
			//Then we want to register DTOs for unknown
			return GamePacketMetadataMarker.SerializableTypes
				.ToArray();
		}
	}
}