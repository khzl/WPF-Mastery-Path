using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using YourApp.ProjectArchitecture.Commands;
using YourApp.ProjectArchitecture.Services.Navigation;

namespace YourApp.ProjectArchitecture.ViewModels
{
    public class MainViewModel
    {
        // Navigation
        public INavigationService NavigationService { get; } // ReadOnly

        // Command 
        public ICommand? ShowDashboardCommand { get; } // ReadOnly
        public ICommand? ShowOrdersCommand { get; } // ReadOnly
        public ICommand? ShowSettingsCommand { get; } // ReadOnly

        // Constructor Injection
        public MainViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;

            ShowDashboardCommand = new RelayCommand(_ => navigationService.NavigateTo<DashboardViewModel>());
            ShowOrdersCommand = new RelayCommand(_ => navigationService.NavigateTo<OrdersViewModel>());
            ShowSettingsCommand = new RelayCommand(_ => navigationService.NavigateTo<SettingsViewModel>());

            navigationService.NavigateTo<DashboardViewModel>();
        }
    }
}
