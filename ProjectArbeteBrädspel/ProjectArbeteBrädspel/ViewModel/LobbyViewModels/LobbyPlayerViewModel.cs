using ProjectArbeteBrädspel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectArbeteBrädspel.ViewModel.LobbyViewModels
{
    public class LobbyPlayerViewModel : BaseViewModel
    {
        private Player player;

        /// <summary>
        /// The possible colors to choose from. Update from lobby when other player picks color
        /// </summary>
        private List<Player.PlayerColor> availableColors;
        public List<Player.PlayerColor> AvailableColors 
        { 
            get { return availableColors; } 
            set
            {
                availableColors = value;
                Change(nameof(AvailableColors));
            }
        }

        public Player.PlayerColor Color
        {
            get
            {
                return player.Color;
            }
            set
            {
                player.Color = value;
                Change(nameof(Color));
            }
        }

        public string Name
        {
            get { return player.Name; }
            set
            {
                player.Name = value;
                Change(nameof(Name));
            }
        }

        public LobbyPlayerViewModel(Player player, List<Player.PlayerColor> availableColors)
        {
            this.player = player;
            this.availableColors = availableColors;
        }
    }
}
