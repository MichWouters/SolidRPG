using RPG13.Weapon;
using RPG13.Weapon.Interfaces;

namespace RPG13.Factories.Interfaces
{
    public interface IWeaponsFactory
    {
        IWeapon GetRandomLoot(int maxLootLevel);
        IWeapon GetWeapon(WeaponEnum type);
    }
}