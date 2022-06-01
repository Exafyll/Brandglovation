using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectArbeteBrädspel.Model
{
    public class Investment : Model
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
                    case InvestmentTier.TierOne: return "Export";
                    case InvestmentTier.TierTwo: return "Retailers";
                    case InvestmentTier.TierThree: return "Subsidiary";
                    case InvestmentTier.TierFour: return "Facility";
                    default: return "Acquisition";
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

        public bool IncreaseTier()
        {
            switch (Tier)
            {
                case InvestmentTier.TierOne:
                    tier = InvestmentTier.TierTwo;
                    break;
                case InvestmentTier.TierTwo:
                    tier = InvestmentTier.TierThree;
                    break;
                case InvestmentTier.TierThree:
                    tier = InvestmentTier.TierFour;
                    break;
                case InvestmentTier.TierFour:
                    tier = InvestmentTier.TierFive;
                    break;
                default:
                    return false;
            }
            Change(nameof(Amount));
            Change(nameof(Desciption));
            return true;
        }
    }

}
