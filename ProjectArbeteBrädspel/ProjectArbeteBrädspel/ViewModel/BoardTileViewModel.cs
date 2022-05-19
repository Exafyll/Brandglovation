using ProjectArbeteBrädspel.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectArbeteBrädspel.ViewModel
{
    public class BoardTileViewModel : ViewModel
    {
        private BoardTile boardTile;

        public ObservableCollection<PlayerTileViewModel> Players
        {
            get
            {
                ObservableCollection<PlayerTileViewModel> players = new ObservableCollection<PlayerTileViewModel>();
                for (int i = 0; i < boardTile.Players.Count; i++)
                {
                    players.Add(new PlayerTileViewModel(i % 3, (i > 2) ? 1 : 0, boardTile.Players[i]));
                }
                return players;
            }
        }

        public BoardTileViewModel(BoardTile boardTile)
        {
            this.boardTile = boardTile;
        }

        public void PlayersChanged()
        {
            Change("Players");
        }
    }
}
