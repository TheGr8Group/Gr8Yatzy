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
        public GameBoard(Yatzy yatzy)
        {
            InitializeComponent();
            this.yatzy = yatzy;

        }
        Yatzy yatzy;
        Player p = new Player();
        YatzyRules yr = new YatzyRules();

        private int[] RollDices()
        {
            int[] dices = yatzy.SetDiceValue();
            return dices;
        }


        private void btnRollDices_Click(object sender, RoutedEventArgs e)
        {
            //SetDiceValue();//Test
            //PrintDices(); //Test
            PrintDiceValue(RollDices());
            p = yr.ValidateYatzyRule();
            SetBorderBrush(p);
            SaveDices();

            //yatzy = CreateGame();//Test
        }

        //Metod för att skriva ut tärningarnas värde i gränssnittet
        // hej hopp gummi...
        private void PrintDiceValue(int[] dices)
        {
            dice1.Content = dices[0];
            dice2.Content = dices[1];
            dice3.Content = dices[2];
            dice4.Content = dices[3];
            dice5.Content = dices[4];
        }

        /// <summary>
        /// Kontrollerar om det är möjligt att föra in det slagna värdet i textboxen och markerar bordern grön
        /// </summary>
        /// <param name="p"></param>
        private void SetBorderBrush(Player p)
        {

            if (p.PlayerProtocol.IsOnes)
            {
                txtBoxOnes.BorderBrush = System.Windows.Media.Brushes.Green;
            }
            if (p.PlayerProtocol.IsTwos)
            {
                txtBoxTwos.BorderBrush = System.Windows.Media.Brushes.Green;
            }
            if (p.PlayerProtocol.IsThrees)
            {
                txtBoxThrees.BorderBrush = System.Windows.Media.Brushes.Green;
            }
            if (p.PlayerProtocol.IsFours)
            {
                txtBoxFours.BorderBrush = System.Windows.Media.Brushes.Green;
            }
             if (p.PlayerProtocol.IsFives)
            {
                txtBoxFives.BorderBrush = System.Windows.Media.Brushes.Green;
            }
             if (p.PlayerProtocol.IsSixes)
            {
                txtBoxSixes.BorderBrush = System.Windows.Media.Brushes.Green;
            }

        }

        private void SaveDices()
        {
            var controls = new List<CheckBox>();

            controls.Add(dice1);
            controls.Add(dice1);
            controls.Add(dice2);
            controls.Add(dice3);
            controls.Add(dice4);

            yatzy.CheckIfSaved(controls);
        }

        
    }
}
