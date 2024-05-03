using RPG13.Business.Player;

namespace RPG13.Business
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