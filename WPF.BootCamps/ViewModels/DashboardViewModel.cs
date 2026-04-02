using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using WPF.BootCamps.Helpers;
using System.Collections.ObjectModel;

namespace WPF.BootCamps.ViewModels
{
    public class DashboardViewModel : BaseViewModel
    {
        public string? Title => "Dashboard";

        // Progressive Loading
        public ObservableCollection<string> Items { get; set; } = new ObservableCollection<string>();

        // Loading Indicator 
        // private field 
        private bool _isLoading;

        // public property
        public bool IsLoading
        {
            get => _isLoading;
            set
            {
                _isLoading = value;
                OnPropertyChanged(nameof(IsLoading));
            }
        }

        // Command 
        public ICommand? LoadCommand { get; } // ReadOnly

        // Constructor (Constructor Injections)
        public DashboardViewModel()
        {
            LoadCommand = new AsyncRelayCommand(() => LoadAsync());
        }

        // Loaded Data 3 Second
        private async Task LoadAsync()
        {
            IsLoading = true;

            Items.Clear();

            for (int index = 1; index <= 5; index++)
            {
                await Task.Delay(5000); // Simulate API

                Items.Add($"Item {index}");
            }

            IsLoading = false;
        }
    }
}
