using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ProjectArbeteBrädspel.Model
{
    public class Player : Model
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
        public string Name 
        { 
            get { return name; } 
            set
            {
                name = value;
                Change(nameof(Name));
            }
        }

        /// <summary>
        /// The Players points
        /// </summary>
        private int points;
        public int Points 
        { 
            get { return points; } 
            set
            {
                points = value;
                Change(nameof(Points));
            }
        }

        /// <summary>
        /// The Color of the Player
        /// </summary>
        private PlayerColor color;
        public PlayerColor Color 
        { 
            get { return color; } 
            set
            {
                color = value;
                Change(nameof(Color));
            }
        }

        /// <summary>
        /// Queue of Cards the Player has to draw
        /// </summary>
        private List<CardTileModel.CardType> cardQueue;
        public List<CardTileModel.CardType> CardQueue { get { return cardQueue; } }

        private BoardTile? currentTile;
        public BoardTile? CurrentTile { get { return currentTile; } set { currentTile = value; } }

        private bool isCurrent;
        public bool IsCurrent 
        { 
            get { return isCurrent; } 
            set 
            { 
                isCurrent = value;
                Change(nameof(IsCurrent));
            } 
        }

        private List<InvestmentHandler> investments;
        public List<InvestmentHandler> Investments { get { return investments; } }
        

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
            isCurrent = false;
            investments = new List<InvestmentHandler>();
        }

        /// <summary>
        /// Queue up a Card to draw
        /// </summary>
        /// <param name="cardType"></param>
        public void QueueCard(CardTileModel.CardType cardType)
        {
            cardQueue.Add(cardType);
            Change(nameof(CardQueue));
        }

        /// <summary>
        /// Draws a cardType from the Player's Card Queue
        /// </summary>
        /// <returns>The type of Card to draw</returns>
        /// <exception cref="InvalidOperationException">Returns an exception if called when no cards are queued. Just don't do it. It'll be fine</exception>
        public CardTileModel.CardType DrawCard()
        {
            if (CardQueue.Count > 0)
            {
                CardTileModel.CardType type = cardQueue.First();
                cardQueue.Remove(cardQueue.First());
                Change(nameof(CardQueue));
                return type;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        #region Effect Application
        public void LosePoints(int points)
        {
            Points -= points;
        }

        public void GainPoints(int points)
        {
            Points += points;
        }

        // TODO: Implement other effect types

        #endregion

        /// <summary>
        /// Move the player one step
        /// </summary>
        public void Move()
        {
            if (currentTile != null && currentTile.NextTile != null)
            {
                currentTile.NextTile.PlayerEnter(this);
                System.Diagnostics.Debug.WriteLine("Player " + name + " Moved to " + currentTile);
            }
        }

        

        public void Invest(Country country)
        {
            InvestmentHandler? handler = Investments.FirstOrDefault(o => o.Country == country);
            if (handler == null)
            {
                Investments.Add(new InvestmentHandler(country));
                handler = Investments.Last();
                Change(nameof(Investments));
            }
            LosePoints(handler.CreateInvestment());

        }

        public void ApplyStrategy(Country country, Strategy.StrategyTier tier)
        {
            InvestmentHandler? handler = Investments.FirstOrDefault(o => o.Country == country);
            if (handler != null)
            {
                LosePoints(handler.CreateStrategy(tier));
            }
            else
            {
                throw new InvalidOperationException();
            }
        }



    }
}
