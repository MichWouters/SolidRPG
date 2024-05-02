namespace RPG13.Weapon.Interfaces
{
    public interface IWeapon
    {
        int Damage { get; }
        int MinIntelligence { get; }
        int MinStrength { get; }
        WeaponType WeaponType { get; }

        string Name { get; }
    }
}