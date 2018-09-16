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
       
        private void RollDices()
        {
            int[] dices = yatzy.RollDices();
        }
        private void btnRollDices_Click(object sender, RoutedEventArgs e)
        {
            //RollDices();//Test
            //PrintDices(); //Test
            PrintDiceValue();
            //yatzy = CreateGame();//Test
        }
        private void PrintDiceValue()
        {
            int[] dices = yatzy.RollDices();

            dice1.Content = dices[0];
            dice2.Content = dices[1];
            dice3.Content = dices[2];
            dice4.Content = dices[3];
            dice5.Content = dices[4];
           

        }
        private List<CheckBox> SaveDices()
        {
            var controls = new List<CheckBox>();
            controls.Add(dice1);
            controls.Add(dice1);
            controls.Add(dice2);
            controls.Add(dice3);
            controls.Add(dice4);
            yatzy.CheckIfSaved(controls);
            return controls;
        }

        private void btnSpara_Click(object sender, RoutedEventArgs e)
        {
            SaveDices();
        }
    }
}
