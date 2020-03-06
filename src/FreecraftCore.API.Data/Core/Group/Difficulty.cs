﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FreecraftCore
{
	public enum Difficulty : byte
	{
		REGULAR_DIFFICULTY = 0,

		DUNGEON_DIFFICULTY_NORMAL = 0,
		DUNGEON_DIFFICULTY_HEROIC = 1,
		DUNGEON_DIFFICULTY_EPIC = 2,

		RAID_DIFFICULTY_10MAN_NORMAL = 0,
		RAID_DIFFICULTY_25MAN_NORMAL = 1,
		RAID_DIFFICULTY_10MAN_HEROIC = 2,
		RAID_DIFFICULTY_25MAN_HEROIC = 3
	}
}
