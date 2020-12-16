using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	[WireDataContract]
	public sealed class GroupListMemberData
	{
		[WireMember(1)]
		public string PlayerName { get; internal set; }

		[WireMember(2)]
		public ObjectGuid PlayerGuid { get; internal set; }

		[WireMember(3)]
		public GroupMemberOnlineStatus MemberStatus { get; internal set; }

		[WireMember(4)]
		public byte GroupId { get; internal set; }

		[WireMember(5)]
		public GroupMemberFlags MemberFlags { get; internal set; }

		[WireMember(6)]
		public LfgRoles OptionalDungeonLFGRoles { get; internal set; }

		/// <summary>
		/// Serializer ctor.
		/// </summary>
		public GroupListMemberData()
		{
			
		}
	}
}
