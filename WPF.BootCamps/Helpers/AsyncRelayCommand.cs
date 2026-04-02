using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace WPF.BootCamps.Helpers
{
    public class AsyncRelayCommand : ICommand
    {
        // private field 
        private readonly Func<Task> _execute;

        // public Constructor (Constructor Injection)
        public AsyncRelayCommand(Func<Task> execute)
        {
            _execute = execute;
        }

        public bool CanExecute(object? parameter) => true;

        public async void Execute(object? parameter)
        {
            await _execute();
        }

        public event EventHandler? CanExecuteChanged;

    }
}
