using RPG13.Business.Weapon.Interfaces;

namespace RPG13.Business.Weapon
{
    public class Spear : IWeapon
    {
        public string Name { get; } = "Standard spear. Poky poky";
        public int MinStrength { get; } = 3;
        public int MinIntelligence { get; } = 2;
        public int Damage { get; } = 3;
        public WeaponType WeaponType { get; } = WeaponType.Melee;
    }
}