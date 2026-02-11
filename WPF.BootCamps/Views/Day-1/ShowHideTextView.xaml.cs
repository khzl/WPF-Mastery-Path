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
using System.Windows.Shapes;

namespace WPF.BootCamps.Views
{
    /// <summary>
    /// Interaction logic for ShowHideTextView.xaml
    /// </summary>
    public partial class ShowHideTextView : Window
    {
        private bool isTextVisible = true;
        public ShowHideTextView()
        {
            InitializeComponent();
        }

        // Event Handler
        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            txtSecret.Visibility = Visibility.Visible;
            txtPlaceholder.Visibility = Visibility.Collapsed;
            UpdateStatus(true);
        }

        // Procedure 
        private void UpdateStatus(bool isVisible)
        {
            txtStatus.Text = isVisible ? "Status: Content Visible" : "Status: Content Hidden";
            statusDot.Fill = isVisible
                ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#22C55E") ?? Brushes.Green)
                : (SolidColorBrush)(new BrushConverter().ConvertFrom("#EF4444") ?? Brushes.Red);
        }

        // Event Handler
        private void BtnHide_Click(object sender, RoutedEventArgs e)
        {
            txtSecret.Visibility = Visibility.Collapsed;
            txtPlaceholder.Visibility = Visibility.Visible;
            UpdateStatus(false);
        }

        // Event handler
        private void BtnToggle_Click(object sender, RoutedEventArgs e)
        {
            //if (isTextVisible)
            //{
            //    HideText();
            //}
            //else
            //{
            //    ShowText();
            //}
        }
    }
}
