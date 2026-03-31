using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using WPF.BootCamps.Services.Interfaces;

namespace WPF.BootCamps.Services
{
    public class DialogService : IDialogService
    {
        public void ShowMessage(string message, string title)
        {
            MessageBox.Show(message, title);
        }

        public bool ShowConfirmation(string message, string title)
        {
            var result = MessageBox.Show(
                message,
                title,
                MessageBoxButton.YesNo,
                MessageBoxImage.Question);

            return result == MessageBoxResult.Yes;
        }

        public void ShowDialog(Window dialog)
        {
            dialog.ShowDialog();
        }

    }
}
