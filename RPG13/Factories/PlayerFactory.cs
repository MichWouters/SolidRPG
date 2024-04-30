using RPG13.Factories.Interfaces;
using RPG13.Player;

namespace RPG13.Factories
{
    public class PlayerFactory : IPlayerFactory
    {
        public IPlayer Create(PlayerType playerType)
        {
            switch (playerType)
            {
                case PlayerType.Human:
                    return new Human("Gragnok the Barbarian");

                case PlayerType.Dwarf:
                    return new Dwarf("Mjolnir, the stout");

                case PlayerType.Elf:
                    return new Elf("Eljor, the wise");

                default:
                    throw new ArgumentOutOfRangeException(nameof(playerType));
            }
        }
    }
}