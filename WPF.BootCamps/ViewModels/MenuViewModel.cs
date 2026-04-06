using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using WPF.BootCamps.Helpers;
using WPF.BootCamps.Services.Interfaces;


namespace WPF.BootCamps.ViewModels
{
    public class MenuViewModel
    {
        // private field 
        private readonly INavigationService _navigationService;

        // Command 
        public ICommand? DashboardCommand { get; } // ReadOnly

        // public Constructor (Constructor Injections)
        public MenuViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            DashboardCommand = new RelayCommand(_ =>
            {
                _navigationService.Navigate<DashboardViewModel>();
            });
        }
        /*
         الآن ViewModel لا يعرف شيئًا عن DashboardView.
         فقط يقول:
         “اذهب إلى DashboardViewModel”.
         وهذا فصل معماري نظيف جدًا.
         */
    }
}
