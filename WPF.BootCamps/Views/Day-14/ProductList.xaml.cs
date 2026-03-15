using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPF.BootCamps.ViewModels;

namespace WPF.BootCamps.Views.Day_14
{
    /// <summary>
    /// Interaction logic for ProductList.xaml
    /// </summary>
    public partial class ProductList : Window
    {
        public ProductList()
        {
            InitializeComponent();
            // link ProductViewModel in this view using DataContext
            DataContext = new ProductViewModel();
        }
    }
}
