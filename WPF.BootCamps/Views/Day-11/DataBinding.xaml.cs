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

namespace WPF.BootCamps.Views.Day_11
{
    /// <summary>
    /// Interaction logic for DataBinding.xaml
    /// </summary>
    public partial class DataBinding : Window
    {
        public DataBinding()
        {
            InitializeComponent();
            this.DataContext = new Person();
        }

        public class Person
        {
            // Properties 
            public string? Name { get; set; } = "Khazaal";
        }
    }
}
