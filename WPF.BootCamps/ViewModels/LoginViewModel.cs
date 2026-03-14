using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Input;
using WPF.BootCamps.Helpers;

namespace WPF.BootCamps.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        // private property 
        private string? username;
        private string? password;

        // public Property
        public string? UserName
        {
            get => username;
            set
            {
                username = value;
                OnPropertyChanged(nameof(UserName));
            }
        }

        public string? Password
        {
            get => password;
            set
            {
                password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        // Command
        public ICommand? LoginCommand { get; } // ReadOnly

        // public Constructor 
        public LoginViewModel()
        {
            // adapt parameterless methods to the expected delegate signatures
            LoginCommand = new RelayCommand(_ => Login(), _ => CanLogin());
        }

        // Private Login
        private void Login()
        {
            MessageBox.Show($"Welocme {username}");
        }

        // private CanLogin
        private bool CanLogin()
        {
            return !string.IsNullOrWhiteSpace(UserName)
                && !string.IsNullOrWhiteSpace(Password);
        }

        // Event Handler 
        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
