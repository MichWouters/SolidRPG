using RPG13.Business.Factories.Interfaces;
using RPG13.Business.Logging;
using RPG13.Business.Player;
using RPG13.Business.Service;

namespace RPG13.Business.Factories
{
    public class PlayerFactory : IPlayerFactory
    {
        private IDiceService diceService;
        private ILogger logger;

        public PlayerFactory(ILogger logger, IDiceService diceService)
        {
            this.logger = logger;
            this.diceService = diceService;
        }

        public IPlayer Create(PlayerType playerType)
        {
            switch (playerType)
            {
                case PlayerType.Human:
                    return new Human(diceService, logger, "Gragnok the Barbarian");

                case PlayerType.Dwarf:
                    return new Dwarf(diceService, logger, "Mjolnir, the stout");

                case PlayerType.Elf:
                    return new Elf(diceService, logger, "Eljor, the wise");

                default:
                    throw new ArgumentOutOfRangeException(nameof(playerType));
            }
        }
    }
}