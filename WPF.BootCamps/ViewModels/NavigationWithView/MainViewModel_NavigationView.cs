//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Text;
//using System.Windows.Input;
//using WPF.BootCamps.Helpers;

//namespace WPF.BootCamps.ViewModels.NavigationWithView
//{
//    public class MainViewModel_NavigationView : INotifyPropertyChanged
//    {
//        // private field 
//        private object? _currentView;

//        // public property
//        public object? CurrentView
//        {
//            get => _currentView;
//            set
//            {
//                _currentView = value;
//                OnPropertyChanged(nameof(CurrentView));
//            }
//        }

//        // Command
//        public ICommand? ShowHomeCommand { get; } // ReadOnly
//        public ICommand? ShowSettingsCommand { get; } // ReadOnly

//        // public Constructor
//        public MainViewModel_NavigationView()
//        {
//            ShowHomeCommand = new RelayCommand((object? _) =>
//                CurrentView = new HomeViewModel());

//            ShowSettingsCommand = new RelayCommand((object? _) =>
//                CurrentView = new SettingsViewModel());

//            // By Default 
//            CurrentView = new HomeViewModel();
//        }

//        // Event Handler 
//        public event PropertyChangedEventHandler? PropertyChanged;

//        protected void OnPropertyChanged(string name) =>
//            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
//    }
//}
