using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using WPF.BootCamps.Services;

namespace WPF.BootCamps.ViewModels
{
    public class MainViewModel : BaseViewModel , INotifyPropertyChanged
    {
        // private property
        private string? _name;
        private object? _currentView;
   

        // public property 
        public string? Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        // public Property
        public object? CurrentView
        {
            get => _currentView;
            set
            {
                if (_currentView == value) return;
                _currentView = value;
                OnPropertyChanged(nameof(CurrentView));
            }
        }

        // public Property
        public string? Time { get; } // ReadOnly

        // public Constructor
        public MainViewModel(TimeService timeService)
        {
            Time = timeService.GetCurrentTime();
        }
        // الـ ServiceContainer هو اللي يوفر الخدمة 


        // public Constructor 
        public MainViewModel() => Name = "Khazaal";
    }
}
