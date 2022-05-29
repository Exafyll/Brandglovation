using ProjectArbeteBrädspel.Model;
using ProjectArbeteBrädspel.ViewModel;
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

namespace ProjectArbeteBrädspel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Game game;

        private List<Player> players;
        public MainWindow()
        {
            InitializeComponent();

            players = new List<Player>();
            players.Add(new Player("Player One", Player.PlayerColor.Red));
            players.Add(new Player("Player Two", Player.PlayerColor.Purple));
            game = new Game(100, players);
            this.DataContext = new GameWindowViewModel(game);
        }




    }
}
