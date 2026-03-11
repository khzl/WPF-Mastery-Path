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

namespace WPF.BootCamps.Views.Day_12
{
    /// <summary>
    /// Interaction logic for PersonView.xaml
    /// </summary>
    public partial class PersonView : Window
    {
        public PersonView()
        {
            InitializeComponent();
            // ربط PersonViewModel
            // ربط ال ViewModel في الواجهة يكون عن طريق DataContext
            DataContext = new PersonViewModel(); 
        }
    }
}
