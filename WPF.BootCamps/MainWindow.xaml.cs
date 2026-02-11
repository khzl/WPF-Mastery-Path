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

namespace WPF.BootCamps
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        // Even Handler 
        private void btnClickMe_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Welcome In World WPF ..!", "Welcome", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}