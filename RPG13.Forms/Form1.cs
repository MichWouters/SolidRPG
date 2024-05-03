using RPG13.Business.Player;
using RPG13.Business;
using RPG13.WPF;
using System;
using RPG13.Business.Logging;
using Microsoft.Extensions.DependencyInjection;

namespace RPG13.Forms
{
    public partial class Form1 : Form, ILogger
    {
        private IGame game;

        public Form1()
        {
            InitializeComponent();

        }

        public string Log(string message)
        {
            txtLogging.Text += ($"{message}{Environment.NewLine}");
            return message;
        }

        public void LogEmptyLine()
        {
        }

        public void LogError(string message)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceCollection serviceCollection = new Startup().RegisterServices();
            ServiceProvider provider = serviceCollection.BuildServiceProvider();
            game = provider.GetService<IGame>();

            game.StartGame();
            IPlayer player = game.CreatePlayer();
            game.CreateAndEquipDefaultWeapon(player);
            game.StartEncounter(player);
            game.EndGame(player);
        }
    }
}