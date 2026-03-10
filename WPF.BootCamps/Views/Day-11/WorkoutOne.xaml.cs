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
    /// Interaction logic for WorkoutOne.xaml
    /// </summary>
    public partial class WorkoutOne : Window
    {
        public WorkoutOne()
        {
            InitializeComponent();
            // Code Behind To Test Binging Using DataContext
            DataContext = new Person
            {
                Name = "Khazaal",
                Age = 24
            };
        }

        // create Person Class and Binding With TextBox And TextBlock
        // class Person
        // حتى يحدث التحديث مباشرة في الواجهة يجب استخدام INotifyPropertyChanged
        public class Person : INotifyPropertyChanged
        {
            // private property 
            private string? _name;
            private int _age;

            // public property
            public string Name
            {
                get
                {
                    return _name ?? (_name = this.GetType().Name);
                }
                set
                {
                    _name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }

            public int Age
            {
                get
                {
                    return _age;
                }
                set
                {
                    _age = value;
                    OnPropertyChanged(nameof(Age));
                }
            }

            // Event Handler 
            public event PropertyChangedEventHandler? PropertyChanged;

            protected void OnPropertyChanged(string propertyName)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
