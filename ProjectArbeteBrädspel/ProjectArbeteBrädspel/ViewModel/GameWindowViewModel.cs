using ProjectArbeteBrädspel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectArbeteBrädspel.ViewModel
{
    public class GameWindowViewModel : ViewModel
    {
        private GameViewModel gameViewModel;
        public GameViewModel GameViewModel { get { return gameViewModel; } }

        public GameWindowViewModel(Game game)
        {
            gameViewModel = new GameViewModel(game);
        }
    }
}
