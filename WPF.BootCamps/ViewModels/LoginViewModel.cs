using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

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

        // Event Handler 
        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
