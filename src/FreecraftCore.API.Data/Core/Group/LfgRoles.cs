﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FreecraftCore
{
	[Flags]
	public enum LfgRoles : byte
	{
		PLAYER_ROLE_NONE = 0x00,
		PLAYER_ROLE_LEADER = 0x01,
		PLAYER_ROLE_TANK = 0x02,
		PLAYER_ROLE_HEALER = 0x04,
		PLAYER_ROLE_DAMAGE = 0x08
	}
}
