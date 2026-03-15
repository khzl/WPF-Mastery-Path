using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using WPF.BootCamps.Helpers;
using WPF.BootCamps.Models;

namespace WPF.BootCamps.ViewModels
{
    public class ProductViewModel : INotifyPropertyChanged
    {
        // List -> ObservableCollection 
        public ObservableCollection<md_Product_PL>? Products { get; set; } = new ObservableCollection<md_Product_PL>()
        {
            new md_Product_PL
            {
                Name = "Laptop",
                Price = 1200
            },
            new md_Product_PL
            {
                Name = "Phone",
                Price = 800
            },
            new md_Product_PL
            {
                Name = "Keyboard",
                Price = 100
            }
        };

        // private field 
        private md_Product_PL? _selectedProduct;

        // Property
        public md_Product_PL? SelectedProduct
        {
            get => _selectedProduct;
            set
            {
                _selectedProduct = value;
                OnPropertyChanged(nameof(SelectedProduct));
            }
        }

        // Event Handler
        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged(string name) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        // Command 
        public ICommand? DeleteCommand { get; } // ReadOnly

        // Constructor
        public ProductViewModel()
        {
            DeleteCommand = new RelayCommand(DeleteProduct);
        }

        // Delete Product
        private void DeleteProduct(object? obj)
        {
            if (obj is md_Product_PL product)
                Products?.Remove(product);
        }
    }
}
