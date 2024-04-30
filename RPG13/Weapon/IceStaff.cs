using RPG13.Weapon.Interfaces;

namespace RPG13.Weapon
{
    public class IceStaff : IRangedWeapon
    {

        public string Name { get; } = "Ice Staff. Brrr";
        public int Damage => 6;

        public int MinIntelligence => 7;

        public int MinStrength => 2;

        public WeaponType WeaponType => WeaponType.Ranged;
    }
}