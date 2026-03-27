using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WPF.BootCamps.ViewModels
{
    public class RegisterViewModel :BaseViewModel , IDataErrorInfo
    {
        // private field 
        private string? _email;
        private string? _password;

        // Public Property
        public string? Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        public string? Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public string Error => string.Empty;

        public string this[string columnName]
        {
            get
            {
                if(columnName == nameof(Email))
                {
                    if (string.IsNullOrWhiteSpace(Email))
                        return "Email is required";
                }
                if (columnName == nameof(Password))
                {
                    if (string.IsNullOrWhiteSpace(Password))
                        return "Password is required";
                }
                return string.Empty;
            }
        }

    }
}
