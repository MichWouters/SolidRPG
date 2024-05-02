using RPG13.Logging;
using RPG13.Service;

namespace RPG13.Player
{
    public class Human : Player
    {
        public Human(IDiceService diceService, ILogger logger, string name) : base(diceService, logger, name)
        {
            Strength = _diceService.RollTheDices().Sum();
            Intelligence = _diceService.RollTheDices().Sum();
            Health = _diceService.RollTheDices().Sum();

            _logger.Log(this.ToString());
        }
    }
}