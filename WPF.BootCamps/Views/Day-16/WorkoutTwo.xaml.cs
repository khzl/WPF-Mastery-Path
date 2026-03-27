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

namespace WPF.BootCamps.Views.Day_16
{
    /// <summary>
    /// Interaction logic for WorkoutTwo.xaml
    /// </summary>
    public partial class WorkoutTwo : Window
    {
        public WorkoutTwo()
        {
            InitializeComponent();
            DataContext = new RegisterViewModel();
        }
    }
}
