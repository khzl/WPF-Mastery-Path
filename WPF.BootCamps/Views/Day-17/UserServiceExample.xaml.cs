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
    /// Interaction logic for UserServiceExample.xaml
    /// </summary>
    public partial class UserServiceExample : Window
    {
        public UserServiceExample()
        {
            InitializeComponent();
            // DataContext = new MainUserViewModel(); هذا الطريقة بعد لاتستخدمها 
            new MainUserViewModel(new UserService(), new LoggerService()); // بل استخدم هذه الطريقة الافضل 
        }
    }
}
