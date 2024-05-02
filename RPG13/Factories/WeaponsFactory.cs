using RPG13.Factories.Interfaces;
using RPG13.Weapon;
using RPG13.Weapon.Interfaces;

namespace RPG13.Factories
{
    public class WeaponsFactory : IWeaponsFactory
    {
        IWeapon IWeaponsFactory.GetRandomLoot(int maxLootLevel)
        {
            int selectedLoot = new Random().Next(maxLootLevel);

            switch (selectedLoot)
            {
                case 0:
                    return new Dagger();

                case 1:
                    return new Spear();

                case 2:
                    return new Sword();

                case 3:
                    return new IceStaff();

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        IWeapon IWeaponsFactory.GetWeapon(WeaponEnum type)
        {
            switch (type)
            {
                case WeaponEnum.Dagger:
                    return new Dagger();

                case WeaponEnum.Spear:
                    return new Spear();

                case WeaponEnum.Sword:
                    return new Sword();

                case WeaponEnum.IceStaff:
                    return new IceStaff();

                default: throw new ArgumentOutOfRangeException();
            }
        }
    }
}