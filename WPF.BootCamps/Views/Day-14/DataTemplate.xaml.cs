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
    /// Interaction logic for DataTemplate.xaml
    /// </summary>
    public partial class DataTemplate : Window
    {
        public DataTemplate()
        {
            InitializeComponent();
            // ربط ListProductViewModel in this view using DataContext
            //DataContext = new ListProductViewModel();
        }
    }
}
