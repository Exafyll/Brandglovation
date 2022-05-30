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
    /// Interaction logic for GamePage.xaml
    /// </summary>
    public partial class GamePage : Page
    {

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="players">The participating players</param>
        /// <param name="turnLimit">The maximum amount of turns</param>
        public GamePage(List<Player> players, int turnLimit)
        {
            InitializeComponent();

            DataContext = new GameWindowViewModel(new Game(turnLimit, players));
        }

        /// <summary>
        /// Old parameterless constructor, will be deleted probs
        /// </summary>
        public GamePage()
        {
            InitializeComponent();
        }
    }
}
