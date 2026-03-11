using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WPF.BootCamps.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        // private property
        private string? _name;

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

        // public Constructor 
        public MainViewModel() => Name = "Khazaal";

        // Event Handler (nullable to satisfy nullable reference checks)
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
