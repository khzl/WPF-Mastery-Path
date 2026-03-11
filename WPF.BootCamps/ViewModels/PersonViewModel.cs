using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WPF.BootCamps.ViewModels
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        // private property 
        private string? firstName;
        private string? lastName;

        // public property 
        public string? FirstName
        {
            get => firstName;
            set
            {
                firstName = value;
                OnPropertyChanged(nameof(FirstName));
                OnPropertyChanged(nameof(FullName));
            }
        }

        public string? LastName
        {
            get => lastName;
            set
            {
                lastName = value;
                OnPropertyChanged(nameof(LastName));
                OnPropertyChanged(nameof(FullName));
            }
        }

        // public property محسوب 
        public string? FullName => $"{FirstName} {LastName}";

        // Even handler 
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
