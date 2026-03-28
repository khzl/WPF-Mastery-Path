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
using WPF.BootCamps.Services;
namespace WPF.BootCamps.Views.Day_17
{
    /// <summary>
    /// Interaction logic for LoggerExample.xaml
    /// </summary>
    public partial class LoggerExample : Window
    {
        public LoggerExample()
        {
            InitializeComponent();
            DataContext = new LoggerMainViewModel(new LoggerService());
        }
    }
}
