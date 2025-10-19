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
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();

            Deck deck = new Deck("tempdeck.csv");

            AddCard(deck.Cards);
        }

        public void AddCard(List<Card> _cards)
        {
            foreach (Card _card in _cards)
            {
                CardPanel.Children.Add(new CardControl(_card.Front, _card.Back));
            }
        }
    }
}
