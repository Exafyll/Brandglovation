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

namespace ProjectArbeteBrädspel
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

        private void Throw_Dice_Button_Click(object sender, RoutedEventArgs e)
        {
            var rnd = new Random();
            int dieThrow = rnd.Next(1, 7);
            string path = "/Images/Dice/Dice" + dieThrow + ".png";
            Die.Source = new BitmapImage(new Uri(@path, UriKind.RelativeOrAbsolute));
        }




    }
}
