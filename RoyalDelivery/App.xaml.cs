using Microsoft.Extensions.DependencyInjection;
using RoyalDelivery.ViewModels;
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
            // ViewModels
            services.AddSingleton<MainWindowViewModel>();
            services.AddTransient<RestaurantViewModel>();
            services.AddTransient<MealViewModel>();
            services.AddTransient<OrderViewModel>();
            services.AddTransient<UserViewModel>();

            // Views
            services.AddSingleton<MainWindow>();

            // Services & Repositories (example)
            // services.AddSingleton<IMessageRepository, MessageRepository>();
        }
    }

}
