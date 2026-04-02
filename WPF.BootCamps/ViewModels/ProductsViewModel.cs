using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using System.Threading.Tasks;
using WPF.BootCamps.Helpers;

namespace WPF.BootCamps.ViewModels
{
    public class ProductsViewModel : INotifyPropertyChanged
    {
        // backing field for Products
        private ObservableCollection<string>? _products;
        public ObservableCollection<string>? Products
        {
            get => _products;
            set
            {
                if (_products != value)
                {
                    _products = value;
                    OnPropertyChanged(nameof(Products));
                }
            }
        }

        // Loading Indicator 
        private bool _isLoading;
        public bool IsLoading
        {
            get => _isLoading;
            set
            {
                _isLoading = true;
                OnPropertyChanged(nameof(IsLoading));
            }
        }

        // Command
        public ICommand? LoadCommand { get; }

        // INotifyPropertyChanged implementation
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string? propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // public Constructor 
        public ProductsViewModel()
        {
            Products = new ObservableCollection<string>();

            LoadCommand = new AsyncRelayCommand(() => LoadProducts());
        }

        private async Task LoadProducts()
        {
            await Task.Delay(2000); // simulate API

            Products?.Add("Laptop");
            Products?.Add("Mouse");
        }
    }
}
