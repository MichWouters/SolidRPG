using Microsoft.Extensions.DependencyInjection;
using RPG13.Business.Logging;
using RPG13.Factories;
using RPG13.Factories.Interfaces;
using RPG13.Logging;
using RPG13.Service;
using RPG13.Services;

namespace RPG13
{
    public class Startup
    {
        // All dependencies are registered here
        public ServiceCollection RegisterServices()
        {
            ServiceCollection services = new ServiceCollection();
            services.AddScoped<ILogger, ConsoleLogger>();
            services.AddScoped<IDiceService, DiceService>();
            services.AddScoped<IPlayerFactory, PlayerFactory>();
            services.AddScoped<IWeaponsFactory, WeaponsFactory>();
            services.AddScoped<IRandomService, RandomService>();
            services.AddScoped<IEnemyFactory, EnemyFactory>();

            services.AddSingleton<IGame, Game>();

            return services;
        }
    }
}