﻿using RPG13.Weapon.Interfaces;

namespace RPG13.Weapon
{
    public class Dagger : IMeleeWeapon
    {
        public string Name { get; } = "Dagger";
        public int MinStrength { get; } = 1;
        public int MinIntelligence { get; } = 1;
        public int Damage { get; } = 2;
        public WeaponType WeaponType { get; } = WeaponType.Melee;
    }
}