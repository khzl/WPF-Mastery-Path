using System;
using System.Windows.Input;

namespace WPF.BootCamps.Helpers
{
    public class RelayCommand : ICommand
    {
        // private field (non-nullable)
        private readonly Action execute;

        public RelayCommand(Action execute)
        {
            // Validate to ensure execute is never null
            this.execute = execute ?? throw new ArgumentNullException(nameof(execute));
        }

        // Event Handler 
        public event EventHandler? CanExecuteChanged;

        // Match ICommand.CanExecute signature with nullable parameter
        public bool CanExecute(object? parameter) => true;

        // Match ICommand.Execute signature with nullable parameter
        public void Execute(object? parameter)
        {
            execute();
        }
    }
}
