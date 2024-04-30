namespace RPG13.Enemies
{
    public class Goblin : Enemy
    {
        public Goblin(): base("Max the goblin")
        {
            Health = 20;
            MinDamage = 3;
            MaxDamage = 5;
        }
    }
}