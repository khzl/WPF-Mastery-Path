using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using WPF.BootCamps.Helpers;

namespace WPF.BootCamps.ViewModels
{
    public class ToDoListViewModel : INotifyPropertyChanged
    {
        // ObservableCollection Property
        public ObservableCollection<string>? Todos { get; set; } = new ObservableCollection<string>();

        // private field 
        private string? _newTodo;

        // public property
        public string? NewTodo
        {
            get => _newTodo;
            set
            {
                _newTodo = value;
                OnPropertyChanged(nameof(NewTodo));
            }
        }

        // Command
        public ICommand? AddCommand { get; } // ReadOnly
        public ICommand? RemoveCommand { get; } // ReadOnly

        // Public Constructor
        public ToDoListViewModel()
        {
            AddCommand = new RelayCommand(AddTodo);
            RemoveCommand = new RelayCommand(RemoveTodo);
        }

        // Add ToDo
        private void AddTodo(object? obj)
        {
            if (!string.IsNullOrWhiteSpace(NewTodo))
            {
                Todos?.Add(NewTodo);
                NewTodo = "";
                OnPropertyChanged(nameof(NewTodo));
            }
        }

        // Remove ToDo
        private void RemoveTodo(object? obj)
        {
            if (obj is string item)
                Todos?.Remove(item);
        }

        // Event Handler 
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged(string name) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

    }
}
