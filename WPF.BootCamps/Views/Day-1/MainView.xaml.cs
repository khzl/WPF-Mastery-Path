using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();
            Loaded += MainView_Loaded;
        }

        // Event Handler 
        private void MainView_Loaded(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("تم تحميل النافذة الرئيسية");
            Console.WriteLine("رسالة في النافذة");
        }

        // Event Handler
        private void BtnOpenAbout_Click(object sender, RoutedEventArgs e)
        {
            AboutView aboutView = new AboutView();
            aboutView.Owner = this; // لجلعلها تابعة للنافذة الرئيسية
            aboutView.ShowDialog(); // نافذة مشروطة للمودل

        }

        // Event handler
        private void BtnOpenReport_Click(object sender, RoutedEventArgs e)
        {
            ReportView reportView = new ReportView();
            reportView.Owner = this;
            reportView.ShowDialog();
        }
    }
}
