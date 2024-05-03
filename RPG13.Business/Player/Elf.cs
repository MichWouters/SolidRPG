using RPG13.Business.Logging;
using RPG13.Business.Service;

namespace RPG13.Business.Player
{
    public class Elf : Player
    {
        public Elf(IDiceService diceService, ILogger logger, string name) : base(diceService, logger, name)
        {
            Strength = _diceService.RollTheDices(1).Sum();
            Intelligence = _diceService.RollTheDices(3).Sum();
            Health = _diceService.RollTheDices(2).Sum();

            _logger.Log(this.ToString());
        }
    }
}