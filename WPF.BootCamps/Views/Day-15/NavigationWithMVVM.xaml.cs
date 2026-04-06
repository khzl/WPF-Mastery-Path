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


namespace WPF.BootCamps.Views.Day_15
{
    /// <summary>
    /// Interaction logic for NavigationWithMVVM.xaml
    /// </summary>
    public partial class NavigationWithMVVM : Window
    {
        public NavigationWithMVVM()
        {
            InitializeComponent();
            // link MainViewModel_NavigationView in this View Using DataContext
            //DataContext = new MainViewModel_NavigationView();
        }
    }
}
