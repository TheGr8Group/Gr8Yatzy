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

        private void btnTest_Click(object sender, RoutedEventArgs e)
        {
            //foreach (var item in arr)
            //{
            //    dices.Add(new Dice());
            //}

            //Random random = new Random();

            //foreach (Dice d in dices)
            //{
            //    d.Value = random.Next(1, 7);
            //    //MessageBox.Show(d.Value.ToString());
            //}

            //Yatzy yatzy = new Yatzy();

            //Random random = new Random();
            //yatzy.Dices = new int[5];

            //for (int i = 0; i < yatzy.Dices.Length; i++)
            //{
            //    yatzy.Dices[i] = random.Next(1, 7);
            //}

            //foreach (var item in yatzy.Dices)
            //{
            //    lstBoxTest.Items.Add(item);
            //}

            Yatzy yatzy = new Yatzy();

            Random random = new Random();
            yatzy.Dices = new int[5];

            for (int i = 0; i < yatzy.Dices.Length; i++)
            {
                yatzy.Dices[i] = random.Next(1, 7);
            }

            foreach (var item in yatzy.Dices)
            {
                lstPlayers.Items.Add(item);
            }
        }

        private void btnStartGame_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new GameBoard());


            //nav.Navigate(new Uri("GameBoard.xaml", UriKind.RelativeOrAbsolute));
        }
    }


    
}
