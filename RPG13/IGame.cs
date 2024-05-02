using RPG13.Player;

namespace RPG13
{
    public interface IGame
    {
        void CreateAndEquipDefaultWeapon(IPlayer player);

        IPlayer CreatePlayer();

        void EndGame(IPlayer player);

        void StartEncounter(IPlayer player);

        void StartGame();
    }
}