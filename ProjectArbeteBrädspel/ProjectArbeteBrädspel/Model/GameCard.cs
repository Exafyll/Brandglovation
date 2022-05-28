using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectArbeteBrädspel.Model;
using ProjectArbeteBrädspel.Model.Effect;

namespace ProjectArbeteBrädspel.Model
{
    public class GameCard
    {
        public enum EffectType
        {
            None, 
            LosePoints, 
            GainPoints, 
            GetInvestment, 
            GetStrategy, 
            GoToSpecific, 
            GoToNextOf, 
            GainPointsGoToSpecific
        }

        private readonly CardTileModel.CardType type;
        public CardTileModel.CardType Type { get { return type; } }

        private readonly string description;
        public string Description { get { return description; } }

        //private readonly EffectType effect;
        //public EffectType Effect { get { return effect; } }
        private EffectModel effect;
        public EffectModel Effect { get { return effect; } }

        //private readonly int? points;
        //public int? Points { get { return points; } }

        //private readonly Country? country;
        //public Country? Country { get { return country; } }

        #region Constructors

        /// <summary>
        /// Constructor - Gain/Lose Points effect
        /// </summary>
        /// <param name="type">The Type of Card</param>
        /// <param name="description">The Card Description</param>
        /// <param name="effect">The Type of Effect</param>
        /// <param name="points">The amount of points to Gain/Lose. Positive values only</param>
        public GameCard(CardTileModel.CardType type, string description, EffectType effect, int points)
        {
            this.type = type;
            this.description = description;
            switch (effect)
            {
                case EffectType.LosePoints:
                    this.effect = new LosePointsEffect(points);
                    break;
                case EffectType.GainPoints:
                    this.effect = new GainPointsEffect(points);
                    break;
                default:
                    this.effect = new NullEffect();
                    break;
            }
        }

        // TODO: More constructors for more effect types

        /// <summary>
        /// Constructor - Null Effect
        /// </summary>
        /// <param name="type">The Type of Card</param>
        /// <param name="description">The Card Description</param>
        public GameCard(CardTileModel.CardType type, string description)
        {
            this.type = type;
            this.description = description;
            effect = new NullEffect();
        }

        #endregion

        public void ApplyEffect(Player player)
        {
            effect.Apply(player);
        }
    }
}
