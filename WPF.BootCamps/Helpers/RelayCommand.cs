using System;
using System.Windows.Input;

namespace WPF.BootCamps.Helpers
{
    public class RelayCommand : ICommand
    {
        // هذا كافي لبناء اي امر 
        // private fields
        private readonly Action<object?> _execute;
        private readonly Func<object?,bool>? _canExecute;

        public RelayCommand(Action<object?> execute, Func<object?,bool>? canExecute = null)
        {
            // Validate to ensure execute is never null
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        // Forward CanExecuteChanged to CommandManager.RequerySuggested.
        // Suppress CA1822 because this must be an instance event to satisfy ICommand.
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "Implements ICommand; add/remove must be instance.")]
        public event EventHandler? CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        // Match ICommand.CanExecute signature with nullable parameter
        public bool CanExecute(object? parameter) => _canExecute == null || _canExecute(parameter);

        // Match ICommand.Execute signature with nullable parameter
        public void Execute(object? parameter) => _execute(parameter);

    }
}
