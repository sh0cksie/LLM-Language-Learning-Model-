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
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            if (!Properties.Settings.Default.IsFirstLaunch)
            {
                FirstLaunchWindow firstLaunchWindow = new FirstLaunchWindow();
                firstLaunchWindow.Owner = this;
                bool? result = firstLaunchWindow.ShowDialog();

                if (result == true)
                {
                    Properties.Settings.Default.IsFirstLaunch = true;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void PopUP(object sender, RoutedEventArgs e)
        {
            AddWordWindow addWindow1 = new AddWordWindow();
            addWindow1.ShowDialog();
        }

        private void Button_Click()
        {

        }
    }
}