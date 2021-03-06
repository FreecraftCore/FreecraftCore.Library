﻿using System;

namespace FreecraftCore
{
	//Mask isn't +1 shift, see: AuraEffect::HandleModRating
	[Flags]
	public enum CombatRatingMask
	{
		WEAPON_SKILL = 1 << CombatRating.WEAPON_SKILL,
		DEFENSE_SKILL = 1 << CombatRating.DEFENSE_SKILL,
		DODGE = 1 << CombatRating.DODGE,
		PARRY = 1 << CombatRating.PARRY,
		BLOCK = 1 << CombatRating.BLOCK,
		HIT_MELEE = 1 << CombatRating.HIT_MELEE,
		HIT_RANGED = 1 << CombatRating.HIT_RANGED,
		HIT_SPELL = 1 << CombatRating.HIT_SPELL,
		CRIT_MELEE = 1 << CombatRating.CRIT_MELEE,
		CRIT_RANGED = 1 << CombatRating.CRIT_RANGED,
		CRIT_SPELL = 1 << CombatRating.CRIT_SPELL,
		HIT_TAKEN_MELEE = 1 << CombatRating.HIT_TAKEN_MELEE,
		HIT_TAKEN_RANGED = 1 << CombatRating.HIT_TAKEN_RANGED,
		HIT_TAKEN_SPELL = 1 << CombatRating.HIT_TAKEN_SPELL,
		CRIT_TAKEN_MELEE = 1 << CombatRating.CRIT_TAKEN_MELEE,
		CRIT_TAKEN_RANGED = 1 << CombatRating.CRIT_TAKEN_RANGED,
		CRIT_TAKEN_SPELL = 1 << CombatRating.CRIT_TAKEN_SPELL,
		HASTE_MELEE = 1 << CombatRating.HASTE_MELEE,
		HASTE_RANGED = 1 << CombatRating.HASTE_RANGED,
		HASTE_SPELL = 1 << CombatRating.HASTE_SPELL,
		WEAPON_SKILL_MAINHAND = 1 << CombatRating.WEAPON_SKILL_MAINHAND,
		WEAPON_SKILL_OFFHAND = 1 << CombatRating.WEAPON_SKILL_OFFHAND,
		WEAPON_SKILL_RANGED = 1 << CombatRating.WEAPON_SKILL_RANGED,
		EXPERTISE = 1 << CombatRating.EXPERTISE,
		ARMOR_PENETRATION = 1 << CombatRating.ARMOR_PENETRATION,
	};

	public enum CombatRating
	{
		WEAPON_SKILL = 0,
		DEFENSE_SKILL = 1,
		DODGE = 2,
		PARRY = 3,
		BLOCK = 4,
		HIT_MELEE = 5,
		HIT_RANGED = 6,
		HIT_SPELL = 7,
		CRIT_MELEE = 8,
		CRIT_RANGED = 9,
		CRIT_SPELL = 10,
		HIT_TAKEN_MELEE = 11,
		HIT_TAKEN_RANGED = 12,
		HIT_TAKEN_SPELL = 13,
		CRIT_TAKEN_MELEE = 14,
		CRIT_TAKEN_RANGED = 15,
		CRIT_TAKEN_SPELL = 16,
		HASTE_MELEE = 17,
		HASTE_RANGED = 18,
		HASTE_SPELL = 19,
		WEAPON_SKILL_MAINHAND = 20,
		WEAPON_SKILL_OFFHAND = 21,
		WEAPON_SKILL_RANGED = 22,
		EXPERTISE = 23,
		ARMOR_PENETRATION = 24
	};
}