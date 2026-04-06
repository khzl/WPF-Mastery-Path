using System;
using System.Collections.Generic;
using System.Text;

namespace YourApp.ProjectArchitecture.Services.Dialog
{
    public interface IDialogService
    {
        // Open Dialog and return Result
        public string? ShowAddOrderDialog();

        // for public message 
        public void ShowMessage(string message, string title = "Info");
        public bool ShowConfirmation(string message, string title = "Confirm");
    }
}
