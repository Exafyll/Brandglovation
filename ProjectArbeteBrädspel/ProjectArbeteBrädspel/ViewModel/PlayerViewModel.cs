using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectArbeteBrädspel.Model;

namespace ProjectArbeteBrädspel.ViewModel
{
    public class PlayerViewModel : ViewModel
    {
        private Player player;

        public string Name { get { return player.Name; } }

        public int Points { get { return player.Points; } }

        public Player.PlayerColor Color { get { return player.Color; } }

        public PlayerViewModel(Player player)
        {
            this.player = player;
        }

        public void Move()
        {
            player.Move();
        }
    }
}
