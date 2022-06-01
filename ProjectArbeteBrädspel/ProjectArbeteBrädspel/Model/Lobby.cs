using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectArbeteBrädspel.Model
{
    public class Lobby : Model
    {
        private int turnLimit;
        public int TurnLimit 
        { 
            get { return turnLimit; } 
            set 
            { 
                turnLimit = value; 
                Change(nameof(TurnLimit));
            } 
        }

        private int startingPoints;
        public int StartingPoints
        {
            get { return startingPoints; }
            set
            {
                startingPoints = value;
                Change(nameof(StartingPoints));

                foreach (Player player in Players)
                {
                    player.Points = StartingPoints;
                }
            }
        }

        private List<Player> players;
        public List<Player> Players
        {
            get { return players; }
            set
            {
                players = value;
                Change(nameof(Players));
            }
        }

        public Lobby()
        {
            turnLimit = 100;
            startingPoints = 50000;
            players = new List<Player> { new Player("Player", Player.PlayerColor.Red)};
        }

        public void AddPlayer(Player.PlayerColor color)
        {
            Player player = new Player("Player", color);
            player.Points = StartingPoints;
            players.Add(player);
            Change(nameof(Players));
        }

        /// <summary>
        /// Remove the last player
        /// </summary>
        public void RemovePlayer()
        {
            players.RemoveAt(players.Count - 1);
        }
    }
}
