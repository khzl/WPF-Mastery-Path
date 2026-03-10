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
using WPF.BootCamps.Models;

namespace WPF.BootCamps.Views.Day_11
{
    /// <summary>
    /// Interaction logic for WorkoutThree.xaml
    /// </summary>
    public partial class WorkoutThree : Window
    {
        // Calling Model And Create Objects
        Register user = new Register();

        public WorkoutThree()
        {
            InitializeComponent();
            DataContext = user; // Calling Object In DataContext
        }

        // Event Handler
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            resultText.Text =
                $"{user.FirstName} {user.LastName} - {user.Email}";
        }
    }
}
