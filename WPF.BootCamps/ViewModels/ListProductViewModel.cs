using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using WPF.BootCamps.Helpers;
using WPF.BootCamps.Models;

namespace WPF.BootCamps.ViewModels
{
    public class ListProductViewModel
    {
        // Property Products 
        public ObservableCollection<md_Product_PL>? Products { get; set; }

        // Command
        public ICommand? AddCommand { get; } // ReadOnly
        public ICommand? RemoveCommand { get; } // ReadOnly

        // private field
        private int _counter = 1;

        // public Constructor
        public ListProductViewModel()
        {
            Products = new ObservableCollection<md_Product_PL>();

            // Create and add a md_Product_PL instead of adding a string.
            AddCommand = new RelayCommand(_ =>
            {
                var product = new md_Product_PL
                {
                    Name = $"Product {_counter++}",
                    Price = null
                };
                Products.Add(product);
            });
            RemoveCommand = new RelayCommand(item =>
            {
                if (item is md_Product_PL product)
                {
                    Products.Remove(product);
                }
            });
        }
    }
}
