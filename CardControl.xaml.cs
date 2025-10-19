using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// Interaction logic for CardPage.xaml
    /// </summary>
    public partial class CardControl : UserControl
    {
        public CardControl()
        {
            InitializeComponent();
        }
        public CardControl(string text1, string text2)
        {
            InitializeComponent();
            TextBlock1.Text = text1;
            TextBlock2.Text = text2;
        }
    }
}
