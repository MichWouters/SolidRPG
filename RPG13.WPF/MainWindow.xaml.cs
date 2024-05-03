using Microsoft.Extensions.DependencyInjection;
using RPG13.Business.Player;
using RPG13.Business;
using System.Windows;
using RPG13.Business.Logging;

namespace RPG13.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, ILogger
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public string Log(string message)
        {
            txtLog.AppendText(message);
            txtLog.ScrollToEnd();
            txtLog.UpdateLayout();
            return message;
        }

        public void LogEmptyLine()
        {
           
        }

        public void LogError(string message)
        {
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // 4. Better way using a Dependency Injection framework
            ServiceCollection serviceCollection = new Startup().RegisterServices();
            ServiceProvider provider = serviceCollection.BuildServiceProvider();
            IGame game = provider.GetService<IGame>();

            game.StartGame();
            IPlayer player = game.CreatePlayer();
            game.CreateAndEquipDefaultWeapon(player);
            game.StartEncounter(player);
            game.EndGame(player);
        }
    }
}