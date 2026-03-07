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
    /// Interaction logic for SidebarItemComponent.xaml
    /// </summary>
    public partial class SidebarItemComponent : UserControl
    {
        public SidebarItemComponent()
        {
            InitializeComponent();
        }

        // Text property 
        // Dependency Properties 
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register(
                "Text",
                typeof(string),
                typeof(SidebarItemComponent),
                new PropertyMetadata("Menu"));

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        // Icon Property 
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register(
                "Icon",
                typeof(string),
                typeof(SidebarItemComponent),
                new PropertyMetadata("🏠"));

        public string Icon
        {
            get => (string)GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }

        // Is Active Property 
        public static readonly DependencyProperty IsActiveProperty =
            DependencyProperty.Register(
                "IsActive",
                typeof(bool),
                typeof(SidebarItemComponent),
                new PropertyMetadata(false));

        public bool IsActive
        {
            get => (bool)GetValue(IsActiveProperty);
            set => SetValue(IsActiveProperty, value);
        }
    }
}
