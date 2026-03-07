using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF.BootCamps.UserControls
{
    /// <summary>
    /// Interaction logic for StatisticCardCompnent.xaml
    /// </summary>
    public partial class StatisticCardCompnent : UserControl
    {
        public StatisticCardCompnent()
        {
            InitializeComponent();
        }

        // Dependency Properties
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register(
                "Title",
                typeof(string),
                typeof(StatisticCardCompnent),
                new PropertyMetadata("Title"));

        // public properties
        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register(
                "Value",
                typeof(string),
                typeof(StatisticCardCompnent),
                new PropertyMetadata("0"));

        public string Value
        {
            get => (string)GetValue(ValueProperty);
            set => SetValue(ValueProperty, value);
        }
    }
}
