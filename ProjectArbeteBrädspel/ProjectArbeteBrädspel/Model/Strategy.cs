using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectArbeteBrädspel.Model
{
    public class Strategy
    {
        public enum StrategyTier
        {
            TierOne,
            TierTwo,
            TierThree,
            TierFour
        }
        private StrategyTier tier;
        public StrategyTier Tier { get { return tier; } }

        public string Desciption
        {
            get
            {
                switch (Tier)
                {
                    case StrategyTier.TierOne: return "Innovation in technology";
                    case StrategyTier.TierTwo: return "Digital 24/7 customer service";
                    case StrategyTier.TierThree: return "Green produktion";
                    default: return "Customer tailored products";
                }
            }
        }
        public int Amount
        {
            get
            {
                switch (Tier)
                {
                    case StrategyTier.TierOne: return 200;
                    case StrategyTier.TierTwo: return 500;
                    case StrategyTier.TierThree: return 1000;
                    default: return 1500;
                }
            }
        }

        public Strategy(StrategyTier tier )
        {
            this.tier = tier;
        }
                               //vill ta in vilken tier som jag ska byta till
                               //metoden ska returnera false om det redan fins en strategy på samma tier
        public bool SetTier(StrategyTier newTier)
        {
            if (Tier != newTier)
            {
                tier = newTier;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
