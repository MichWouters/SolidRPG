namespace RPG13.Player
{
    public class Human : Player
    {
        public Human(string name) : base(name)
        {
            Strength = diceService.RollTheDices().Sum();
            Intelligence = diceService.RollTheDices().Sum();
            Health = diceService.RollTheDices().Sum();

            logger.Log(this.ToString());
        }
    }
}