using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectArbeteBrädspel.Model
{
    public class Player
    {
        /// <summary>
        /// Enumerator for the Player colors
        /// </summary>
        public enum PlayerColor
        {
            Red, 
            Grey, 
            Yellow, 
            Green, 
            Blue, 
            Purple
        }

        /// <summary>
        /// The Players name
        /// </summary>
        private string name;
        public string Name { get { return name; } }

        /// <summary>
        /// The Players points
        /// </summary>
        private int points;
        public int Points { get { return points; } }

        /// <summary>
        /// The Color of the Player
        /// </summary>
        private PlayerColor color;
        public PlayerColor Color { get { return color; } }

        //TODO: Add investment list

        /// <summary>
        /// Queue of Cards the Player has to draw
        /// </summary>
        private List<CardTileModel.CardType> cardQueue;

        private BoardTile? currentTile;
        public BoardTile? CurrentTile { get { return currentTile; } set { currentTile = value; } }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="color"></param>
        public Player(string name, PlayerColor color)
        {
            this.name = name;
            points = 50000;
            this.color = color;
            cardQueue = new List<CardTileModel.CardType>();
        }

        /// <summary>
        /// Queue up a Card to draw
        /// </summary>
        /// <param name="cardType"></param>
        public void QueueCard(CardTileModel.CardType cardType)
        {
            cardQueue.Add(cardType);
        }

        public void Move()
        {
            if (currentTile != null && currentTile.NextTile != null)
            {
                currentTile.NextTile.PlayerEnter(this);
                System.Diagnostics.Debug.WriteLine("Player " + name + " Moved to " + currentTile);
            }
        }

    }
}
