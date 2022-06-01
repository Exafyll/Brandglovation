using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectArbeteBrädspel.Model
{
    public class BoardTile : Model
    {
        /// <summary>
        /// The Players currently on this Tile
        /// </summary>
        private List<Player> players;
        public List<Player> Players { get { return players; } }

        private BoardTile? nextTile;
        public BoardTile? NextTile { get { return nextTile; } set { nextTile = value; } }

        private bool isInvestable;
        public bool IsInvestable { get { return isInvestable; } }

        private int index;
        public int Index { get { return index; } }


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        public BoardTile(bool isInvestable, int index)
        {
            players = new List<Player>();
            this.isInvestable = isInvestable;
            this.index = index;
        }

        /// <summary>
        /// Move a Player onto this Tile
        /// </summary>
        /// <param name="player"></param>
        public void PlayerEnter(Player player)
        {
            players.Add(player);
            if (player.CurrentTile != null)
            {
                player.CurrentTile.PlayerLeave(player);
            }
            player.CurrentTile = this;

            // Notify the ViewModel
            Change(nameof(Players));

            OnPlayerEnter(player);
        }

        /// <summary>
        /// Move a Player away from this Tile
        /// </summary>
        /// <param name="player"></param>
        public void PlayerLeave(Player player)
        {
            players.Remove(player);

            Change(nameof(Players));
        }

        /// <summary>
        /// Do something when a Player enters the Tile
        /// </summary>
        /// <param name="player"></param>
        protected virtual void OnPlayerEnter(Player player) { }
    }
}
