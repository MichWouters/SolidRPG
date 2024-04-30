namespace RPG13.Services
{
    public interface IRandomService
    {
        bool RollForSuccess(int chanceOfSuccess);

        int GetRandomValue(int minDamage, int maxDamage);
    }
}