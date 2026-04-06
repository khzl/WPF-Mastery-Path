using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace YourApp.ProjectArchitecture.Helper
{
    public class BaseViewModel
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
