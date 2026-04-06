using System.Configuration;
using System.Data;
using System.Windows;
using YourApp.ProjectArchitecture.Services.Data;
using YourApp.ProjectArchitecture.Services.Dialog;
using YourApp.ProjectArchitecture.Services.Navigation;
using YourApp.ProjectArchitecture.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace YourApp.ProjectArchitecture
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application // اربط كلشيء في هذا الملف 
    {
        public static IServiceProvider? ServiceProvider { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // dialogService
            var dialogService = new DialogService();

            // Create Factory  حسب نوع ViewModel
            var navigationService = new NavigationService(viewModelType =>
            {
                if (viewModelType == typeof(DashboardViewModel))
                    return new DashboardViewModel();
                if (viewModelType == typeof(OrdersViewModel))
                    return new OrdersViewModel(dialogService); // here Injection
                if (viewModelType == typeof(SettingsViewModel))
                    return new SettingsViewModel();

                throw new InvalidOperationException($"Unknown ViewModel: {viewModelType.Name}");
            });

            var mainViewModel = new MainViewModel(navigationService);

            var mainWindow = new MainWindow
            {
                DataContext = mainViewModel // هنا يصير الربط
            };

            mainWindow.Show();

            //var services = new ServiceCollection();

            //ConfigureServices(services);

            //ServiceProvider = services.BuildServiceProvider();

            //var window = ServiceProvider.GetRequiredService<MainWindow>();
            //window.DataContext = ServiceProvider.GetRequiredService<MainViewModel>();
            //window.Show();
        }

        //private void ConfigureServices(ServiceCollection services)
        //{
        //    // Register Views Here 
        //    services.AddSingleton<MainWindow>();

        //    // Register ViewModels here 
        //    services.AddSingleton<MainViewModel>();
        //    services.AddTransient<DashboardViewModel>();
        //    services.AddTransient<OrdersViewModel>();
        //    services.AddTransient<SettingsViewModel>();

        //    // Register Service Here 
        //    //services.AddSingleton<INavigationService, NavigationService>();
        //    //services.AddSingleton<IDialogService, DialogService>();

        //}
    }

}
