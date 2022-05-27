using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectArbeteBrädspel.Model
{
    public class GameCardHandler : Model
    {
        private Random rand;

        List<GameCard> companyCards = new List<GameCard>();
        List<GameCard> marketCards = new List<GameCard>();
        List<GameCard> growthCards = new List<GameCard>();

        private GameCard? drawnCard;
        public GameCard? DrawnCard 
        { 
            get { return drawnCard; } 
            set 
            { 
                drawnCard = value;
                Change(nameof(DrawnCard));
            }
        }

        public GameCardHandler()
        {
            //TODO: Add Countries to cards that need them

            #region Company Cards
            companyCards.Add(new GameCard(CardTileModel.CardType.
                Company,
                "Our company has recently incurred a loss because of the " +
                "late delivery of our product to our retailers. The delay " +
                "in delivery occurred due to conflict in the region.",
                GameCard.EffectType.LosePoints,
                100));
            companyCards.Add(new GameCard(CardTileModel.CardType.
                Company,
                "Our company has recently introduced environmentally " +
                "friendly production system. Introducing such system " +
                "incurred some additional cost for the company.",
                GameCard.EffectType.LosePoints,
                500));
            companyCards.Add(new GameCard(CardTileModel.CardType.
                Company,
                "Our company has employed a consultant to perform market " +
                "research on some African countries. Pay the consultant for " +
                "their thorough market analysis.",
                GameCard.EffectType.LosePoints,
                200));
            companyCards.Add(new GameCard(CardTileModel.CardType.
                Company,
                "Our company’s new OEM manufacturer in China enabled us " +
                "to save a lot of currency as it delivered cheap components " +
                "to us.",
                GameCard.EffectType.GainPoints,
                300));
            companyCards.Add(new GameCard(CardTileModel.CardType.
                Company,
                "Our sales in India was affected by flood.",
                GameCard.EffectType.LosePoints,
                200));
            companyCards.Add(new GameCard(CardTileModel.CardType.
                Company,
                "Tsunami in the east coast of the pacific left a huge " +
                "impact on the sales in this region. Our company has " +
                "incurred a significant loss. ",
                GameCard.EffectType.LosePoints,
                1000));
            companyCards.Add(new GameCard(CardTileModel.CardType.
                Company,
                "Shares in our company lost more than a quarter of the " +
                "value on Tuesday morning after it is said profits would " +
                "fall short of expectations. In response to the profit " +
                "warning, our investors sold off shares wiping more than " +
                "£150m from the company's value. ",
                GameCard.EffectType.LosePoints,
                2000));
            companyCards.Add(new GameCard(CardTileModel.CardType.
                Company,
                "Our stores in the European markets no longer use plastic " +
                "bags. Four years ago we invested a huge amount of our " +
                "finance to promote paper bags and that created a positive " +
                "image about us in the eye of today’s consumers. We are reaping " +
                "the benefit today by attracting customers who are concerned " +
                "about protecting environment. We are further investigating " +
                "to our Asian and North American stores and hoping to remove " +
                "all plastic bags by 2021.",
                GameCard.EffectType.GainPoints,
                300));
            companyCards.Add(new GameCard(CardTileModel.CardType.
                Company,
                "By adding recycled plastic materials in our products, we have " +
                "not only managed to cut costs but also were able to attract the " +
                "new generation customers. ",
                GameCard.EffectType.GainPoints,
                500));
            companyCards.Add(new GameCard(CardTileModel.CardType.
                Company,
                "After involving the customers for creating new design we have " +
                "got much positive attention from them. Our sales have increased " +
                "significantly. Involving customers to energize our brand was a " +
                "good idea. ",
                GameCard.EffectType.GainPoints,
                300));
            companyCards.Add(new GameCard(CardTileModel.CardType.
                Company,
                "Our buyers blog posts on how they have experienced our product " +
                "have created much attention of the new buyers. We can see a " +
                "significant level of increase in our sales and interest shown " +
                "by our potential buyers. Involving customers to energize our " +
                "brand was a good idea",
                GameCard.EffectType.GainPoints,
                400));
            companyCards.Add(new GameCard(CardTileModel.CardType.
                Company,
                "Our management’s decision to promote the local yearly marathon " +
                "has gained much attention of the buyers. During the sport event " +
                "we conveyed the message that “you are nobody if you don’t own our " +
                "product”.  This publicity event energised our brand so well that " +
                "we could attract new buyers. ",
                GameCard.EffectType.GainPoints,
                300));
            companyCards.Add(new GameCard(CardTileModel.CardType.
                Company,
                "The audiobook created by our marketing team gave a better brand " +
                "experience to the existing buyers as well as created a new kind " +
                "of experience for the potential ones. We gained 20 million viewers " +
                "in our online portal between 2012-2017. Our outstanding achievement " +
                "incurred significant profit. ",
                GameCard.EffectType.GainPoints,
                1000));
            companyCards.Add(new GameCard(CardTileModel.CardType.
                Company,
                "Endorser engagement is an effective brand energizer. The management " +
                "has approached Messi recently to become our brand endorser. He will " +
                "be advertising our products on TV channels. ",
                GameCard.EffectType.LosePoints,
                1000));
            companyCards.Add(new GameCard(CardTileModel.CardType.
                Company,
                "Our company has received funding from the local investment bank. ",
                GameCard.EffectType.GainPoints,
                2000));
            companyCards.Add(new GameCard(CardTileModel.CardType.
                Company,
                "Our company has acquired two small suppliers who are leaders in " +
                "their respective niche. We expect to gain their expert knowledge " +
                "and that would benefit us to enter into the new product market. ",
                GameCard.EffectType.LosePoints,
                2500));
            companyCards.Add(new GameCard(CardTileModel.CardType.
                Company,
                "Our company has sold its stock. ",
                GameCard.EffectType.GainPoints,
                300));
            companyCards.Add(new GameCard(CardTileModel.CardType.
                Company,
                "Pay the marketing consultant. ",
                GameCard.EffectType.LosePoints,
                300));
            companyCards.Add(new GameCard(CardTileModel.CardType.
                Company,
                "Our new designer in charge has employed two new designers in the " +
                "team who are highly qualified and creative. We are expecting to " +
                "enter a new area of fashion with their help. ",
                GameCard.EffectType.LosePoints,
                500));
            companyCards.Add(new GameCard(CardTileModel.CardType.
                Company,
                "Our new online platform has been proved to be successful. Customers " +
                "can access to different areas of our product offerings just by " +
                "clicking on the desired link. This has also increased our sales. ",
                GameCard.EffectType.GainPoints,
                300));
            companyCards.Add(new GameCard(CardTileModel.CardType.
                Company,
                "With our new designers in the team we were able to enter a new area " +
                "of fashion and this has captured the attention of global consumers " +
                "whose prime concern is to save the environment. ",
                GameCard.EffectType.GainPoints,
                500));
            companyCards.Add(new GameCard(CardTileModel.CardType.
                Company,
                "Our management team is considering taking an extensive brand extension " +
                "strategy by adding in new products and services. We will also begin " +
                "our new TV channel, and showrooms where consumers can have real life " +
                "experience while trying our products. ",
                GameCard.EffectType.LosePoints,
                3000));
            #endregion

            #region Market Cards
            marketCards.Add(new GameCard(CardTileModel.CardType.
                Market,
                "Labour cost is increasing in China. " +
                "It is no longer cheaper to invest in China like it used to be earlier. " +
                "Companies are considering moving to other Asian countries and to some " +
                "African countries where labour cost is lower in comparison with China."));
            marketCards.Add(new GameCard(CardTileModel.CardType.
                Market,
                "Sales in department stores rose for the first time this year in July, " +
                "2019 in the UK. The Office for National Statistics said, with data showing " +
                "an unexpected rise in total retail sales in the month in comparison with " +
                "the last three months. However, the growth is not significant. On the other " +
                "hand, internet sales recorded a 6.9% jump in the month - the biggest rise " +
                "for three years."));
            marketCards.Add(new GameCard(CardTileModel.CardType.
                Market,
                "As consumers become ever more concerned about environmental and ethical " +
                "issues, pioneers in the global denim industry are cleaning up its act. " +
                "'Anybody can walk in here, even without an appointment,' says Han Ates, " +
                "the founder of the London - based small business. 'Through that we create " +
                "transparency.' By opening up its doors, Blackhorse Lane Ateliers is able " +
                "to show potential customers that its factory is clean, the 20 employees " +
                "are happy, and that the jeans are worth keeping - rather than throwing " +
                "away at the end of each season."));
            marketCards.Add(new GameCard(CardTileModel.CardType.
                Market,
                "In many denim mills and jeans factories the used water - which contains " +
                "the dye, plus bleach and other chemicals - is simply released as waste " +
                "water. Thankfully a growing number of producers are now eliminating " +
                "waste water altogether. Saitex International, a jeans manufacturer based " +
                "in Vietnam, is one such business, now recycles 98% of the water it uses. " +
                "For the remaining 2% it has an evaporation system, making it a zero " +
                "discharge facility. 'Morally it pushed us to start looking at water as a " +
                "very valuable resource.'"));
            marketCards.Add(new GameCard(CardTileModel.CardType.
                Market,
                "US President Donald Trump has declared himself 'Tariff Man', in his bid " +
                "to use tariffs to shift more production and jobs back to the USA. While " +
                "Mr Trump insists it will be others who foot the bill, as the BBC's Karishma " +
                "Vaswani points out when it comes to higher tariffs - both sides can end up " +
                "paying."));
            marketCards.Add(new GameCard(CardTileModel.CardType.
                Market,
                "The UK has just recorded one quarter of declining economic activity, so " +
                "the idea of an imminent recession is not at all fanciful, although the " +
                "figures have been influenced by stockpiling ahead of planned Brexit dates " +
                "and the subsequent rundown of those stocks. In the US, it would take a " +
                "significant further slowdown to produce a recession. Germany has also " +
                "registered a quarter of declining activity, according to new figures, so " +
                "a recession could be under way there too."));
            marketCards.Add(new GameCard(CardTileModel.CardType.
                Market,
                "Data from the German statistics office on Wednesday showed the economy " +
                "shrank by 0.1% between April and June. That takes the annual growth rate " +
                "down to 0.4%. Germany narrowly avoided a recession last year. But this time, " +
                "there are predictions the economy will continue to contract for another " +
                "three-month period. The main driver of the economic weakness appears to be " +
                "rising global trade tensions. Companies that supply Germany's carmakers, " +
                "including Continental and Bosch, have warned about the impact of the worldwide " +
                "slowdown on sales of cars."));
            marketCards.Add(new GameCard(CardTileModel.CardType.
                Market,
                "Aggreko, which supplies temporary power generators to high-profile events " +
                "around the world, is putting 10% of its profits into new technology. The " +
                "Glasgow-based company has traditionally used diesel-power. But it is now " +
                "increasing the use of solar technology and storage batteries. Robert Wells, " +
                "who looks after Aggreko's events business, said clients running events such " +
                "as the Open golf competition and Rugby World Cup were looking for ways to " +
                "reduce their carbon footprint."));
            marketCards.Add(new GameCard(CardTileModel.CardType.
                Market,
                "Around the world, a cottage industry is growing in converting classic cars " +
                "into electric vehicles. Small firms are buying up old Nissan and Tesla parts " +
                "and bolting them into Ferraris, Porsches and BMWs, making them cleaner, easier " +
                "to maintain and even quicker. The basic process differs little from firm to " +
                "firm: take out the engine and fuel tank and replace them with a battery pack " +
                "and motor, often connecting the motor to the old gear box. They try to change " +
                "as little as possible so that the process is reversible. Mr Morgan said, 'It " +
                "was nothing environmental, purely from a car point of view.How can I make it " +
                "faster, better, more reliable?'"));
            marketCards.Add(new GameCard(CardTileModel.CardType.
                Market,
                "Automobili Pininfarina's Battista 'hypercar' is the fastest road legal car ever " +
                "- and it's electric. Chief executive Michael Perschke talks to the BBC's Theo " +
                "Leggett about why the company built the £2m battery-powered machine."));
            marketCards.Add(new GameCard(CardTileModel.CardType.
                Market,
                "Fifth-generation mobile broadband is coming over the next year or so, promising " +
                "download and browsing speeds 10 to 20 times faster than those today's 4G networks " +
                "can offer. This superfast mobile connectivity means you might be able to livestream " +
                "a high-definition film to your phone, say, or enjoy much higher quality augmented " +
                "and virtual reality experiences while you're out and about. It will also power the " +
                "'internet of things', enabling connected machines, from traffic lights to driverless " +
                "cars, to communicate with each other."));
            marketCards.Add(new GameCard(CardTileModel.CardType.
                Market,
                "EE has announced which six UK cities will be the first to get faster 5G mobile " +
                "networks. Building on existing trials, EE will turn on 5G in London, Cardiff, " +
                "Edinburgh, Belfast, Birmingham and Manchester by mid-2019. By the end of 2019, " +
                "another 10 cities will get EE networks which could transmit data at speeds faster " +
                "than 10 gigabits per second. Other UK networks are now trialling 5G to accelerate " +
                "their rollout next year."));
            marketCards.Add(new GameCard(CardTileModel.CardType.
                Market,
                "To benefit from superfast mobile, due for launch over the next couple of years, " +
                "we'll all need to buy new phones. And as we know with all new technologies, the " +
                "first models won't come cheap. The next generation of phones will need a much more " +
                "complex antenna, a whole new chipset or brain, and a way of managing the extra " +
                "energy richer 5G services will gobble up. Much of the base engineering is solved, " +
                "says Scott Petty, Vodafone UK's chief technology officer. Now engineers are working " +
                "on miniaturisation and how to scale up manufacturing to keep costs down, he says."));
            marketCards.Add(new GameCard(CardTileModel.CardType.
                Market,
                "Scott Petty, Vodafone UK's chief technology officer says 'We think 5G will kick off " +
                "another wave of innovation that we haven't seen in the last three or four years,' He " +
                "says, something akin to the shift from clunky physical keyboard-based models to those " +
                "with high-definition touchscreens. He predicts, with virtual reality (VR) and augmented " +
                "reality (AR) benefiting most from the faster streaming speeds and lower latency (delay)."));
            marketCards.Add(new GameCard(CardTileModel.CardType.
                Market,
                "A herd of cows is living on a floating farm in the middle of Europe's busiest port " +
                "of Rotterdam. The animals are part of an experiment to produce food more sustainably, " +
                "and closer to people. Peter van Wingerden, founder of Beladon, told BBC Radio 5 Live: " +
                "'No matter how much rain falls, no matter how high sea level goes, we can always " +
                "produce our life-essential, healthy food.'"));
            marketCards.Add(new GameCard(CardTileModel.CardType.
                Market,
                "For decades, many firms have paid lip service to climate change without substantially " +
                "altering the way they do business. Then investors joined the climate campaign and " +
                "began applying pressure from within. Their message is that acting on climate change " +
                "isn't just a feel-good - it's a necessity to protect long-term assets. The Bank of " +
                "England, for instance, recently warned that $20tn (£15.3tn) of assets could be wiped " +
                "out by climate change. This alarming note is being amplified by fund managers who " +
                "are pulling their investments out of fossil fuels."));
            marketCards.Add(new GameCard(CardTileModel.CardType.
                Market,
                "Car dashboards and other interior components could soon be made from bioplastics, " +
                "explains Wojciech Komala, research and development director of Selena, a research " +
                "group in Poland. It's called the Biomotive project and it has been awarded €15m " +
                "(£13.5m) from the EU. 'We lower the carbon footprint by using bio-based sources, " +
                "and by trying to develop lighter components for the cars.' Although currently an " +
                "expensive option, it is theoretically greener than using oil since plants are renewable " +
                "carbon sinks. Mr Komala says his team hopes to construct a small production factory " +
                "next year."));
            #endregion

            // Unfinished
            #region Growth Cards
            growthCards.Add(new GameCard(CardTileModel.CardType.
                Growth,
                "Your company’s sale is decreasing in competition with the other similar " +
                "offerings. Your option is either to bring an improved product or develop " +
                "a completely new offering. Since creating new offering demands extensive " +
                "financial support and the path is uncertain, your consultant suggests you " +
                "consCardering an incremental innovation, take it slow and make changes " +
                "over time.",
                GameCard.EffectType.GetStrategy, // Innovation in Technology
                200));
            growthCards.Add(new GameCard(CardTileModel.CardType.
                Growth,
                "Your company’s sale is decreasing in competition due to sudden change in " +
                "the trends in the market. Buyers are moving to environmentally friendly " +
                "solutions. Perhaps it is time that you consider creating an environmentally " +
                "friendly offering by choosing a substantial and transformational innovation. ",
                GameCard.EffectType.GetStrategy, // Green Production
                100));
            growthCards.Add(new GameCard(CardTileModel.CardType.
                Growth,
                "Your sales representatives have received complain from your customers. " +
                "Your customers are not having pleasant experience while shopping your " +
                "products online. Your company needs to offer a 24/7 digital customer service " +
                "centre so that problems like this can be solved on time. ",
                GameCard.EffectType.GetStrategy, // 24/7 Customer Service
                500));
            growthCards.Add(new GameCard(CardTileModel.CardType.
                Growth,
                "Your company’s sale is decreasing in competition. It is time for you to " +
                "extend your product line by bringing in new and complimentary products. " +
                "Check if you need to improve or bring in new flavours in your product. " +
                "However, be aware of the cost, new flavour should not add too much burden " +
                "on the customers. ",
                GameCard.EffectType.GetStrategy, // Line Extension
                1000));
            growthCards.Add(new GameCard(CardTileModel.CardType.
                Growth,
                "Description",
                GameCard.EffectType.LosePoints,
                200));
            growthCards.Add(new GameCard(CardTileModel.CardType.
                Growth,
                "Description",
                GameCard.EffectType.LosePoints,
                200));
            growthCards.Add(new GameCard(CardTileModel.CardType.
                Growth,
                "Description",
                GameCard.EffectType.LosePoints,
                200));
            growthCards.Add(new GameCard(CardTileModel.CardType.
                Growth,
                "Description",
                GameCard.EffectType.LosePoints,
                200));
            growthCards.Add(new GameCard(CardTileModel.CardType.
                Growth,
                "Description",
                GameCard.EffectType.LosePoints,
                200));
            growthCards.Add(new GameCard(CardTileModel.CardType.
                Growth,
                "Description",
                GameCard.EffectType.LosePoints,
                200));
            growthCards.Add(new GameCard(CardTileModel.CardType.
                Growth,
                "Description",
                GameCard.EffectType.LosePoints,
                200));
            growthCards.Add(new GameCard(CardTileModel.CardType.
                Growth,
                "Description",
                GameCard.EffectType.LosePoints,
                200));
            growthCards.Add(new GameCard(CardTileModel.CardType.
                Growth,
                "Description",
                GameCard.EffectType.LosePoints,
                200));
            growthCards.Add(new GameCard(CardTileModel.CardType.
                Growth,
                "Description",
                GameCard.EffectType.LosePoints,
                200));
            growthCards.Add(new GameCard(CardTileModel.CardType.
                Growth,
                "Description",
                GameCard.EffectType.LosePoints,
                200));
            growthCards.Add(new GameCard(CardTileModel.CardType.
                Growth,
                "Description",
                GameCard.EffectType.LosePoints,
                200));
            growthCards.Add(new GameCard(CardTileModel.CardType.
                Growth,
                "Description",
                GameCard.EffectType.LosePoints,
                200));
            growthCards.Add(new GameCard(CardTileModel.CardType.
                Growth,
                "Description",
                GameCard.EffectType.LosePoints,
                200));
            growthCards.Add(new GameCard(CardTileModel.CardType.
                Growth,
                "Description",
                GameCard.EffectType.LosePoints,
                200));
            growthCards.Add(new GameCard(CardTileModel.CardType.
                Growth,
                "Description",
                GameCard.EffectType.LosePoints,
                200));
            growthCards.Add(new GameCard(CardTileModel.CardType.
                Growth,
                "Description",
                GameCard.EffectType.LosePoints,
                200));
            growthCards.Add(new GameCard(CardTileModel.CardType.
                Growth,
                "Description",
                GameCard.EffectType.LosePoints,
                200));
            growthCards.Add(new GameCard(CardTileModel.CardType.
                Growth,
                "Description",
                GameCard.EffectType.LosePoints,
                200));
            growthCards.Add(new GameCard(CardTileModel.CardType.
                Growth,
                "Description",
                GameCard.EffectType.LosePoints,
                200));
            #endregion

            rand = new Random();

            drawnCard = null;

        }

        public void DrawCard(CardTileModel.CardType type)
        {
            int i;
            switch (type)
            {
                case CardTileModel.CardType.Growth:
                    i = rand.Next(0, growthCards.Count);
                    DrawnCard = growthCards[i];
                    break;
                case CardTileModel.CardType.Company:
                    i = rand.Next(0, companyCards.Count);
                    DrawnCard = companyCards[i];
                    break;
                case CardTileModel.CardType.Market:
                    i = rand.Next(0, marketCards.Count);
                    DrawnCard = marketCards[i];
                    break;
                    
            }
        }

        public void ApplyEffect(Player player)
        {
            if (DrawnCard != null)
            {
                DrawnCard.ApplyEffect(player);
                DrawnCard = null;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }


    }
}
