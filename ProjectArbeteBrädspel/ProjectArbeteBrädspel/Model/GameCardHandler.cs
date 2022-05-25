﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectArbeteBrädspel.Model
{
    public class GameCardHandler
    {
        List<GameCard> companyCards = new List<GameCard>();
        List<GameCard> marketCards = new List<GameCard>();
        List<GameCard> growthCards = new List<GameCard>();

        public GameCardHandler()
        {
            #region Company Cards
            companyCards.Add(new GameCard(CardTileModel.CardType.
                Company,
                "Our company has recently incurred a loss because of the late delivery of our product to our retailers. The delay in delivery occurred due to conflict in the region.",
                "PointLoss",
                100,
                ""));
            companyCards.Add(new GameCard(CardTileModel.CardType.
                Company,
                "Our company has employed a consultant to perform market research on some African countries. Pay the consultant for his thorough market analysis.",
                "PointLoss",
                200,
                ""));
            companyCards.Add(new GameCard(CardTileModel.CardType.
                Company,
                "Our company has recently introduced environmentally friendly production system. Introducing such system incurred some additional cost for the company.",
                "PointLoss",
                500,
                ""));
            companyCards.Add(new GameCard(CardTileModel.CardType.
                Company,
                "Our company’s new OEM manufacturer in China enabled us to save a lot of currency as it delivered cheap components to us.",
                "PointGain",
                300,
                ""));
            #endregion

            #region Market Cards
            marketCards.Add(new GameCard(CardTileModel.CardType.
                Market,
                "Labour cost is increasing in China. It is no longer cheaper to invest in China like it used to be earlier. Companies are considering moving to other Asian countries and to some African countries where labour cost is lower in comparison with China.",
                "",
                0,
                ""));
            marketCards.Add(new GameCard(CardTileModel.CardType.
                Market,
                "Sales in department stores rose for the first time this year in July, 2019 in the UK. The Office for National Statistics said, with data showing an unexpected rise in total retail sales in the month in comparison with the last three months. However, the growth is not significant. On the other hand, internet sales recorded a 6.9% jump in the month - the biggest rise for three years.",
                "",
                0,
                ""));
            marketCards.Add(new GameCard(CardTileModel.CardType.
                Market,
                "As consumers become ever more concerned about environmental and ethical issues, pioneers in the global denim industry are cleaning up its act. 'Anybody can walk in here, even without an appointment,' says Han Ates, the founder of the London - based small business. 'Through that we create transparency.' By opening up its doors, Blackhorse Lane Ateliers is able to show potential customers that its factory is clean, the 20 employees are happy, and that the jeans are worth keeping - rather than throwing away at the end of each season.",
                "",
                0,
                ""));
            marketCards.Add(new GameCard(CardTileModel.CardType.
                Market,
                "In many denim mills and jeans factories the used water - which contains the dye, plus bleach and other chemicals - is simply released as waste water. Thankfully a growing number of producers are now eliminating waste water altogether. Saitex International, a jeans manufacturer based in Vietnam, is one such business, now recycles 98% of the water it uses. For the remaining 2% it has an evaporation system, making it a zero discharge facility. 'Morally it pushed us to start looking at water as a very valuable resource.'",
                "",
                0,
                ""));
            #endregion

            #region Growth Cards
            growthCards.Add(new GameCard(CardTileModel.CardType.
                Growth,
                "Your company’s sale is decreasing in competition with the other similar offerings. Your option is either to bring an improved product or develop a completely new offering. Since creating new offering demands extensive financial support and the path is uncertain, your consultant suggests you consCardering an incremental innovation, take it slow and make changes over time. Spend 200p for this innovation project.",
                "PointLoss",
                200,
                ""));
            growthCards.Add(new GameCard(CardTileModel.CardType.
                Growth,
                "Your company’s sale is decreasing in competition due to sudden change in the trends in the market. Buyers are moving to environmentally friendly solutions. Perhaps it is time that you consider creating an environmentally friendly offering by choosing a substantial and transformational innovation. Spend 1000p for this transformational innovation project.",
                "PointLoss",
                100,
                ""));
            growthCards.Add(new GameCard(CardTileModel.CardType.
                Growth,
                "Your sales representatives have received complain from your customers. Your customers are not having pleasant experience while shopping your products online. Your company needs to offer a 24/7 digital customer service centre so that problems like this can be solved on time. Invest 500p in this project.",
                "PointLoss",
                500,
                ""));
            growthCards.Add(new GameCard(CardTileModel.CardType.
                Growth,
                "Your company’s sale is decreasing in competition. It is time for you to extend your product line by bringing in new and complimentary products. Check if you need to improve or bring in new flavours in your product. However, be aware of the cost, new flavour should not add too much burden on the customers. Spend 1000p for new line extension.",
                "PointLoss",
                1000,
                ""));
            #endregion

        }


    }
}
