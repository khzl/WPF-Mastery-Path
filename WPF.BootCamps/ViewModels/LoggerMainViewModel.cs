using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using WPF.BootCamps.Helpers;
using WPF.BootCamps.Services;

namespace WPF.BootCamps.ViewModels
{
    public class LoggerMainViewModel : BaseViewModel
    {
        // private field 
        private readonly LoggerService _loggerService;

        // Command
        public ICommand? TestCommand { get; } // ReadOnly

        // public Constructor (constructor Injections)
        public LoggerMainViewModel(LoggerService loggerService)
        {
            this._loggerService = loggerService;
            TestCommand = new RelayCommand(_ =>
            {
                loggerService.Log("Button Clicked..!");
            });
        }

    }
}
