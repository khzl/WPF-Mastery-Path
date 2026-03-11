using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Windows.Input;
using WPF.BootCamps.Helpers;

namespace WPF.BootCamps.ViewModels
{
    public class CounterViewModel : INotifyPropertyChanged
    {
        // private property 
        private int counter;

        // public property
        public int Counter
        {
            get => counter;
            set
            {
                counter = value;
                OnPropertyChanged(nameof(Counter));
            }
        }

        // Command 
        public ICommand? IncreaseCommand { get; } // ReadOnly

        // public Constructor 
        public CounterViewModel()
        {
            IncreaseCommand = new RelayCommand(Increase);
        }

        // private method for Increase
        private void Increase()
        {
            Counter++;
        }

        //Event handler 
        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
