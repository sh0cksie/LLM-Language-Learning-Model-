using Baseapp.Resources;
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

namespace Baseapp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new MainPage());
        }


        private void PopUP(object sender, RoutedEventArgs e)
        {
            AddWordWindow addWindow1 = new AddWordWindow();
            addWindow1.Show();
        }

        private void TamirPopUp(object sender, RoutedEventArgs e)
        {
            TamirWindow addWindow2 = new TamirWindow();
            addWindow2.Show();
        }
    }
}