using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	[WireDataContract]
	public sealed class SpellMissInfo
	{
		[WireMember(1)]
		public ObjectGuid Target { get; internal set; }

		[WireMember(2)]
		public SpellMissReasonType MissReason { get; internal set; }

		public bool HasReflectResult => MissReason == SpellMissReasonType.SPELL_MISS_REFLECT;

		[Optional(nameof(HasReflectResult))]
		[WireMember(3)]
		public SpellMissReasonType ReflectMissReason { get; internal set; }

		//TODO: Validate parameters
		public SpellMissInfo([NotNull] ObjectGuid target, SpellMissReasonType missReason, SpellMissReasonType reflectMissReason)
		{
			Target = target ?? throw new ArgumentNullException(nameof(target));
			MissReason = missReason;
			ReflectMissReason = reflectMissReason;
		}

		public SpellMissInfo([NotNull] ObjectGuid target, SpellMissReasonType missReason)
		{
			Target = target ?? throw new ArgumentNullException(nameof(target));
			MissReason = missReason;
		}

		public SpellMissInfo()
		{
			
		}
	}
}
