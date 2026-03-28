using System;
using System.Collections.Generic;
using System.IO.Pipelines;
using System.Text;
using System.Windows.Input;
using WPF.BootCamps.Helpers;
using WPF.BootCamps.Services;

namespace WPF.BootCamps.ViewModels
{
    public class MainUserViewModel : BaseViewModel
    {
        // private field 
        private readonly UserService _userService;
        private readonly LoggerService logger;

        // public property 
        public string? UserName { get; set; }

        // Command
        public ICommand? TestCommand { get; }

        // public Constructor (Constructor Injections)
        public MainUserViewModel(UserService userService, LoggerService logger)
        {
            this._userService = userService;

            this.logger = logger;

            UserName = userService.GetUserName();

            TestCommand = new RelayCommand(_ =>
            {
                logger.Log("Button Clicked!");
            });
        }

    }
}
