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
using WPF.BootCamps.Services.Interfaces;

namespace WPF.BootCamps.Views.Day_19
{
    /// <summary>
    /// Interaction logic for DialogService.xaml
    /// </summary>
    public partial class DialogService : Window
    {
        public DialogService()
        {
            InitializeComponent();
            var dialogService = new Services.DialogService(); // must implement IDialogService
            DataContext = new OrderViewModel(dialogService);
        }
    }
}
