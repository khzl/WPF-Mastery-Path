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
        private int _counter;

        // public property
        public int Counter
        {
            get => _counter;
            set
            {
                _counter = value;
                OnPropertyChanged(nameof(Counter));
            }
        }

        // Command 
        public ICommand? IncreaseCommand { get; } // ReadOnly
        public ICommand? DecreaseCommand { get; } // ReadOnly

        // public Constructor 
        public CounterViewModel()
        {
            IncreaseCommand = new RelayCommand(
                execute: _ => Counter++,
                canExecute: _ => Counter < 20);
            DecreaseCommand = new RelayCommand(
                execute: _ => Counter--,
                canExecute: _ => CanDecrease());
        }

        private bool CanDecrease()
        {
            return Counter > 0;
        }

        // private method for Increase
        //private void Increase()
        //{
        //    Counter++;
        //}

        //Event handler 
        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string name) => 
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
