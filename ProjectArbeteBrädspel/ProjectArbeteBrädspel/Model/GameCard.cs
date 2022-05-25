using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectArbeteBrädspel.Model;

namespace ProjectArbeteBrädspel.Model
{
    public class GameCard
    {
        private readonly CardTileModel.CardType title;
        public CardTileModel.CardType Title { get { return title; } }

        private readonly string description;
        public string Description { get { return description; } }

        private readonly string effect;
        public string Effect { get { return effect; } }

        private readonly int? points;
        public int? Points { get { return points; } }

        private readonly Country? country;
        public Country? Country { get { return country; } }

        public GameCard(CardTileModel.CardType title, string description, string effect, int points, Country country)
        {
            this.title = title;
            this.description = description;
            this.effect = effect;
            this.points = points;
            this.country = country;
        }

        public GameCard(CardTileModel.CardType title, string description, string effect, int points)
        {
            this.title = title;
            this.description = description;
            this.effect = effect;
            this.points = points;
            country = null;
        }

        public GameCard(CardTileModel.CardType title, string description, string effect, Country country)
        {
            this.title = title;
            this.description = description;
            this.effect = effect;
            points = null;
            this.country = country;
        }
    }
}
