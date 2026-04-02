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

namespace WPF.BootCamps.Views.Day_20
{
    /// <summary>
    /// Interaction logic for WorkoutOne.xaml
    /// </summary>
    public partial class WorkoutOne : Window
    {
        public WorkoutOne()
        {
            InitializeComponent();
            DataContext = new DashboardViewModel();
        }
    }
}
