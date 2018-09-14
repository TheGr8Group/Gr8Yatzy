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
    /// Interaction logic for GameBoard.xaml
    /// </summary>
    public partial class GameBoard : Page
    {
        public GameBoard()
        {
            InitializeComponent();

        }
        private void AddPlayerProtocols(List<Player> players)
        {
            
            //foreach (Player p in players)
            //{
            //    p.PlayerProtocol protocol = 
            //}
        }
        
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
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

        }
    }
}
