using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectArbeteBrädspel.Model
{
    public class Investment
    {
        public enum InvestmentTier
        {
            TierOne,
            TierTwo,
            TierThree,
            TierFour,
            TierFive
        }
        private InvestmentTier tier;
        public InvestmentTier Tier { get { return tier; }}
        public string Desciption
        {
            get
            {
                switch (Tier)
                {
                    case InvestmentTier.TierOne: return "Sales through export";
                    case InvestmentTier.TierTwo: return "Sales through agents";
                    case InvestmentTier.TierThree: return "Establishment of sales subsidiary";
                    case InvestmentTier.TierFour: return "Establishment of production facility";
                    default: return "Acquisition of Bilia Ltd.";
                }
            }
        }
        public int Amount 
        { 
            get 
            {
                switch (Tier)
                {
                    case InvestmentTier.TierOne: return 100;
                    case InvestmentTier.TierTwo: return 200;
                    case InvestmentTier.TierThree: return 300;
                    case InvestmentTier.TierFour: return 500;
                    default: return 2500; 
                }
            }
        }

        public Investment(InvestmentTier tier)
        {
            this.tier = tier;
        }
    }

}
