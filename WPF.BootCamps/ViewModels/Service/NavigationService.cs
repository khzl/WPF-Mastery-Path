using System;
using System.Collections.Generic;
using System.Text;

namespace WPF.BootCamps.ViewModels.Service
{
    public class NavigationService : BaseViewModel
    {
        // private field 
        private object? _currentView;

        // public Property
        public object? CurrentView
        {
            get => _currentView;
            set
            {
                _currentView = value;
                OnPropertyChanged(nameof(CurrentView));
            }
        }

        // Navigation To انتقل الى الصفحة التالية
        public void NavigateTo(object? viewModel)
        {
            CurrentView = viewModel;
        }
    }
}
