﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FreecraftCore
{
	public enum AchievementCriteriaTypes
	{
		KILL_CREATURE = 0,
		WIN_BG = 1,
		REACH_LEVEL = 5,
		REACH_SKILL_LEVEL = 7,
		COMPLETE_ACHIEVEMENT = 8,
		COMPLETE_QUEST_COUNT = 9,
		COMPLETE_DAILY_QUEST_DAILY = 10, // you have to complete a daily quest x times in a row
		COMPLETE_QUESTS_IN_ZONE = 11,
		DAMAGE_DONE = 13,
		COMPLETE_DAILY_QUEST = 14,
		COMPLETE_BATTLEGROUND = 15,
		DEATH_AT_MAP = 16,
		DEATH = 17,
		DEATH_IN_DUNGEON = 18,
		COMPLETE_RAID = 19,
		KILLED_BY_CREATURE = 20,
		KILLED_BY_PLAYER = 23,
		FALL_WITHOUT_DYING = 24,
		DEATHS_FROM = 26,
		COMPLETE_QUEST = 27,
		BE_SPELL_TARGET = 28,
		CAST_SPELL = 29,
		BG_OBJECTIVE_CAPTURE = 30,
		HONORABLE_KILL_AT_AREA = 31,
		WIN_ARENA = 32,
		PLAY_ARENA = 33,
		LEARN_SPELL = 34,
		HONORABLE_KILL = 35,
		OWN_ITEM = 36,
		WIN_RATED_ARENA = 37,
		HIGHEST_TEAM_RATING = 38,
		HIGHEST_PERSONAL_RATING = 39,
		LEARN_SKILL_LEVEL = 40,
		USE_ITEM = 41,
		LOOT_ITEM = 42,
		EXPLORE_AREA = 43,
		OWN_RANK = 44,
		BUY_BANK_SLOT = 45,
		GAIN_REPUTATION = 46,
		GAIN_EXALTED_REPUTATION = 47,
		VISIT_BARBER_SHOP = 48,
		EQUIP_EPIC_ITEM = 49,
		ROLL_NEED_ON_LOOT = 50, // @todo itemlevel is mentioned in text but not present in dbc
		ROLL_GREED_ON_LOOT = 51,
		HK_CLASS = 52,
		HK_RACE = 53,
		DO_EMOTE = 54,
		HEALING_DONE = 55,
		GET_KILLING_BLOWS = 56, // @todo in some cases map not present, and in some cases need do without die
		EQUIP_ITEM = 57,
		MONEY_FROM_VENDORS = 59,
		GOLD_SPENT_FOR_TALENTS = 60,
		NUMBER_OF_TALENT_RESETS = 61,
		MONEY_FROM_QUEST_REWARD = 62,
		GOLD_SPENT_FOR_TRAVELLING = 63,
		GOLD_SPENT_AT_BARBER = 65,
		GOLD_SPENT_FOR_MAIL = 66,
		LOOT_MONEY = 67,
		USE_GAMEOBJECT = 68,
		BE_SPELL_TARGET2 = 69,
		SPECIAL_PVP_KILL = 70,
		FISH_IN_GAMEOBJECT = 72,
		// @todo 73: Achievements 1515, 1241, 1103 (Name: Mal'Ganis)
		ON_LOGIN = 74,
		LEARN_SKILLLINE_SPELLS = 75,
		WIN_DUEL = 76,
		LOSE_DUEL = 77,
		KILL_CREATURE_TYPE = 78,
		GOLD_EARNED_BY_AUCTIONS = 80,
		CREATE_AUCTION = 82,
		HIGHEST_AUCTION_BID = 83,
		WON_AUCTIONS = 84,
		HIGHEST_AUCTION_SOLD = 85,
		HIGHEST_GOLD_VALUE_OWNED = 86,
		GAIN_REVERED_REPUTATION = 87,
		GAIN_HONORED_REPUTATION = 88,
		KNOWN_FACTIONS = 89,
		LOOT_EPIC_ITEM = 90,
		RECEIVE_EPIC_ITEM = 91,
		ROLL_NEED = 93,
		ROLL_GREED = 94,
		HIGHEST_HEALTH = 95,
		HIGHEST_POWER = 96,
		HIGHEST_STAT = 97,
		HIGHEST_SPELLPOWER = 98,
		HIGHEST_ARMOR = 99,
		HIGHEST_RATING = 100,
		HIGHEST_HIT_DEALT = 101,
		HIGHEST_HIT_RECEIVED = 102,
		TOTAL_DAMAGE_RECEIVED = 103,
		HIGHEST_HEAL_CAST = 104,
		TOTAL_HEALING_RECEIVED = 105,
		HIGHEST_HEALING_RECEIVED = 106,
		QUEST_ABANDONED = 107,
		FLIGHT_PATHS_TAKEN = 108,
		LOOT_TYPE = 109,
		CAST_SPELL2 = 110, // @todo target entry is missing
		LEARN_SKILL_LINE = 112,
		EARN_HONORABLE_KILL = 113,
		ACCEPTED_SUMMONINGS = 114,
		EARN_ACHIEVEMENT_POINTS = 115,
		USE_LFD_TO_GROUP_WITH_PLAYERS = 119,
	}
}
