using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF.BootCamps.Views.Day_11
{
    /// <summary>
    /// Interaction logic for DataBindingExampleTwo.xaml
    /// </summary>
    public partial class DataBindingExampleTwo : Window
    {
        public DataBindingExampleTwo()
        {
            InitializeComponent();
            // Call Binding Property Inside DataContext
            this.DataContext = new Person();
        }

        // InotifyPropertyChanged يعطي اشعار لل WPF انه الخاصية property تغيرت قيمتها فحدث الواجهة بعد التغيير
        public class Person : INotifyPropertyChanged
        {
            // private property 
            // Fixed: initialize backing field to a non-null value to satisfy non-nullable property getter
            private string _name = string.Empty;

            // public property 
            public string Name
            {
                get => _name;
                set
                {
                    _name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }

            // Event Handler 
            public event PropertyChangedEventHandler? PropertyChanged;

            protected void OnPropertyChanged(string propertyName)
            {
                PropertyChanged?.Invoke(this,
                    new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
