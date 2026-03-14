using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using WPF.BootCamps.Helpers;

namespace WPF.BootCamps.ViewModels
{
    public class NumberViewModel : INotifyPropertyChanged
    {
        // private field 
        private int _selectedNumber;

        // public property
        public int SelectedNumber
        {
            get => _selectedNumber;
            set
            {
                _selectedNumber = value;
                OnPropertyChanged(nameof(SelectedNumber));
            }
        }

        // Command
        public ICommand? SelectNumberCommand { get; } // ReadOnly

        // public Constructor
        public NumberViewModel()
        {
            SelectNumberCommand = new RelayCommand(SetNumber);
        }

        // SetNumber
        private void SetNumber(object? parameter)
        {
            // Guard against null parameter
            if (parameter == null)
                return;

            // Get safe string representation
            var s = parameter as string ?? parameter.ToString();

            // Protect against null or empty string from ToString implementations
            if (string.IsNullOrWhiteSpace(s))
                return;

            // Use TryParse to avoid exceptions and null argument issues
            if (int.TryParse(s, out var value))
            {
                SelectedNumber = value;
            }
        }

        // Event Handler 
        public event PropertyChangedEventHandler? PropertyChanged;

        // OnPropertyChanged
        private void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
