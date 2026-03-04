using Microsoft.Extensions.DependencyInjection;
using RoyalDelivery.Models.DbMysqlModels;
using RoyalDelivery.Repos;
using RoyalDelivery.ViewModels;
using RoyalDelivery.ViewModels.Pages;
using System;
using System.Configuration;
using System.Data;
using System.Windows;

namespace RoyalDelivery
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            var services = new ServiceCollection();

            ConfigureServices(services);

            ServiceProvider = services.BuildServiceProvider();

            var mainWindow = ServiceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
        }

        private void ConfigureServices(ServiceCollection services)
        {
            // DbContext
            services.AddScoped<RoyaldeliveryDbContext>();

            // Repo
            services.AddSingleton<MealRepo>();
            services.AddSingleton<OrderRepo>();
            services.AddSingleton<RestaurantRepo>();
            services.AddSingleton<UserRepo>();

            // ViewModels
            services.AddSingleton<MainWindowViewModel>();
            services.AddTransient<RestaurantViewModel>();
            services.AddTransient<MealViewModel>();
            services.AddTransient<OrderViewModel>();
            services.AddTransient<UserViewModel>();
            services.AddTransient<SettingsViewModel>();
            services.AddTransient<HomeViewModel>();

            // Views
            services.AddSingleton<MainWindow>();

            // Services & Repositories (example)
            // services.AddSingleton<IMessageRepository, MessageRepository>();
        }
    }

}
