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
    /// Interaction logic for ProductCard.xaml
    /// </summary>
    public partial class ProductCard : UserControl
    {
        public ProductCard()
        {
            InitializeComponent();
        }

        // Register a DependencyProperty so XAML can set ProductName:
        public static readonly DependencyProperty ProductNameProperty =
            DependencyProperty.Register(
                nameof(ProductName),
                typeof(string),
                typeof(ProductCard),
                new PropertyMetadata(string.Empty));

        // CLR wrapper for the DependencyProperty
        public string ProductName
        {
            get => (string)GetValue(ProductNameProperty);
            set => SetValue(ProductNameProperty, value);
        }
    }
}
