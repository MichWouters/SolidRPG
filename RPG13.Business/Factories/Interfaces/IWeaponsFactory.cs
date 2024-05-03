using RPG13.Business.Weapon;
using RPG13.Business.Weapon.Interfaces;

namespace RPG13.Business.Factories.Interfaces
{
    public interface IWeaponsFactory
    {
        IWeapon GetRandomLoot(int maxLootLevel);

        IWeapon GetWeapon(WeaponEnum type);
    }
}