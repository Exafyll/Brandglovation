using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectArbeteBrädspel.Model
{
    public class CardTileModel : BoardTile
    {
        /// <summary>
        /// Enumerator for the Card types
        /// </summary>
        public enum CardType
        {
            Growth, 
            Company, 
            Market
        }

        /// <summary>
        /// The Type of the Card
        /// </summary>
        private readonly CardType cardType;
        public CardType Type { get { return cardType; } }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cardType"></param>
        public CardTileModel(CardType cardType) : base()
        {
            this.cardType = cardType;
        }

        /// <summary>
        /// When a Player enters the Tile, queue up a Card of its type
        /// </summary>
        /// <param name="player"></param>
        protected override void OnPlayerEnter(Player player)
        {
            player.QueueCard(cardType);
            System.Diagnostics.Debug.WriteLine(Type.ToString() + " Card queued for " + player.Name);
        }
    }
}
