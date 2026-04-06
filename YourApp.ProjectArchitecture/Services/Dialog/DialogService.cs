using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using YourApp.ProjectArchitecture.Views.Dialogs;

namespace YourApp.ProjectArchitecture.Services.Dialog
{
    public class DialogService : IDialogService
    {
        public string? ShowAddOrderDialog()
        {
            var dialog = new AddOrderDialog
            {
                // يربط الـ Dialog بالـ Window الرئيسية
                Owner = Application.Current.MainWindow
            };

            // ShowDialog() يوقف التنفيذ لحد ما يتغلق الـ Dialog
            bool? result = dialog.ShowDialog();

            return result == true ? dialog.OrderName : null;
        }

        public void ShowMessage(string message, string title = "Info")
        {
            MessageBox.Show(message, title, MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public bool ShowConfirmation(string message, string title = "Confirm")
        {
            var result = MessageBox.Show(message, title, MessageBoxButton.YesNo, MessageBoxImage.Question);
            return result == MessageBoxResult.Yes;
        }
    }
}
