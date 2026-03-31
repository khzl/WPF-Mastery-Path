using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace WPF.BootCamps.Services.Interfaces
{
    public interface IDialogService
    {
        // Contracts 
        public void ShowMessage(string message,string title);
        public bool ShowConfirmation(string message, string title);
        public void ShowDialog(Window dialog);
    }
}
