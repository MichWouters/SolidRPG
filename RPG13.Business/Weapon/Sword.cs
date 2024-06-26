﻿using RPG13.Business.Weapon.Interfaces;

namespace RPG13.Business.Weapon
{
    public class Sword : IMeleeWeapon
    {
        public string Name { get; } = "Standard sword. A legionairs' best friend.";
        public int MinStrength { get; } = 4;
        public int MinIntelligence { get; } = 2;
        public int Damage { get; } = 4;
        public WeaponType WeaponType { get; } = WeaponType.Melee;
    }
}