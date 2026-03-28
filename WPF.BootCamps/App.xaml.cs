using System.Configuration;
using System.Data;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using WPF.BootCamps.Services;
using WPF.BootCamps.ViewModels;

namespace WPF.BootCamps
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        // Create ServiceCollection 
        // Property 
        //public static IServiceProvider? ServiceProvider { get; private set; }

        //protected override void OnStartup(StartupEventArgs e)
        //{
        //    var services = new ServiceCollection();

        //    ConfigureServices(services);

        //    ServiceProvider = services.BuildServiceProvider();

        //    var window = ServiceProvider.GetRequiredService<MainWindow>();
        //    window.DataContext = ServiceProvider.GetRequiredService<MainViewModel>();
        //    window.Show();
        //}

        //private void ConfigureServices(ServiceCollection services)
        //{
        //    // Register Views Here 
        //    services.AddSingleton<MainWindow>();

        //    // Register ViewModels here 
        //    services.AddSingleton<MainViewModel>();

        //    // Register Service Here 
        //    services.AddSingleton<UserService>();
        //    services.AddSingleton<LoggerService>();
        //    services.AddSingleton<OrderService>();

        //}

    }

}
