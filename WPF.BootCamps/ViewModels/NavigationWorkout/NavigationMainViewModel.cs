//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Windows.Input;
//using WPF.BootCamps.Helpers;
//using WPF.BootCamps.ViewModels.Service;

//namespace WPF.BootCamps.ViewModels.NavigationWorkout
//{
//    public class NavigationMainViewModel : BaseViewModel
//    {

//        // Service Navigate To
//        public NavigationService Navigation { get; } // ReadOnly

//        // Commands
//        public ICommand? ShowDashboardCommand { get; } // ReadOnly
//        public ICommand? ShowReportsCommand { get; } // ReadOnly
//        public ICommand? ShowSettingsCommand { get; } // ReadOnly


//        // public Constructor
//        public NavigationMainViewModel()
//        {
//            // Navigation
//            Navigation = new NavigationService();

//            ShowDashboardCommand = new RelayCommand(_ => Navigation.NavigateTo(new DashboardViewModel()));
//            ShowReportsCommand = new RelayCommand(_ => Navigation.NavigateTo(new ReportsViewModel()));
//            ShowSettingsCommand = new RelayCommand(_ => Navigation.NavigateTo(new SettingsViewModel()));

//            // Begin 
//            Navigation.NavigateTo(new DashboardViewModel());
//        }
//    }
//}
