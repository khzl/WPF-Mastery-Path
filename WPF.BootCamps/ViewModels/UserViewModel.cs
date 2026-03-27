using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WPF.BootCamps.ViewModels
{
    public class UserViewModel : INotifyPropertyChanged , IDataErrorInfo
    {
        // private field 
        private string? _email;

        // public property
        public string? Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        public string Error => string.Empty;

        // Property IsAdmin 
        public bool IsAdmin { get; set; } = true;

        public string this[string columnName]
        {
            get
            {
                if (columnName == nameof(Email))
                {
                    if (string.IsNullOrWhiteSpace(Email))
                        return "Email is required";

                    if (!Email.Contains('@'))
                        return "Invalid email";
                }
                return string.Empty;
            }
        }

        // Event Handler 
        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged(string name) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

    }
}
