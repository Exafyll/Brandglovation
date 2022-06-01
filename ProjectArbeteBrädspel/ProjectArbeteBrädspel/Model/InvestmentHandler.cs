using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectArbeteBrädspel.Model
{
    public class InvestmentHandler : Model
    {
        private readonly Country country;
        public Country Country { get { return country; } }

        public Investment Investment;
        public Strategy Strategy;


        public int CreateInvestment()
        {

            bool charge = true;
            
            if (Investment != null)
            {
                charge = Investment.IncreaseTier();
            }
            else
            {
                Investment = new Investment(Investment.InvestmentTier.TierOne);
            }


            Change(nameof(Investment));
            return charge ? Investment.Amount : 0;
        }

        public int CreateStrategy(Strategy.StrategyTier newTier)
        {
            bool charge = true;

            if (Strategy != null)
            {
                charge = Strategy.SetTier(newTier);
            }
            else
            {
                Strategy = new Strategy(newTier);
            }

            return charge ? Strategy.Amount : 0;
        }

        public InvestmentHandler(Country country)
        {
            this.country = country;
        }
    }
}
