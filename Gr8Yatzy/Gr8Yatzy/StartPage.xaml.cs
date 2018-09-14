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

        Yatzy yatzy = new Yatzy();
        
        private void btnTest_Click(object sender, RoutedEventArgs e)
        {
            yatzy.RollDices();
        }

        private void btnStartGame_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new GameBoard());


            //nav.Navigate(new Uri("GameBoard.xaml", UriKind.RelativeOrAbsolute));
        }
    }



}
