using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using WPF.BootCamps.Helpers;
using WPF.BootCamps.Services.Interfaces;

namespace WPF.BootCamps.ViewModels
{
    // Sidebar + Commands
    public class MainNavigationViewModel
    {
        // private field 
        private readonly INavigationService? _navigationService;

        // public Property 
        public INavigationService? NavigationService => _navigationService;

        // Command
        public ICommand? ShowDashboardCommand { get; } // ReadOnly
        public ICommand? ShowOrdersCommand { get; } // ReadOnly
        public ICommand? ShowCustomersCommand { get; } // ReadOnly

        // public Constructor (Constructor Injections)
        public MainNavigationViewModel(INavigationService navigationService)
        {
            this._navigationService = navigationService;

            ShowDashboardCommand = new RelayCommand(_ =>
            navigationService.NavigateTo<DashboardViewModel>());

            ShowOrdersCommand = new RelayCommand(_ =>
            navigationService.NavigateTo<OrdersViewModel>());

            ShowCustomersCommand = new RelayCommand(_ =>
            navigationService.NavigateTo<CustomersViewModel>());

            // Begin
            navigationService.NavigateTo<DashboardViewModel>();
        }
    }
}
