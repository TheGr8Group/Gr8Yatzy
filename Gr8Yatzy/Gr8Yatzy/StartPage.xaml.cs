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

namespace Gr8Yatzy
{
    /// <summary>
    /// Interaction logic for StartPage.xaml
    /// </summary>
    public partial class StartPage : Page
    {
        public StartPage()
        {
            InitializeComponent();
        }

        //Yatzy yatzy = new Yatzy();
        //YatzyRules yr = new YatzyRules();
        //Calculations c = new Calculations();

        private List<Player> AddPlayerProtocols(/*List<Player> players*/)
        {
            // Flyttade koden under knappen hit. Behöver clickeventet // Annica
            List<Player> players = new List<Player>();
            Player p;
            p = new Player() { NickName = "Maestro126" };
            players.Add(p);
            p = new Player() { NickName = "Annica" };
            players.Add(p);
            p = new Player() { NickName = "Giza" };
            players.Add(p);
            p = new Player() { NickName = "Kristian" };
            players.Add(p);
            return players;
            //foreach (Player p in players)
            //{
            //    p.PlayerProtocol protocol = 
            //}
        }
        Yatzy yatzy;
        YatzyRules yr = new YatzyRules();
        Calculations c = new Calculations();

        private Yatzy CreateGame()
        {
            yatzy = new Yatzy
            {
                GameID = 1,
                Rolls = 3,
                Players = AddPlayerProtocols()

            };
            return yatzy;
        }


        private void btnTest_Click(object sender, RoutedEventArgs e)
        {
            //yatzy.RollDices();
            //yr.ValidateYatzyRule();
            //yatzy = c.SetUpperSum();



        }

        private void btnStartGame_Click(object sender, RoutedEventArgs e)
        {
            yatzy = CreateGame();

            this.NavigationService.Navigate(new GameBoard(yatzy));


            //nav.Navigate(new Uri("GameBoard.xaml", UriKind.RelativeOrAbsolute));
        }
    }



}
