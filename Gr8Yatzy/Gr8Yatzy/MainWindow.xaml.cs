﻿using System;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnRollDices_Click(object sender, RoutedEventArgs e)
        {
            int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            List<Dice> dices = new List<Dice>();

            foreach (var item in arr)
            {
                dices.Add(new Dice());
            }

            Random random = new Random();

            foreach (Dice d in dices)
            {
                d.Value = random.Next(1, 7);
                //MessageBox.Show(d.Value.ToString());
            }



        }
    }
}
