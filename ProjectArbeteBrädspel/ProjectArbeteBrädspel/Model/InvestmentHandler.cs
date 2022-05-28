using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectArbeteBrädspel.Model
{
    public class InvestmentHandler
    {
        private readonly Country country;
        public Country Country { get { return country; } }

        List<Investment> Investments = new List<Investment>();


        public int CreateInvestment()
        {
            //checks if there alreddy is an investment on that country
            var list = Investments.LastOrDefault();
            //Listing exists
            if (list != null)
            {
                if (list.Tier == Investment.InvestmentTier.TierOne)
                {
                    Investments.Add(new Investment(Investment.InvestmentTier.TierTwo ));
                }
                if (list.Tier == Investment.InvestmentTier.TierTwo)
                {
                    Investments.Add(new Investment(Investment.InvestmentTier.TierThree ));
                }
                if (list.Tier == Investment.InvestmentTier.TierThree)
                {
                    Investments.Add(new Investment(Investment.InvestmentTier.TierFour));
                }
                if (list.Tier == Investment.InvestmentTier.TierFour)
                {
                    Investments.Add(new Investment(Investment.InvestmentTier.TierFive));
                }
                if (list.Tier == Investment.InvestmentTier.TierFive)
                {
                    return 0;
                }
            }
            //Listing don't exist
            else
            {
                Investments.Add(new Investment(Investment.InvestmentTier.TierOne));

            }
            return Investments.Last().Amount;
        }

        public InvestmentHandler(Country country)
        {
            this.country = country;
        }
    }
}
