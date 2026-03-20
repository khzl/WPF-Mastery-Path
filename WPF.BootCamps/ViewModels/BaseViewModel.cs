using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WPF.BootCamps.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {

        // Event Handler 
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string name) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
