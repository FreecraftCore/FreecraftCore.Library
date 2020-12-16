using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace FreecraftCore
{
	[Owned]
	[WireDataContract]
	public sealed class ReputationRate
	{
		[WireMember(1)]
		public Vector4<CharacterRaceMask> RaceMask { get; internal set; }

		[WireMember(2)]
		public Vector4<CharacterClassMask> ClassMask { get; internal set; }

		[WireMember(3)]
		public Vector4<int> BaseReputation { get; internal set; }

		[WireMember(4)]
		public Vector4<FactionFlags> FactionFlag { get; internal set; }

		public ReputationRate([NotNull] Vector4<CharacterRaceMask> raceMask, [NotNull] Vector4<CharacterClassMask> classMask, [NotNull] Vector4<int> baseReputation, [NotNull] Vector4<FactionFlags> factionFlag)
		{
			RaceMask = raceMask ?? throw new ArgumentNullException(nameof(raceMask));
			ClassMask = classMask ?? throw new ArgumentNullException(nameof(classMask));
			BaseReputation = baseReputation ?? throw new ArgumentNullException(nameof(baseReputation));
			FactionFlag = factionFlag ?? throw new ArgumentNullException(nameof(factionFlag));
		}

		/// <summary>
		/// Serializer ctor.
		/// </summary>
		public ReputationRate()
		{
			
		}
	}
}
