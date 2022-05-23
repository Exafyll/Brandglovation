using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectArbeteBrädspel.Model
{
    public class Game
    {
        /// <summary>
        /// The maximum amount of turns
        /// </summary>
        private readonly int turnLimit;
        public int TurnLimit { get { return turnLimit; } }

        /// <summary>
        /// The current turn
        /// </summary>
        private int turnCount;
        public int TurnCount { get { return turnCount; } }

        /// <summary>
        /// The Players taking part in the Game
        /// </summary>
        private readonly List<Player> players;
        public List<Player> Players { get { return players; } }

        /// <summary>
        /// The Player currently taking their turn
        /// </summary>
        private Player currentPlayer;
        public Player CurrentPlayer { get { return players.Where(x => x.IsCurrent == true).FirstOrDefault(); } }

        private BoardTile[] boardTiles;
        public BoardTile[] BoardTiles { get { return boardTiles; } }

        private Country[] countries;
        public Country[] Countries { get { return countries; } }

        private Dice dice;
        public Dice Dice { get { return dice; } }

        private GameCardHandler gameCardHandler;
        public GameCardHandler GameCardHandler { get { return gameCardHandler; } }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="turnLimit"></param>
        /// <param name="players"></param>
        public Game(int turnLimit, List<Player> players)
        {
            this.turnLimit = turnLimit;
            turnCount = 0;
            this.players = players;
            currentPlayer = players[0];
            MakeCurrent(players[0]);

            dice = new Dice();

            countries = new Country[25]
            {
                new Country("Sweden", "/Images/se.png"),
                new Country("Norway", "/Images/no.png"),
                new Country("Denmark", "/Images/dk.png"),
                new Country("Finland", "/Images/fi.png"),
                new Country("Germany", "/Images/de.png"),
                new Country("France", "/Images/fr.png"),
                new Country("United Kingdom", "/Images/gb.png"),
                new Country("United States", "/Images/us.png"),
                new Country("Canada", "/Images/ca.png"),
                new Country("Mexico", "/Images/mx.png"),
                new Country("Colombia", "/Images/co.png"),
                new Country("Venezuela", "/Images/ve.png"),
                new Country("Brazil", "/Images/br.png"),
                new Country("Australia", "/Images/au.png"),
                new Country("New Zealand", "/Images/nz.png"),
                new Country("Papua New Guinea", "/Images/pg.png"),
                new Country("China", "/Images/cn.png"),
                new Country("Japan", "/Images/jp.png"),
                new Country("South Korea", "/Images/kr.png"),
                new Country("India", "/Images/in.png"),
                new Country("Pakistan", "/Images/pk.png"),
                new Country("Saudi Arabia", "/Images/sa.png"),
                new Country("Egypt", "/Images/eg.png"),
                new Country("South Africa", "/Images/za.png"),
                new Country("Kenya", "/Images/ke.png")
            };

            boardTiles = new BoardTile[32]
            {
                countries[0],
                countries[1],
                countries[2],
                countries[3],
                new CardTileModel(CardTileModel.CardType.Company),
                countries[4],
                countries[5],
                countries[6],
                new CardTileModel(CardTileModel.CardType.Growth),
                countries[7],
                countries[8],
                countries[9],
                new CardTileModel(CardTileModel.CardType.Market),
                countries[10],
                countries[11],
                countries[12],
                new CardTileModel(CardTileModel.CardType.Growth),
                countries[13],
                countries[14],
                countries[15],
                new CardTileModel(CardTileModel.CardType.Company),
                countries[16],
                countries[17],
                countries[18],
                new CardTileModel(CardTileModel.CardType.Growth),
                countries[19],
                countries[20],
                countries[21],
                new CardTileModel(CardTileModel.CardType.Market),
                countries[22],
                countries[23],
                countries[24]
            };

            boardTiles[0].NextTile = boardTiles[1];
            boardTiles[1].NextTile = boardTiles[2];
            boardTiles[2].NextTile = boardTiles[3];
            boardTiles[3].NextTile = boardTiles[4];
            boardTiles[4].NextTile = boardTiles[5];
            boardTiles[5].NextTile = boardTiles[6];
            boardTiles[6].NextTile = boardTiles[7];
            boardTiles[7].NextTile = boardTiles[8];
            boardTiles[8].NextTile = boardTiles[9];
            boardTiles[9].NextTile = boardTiles[10];
            boardTiles[10].NextTile = boardTiles[11];
            boardTiles[11].NextTile = boardTiles[12];
            boardTiles[12].NextTile = boardTiles[13];
            boardTiles[13].NextTile = boardTiles[14];
            boardTiles[14].NextTile = boardTiles[15];
            boardTiles[15].NextTile = boardTiles[16];
            boardTiles[16].NextTile = boardTiles[17];
            boardTiles[17].NextTile = boardTiles[18];
            boardTiles[18].NextTile = boardTiles[19];
            boardTiles[19].NextTile = boardTiles[20];
            boardTiles[20].NextTile = boardTiles[21];
            boardTiles[21].NextTile = boardTiles[22];
            boardTiles[22].NextTile = boardTiles[23];
            boardTiles[23].NextTile = boardTiles[24];
            boardTiles[24].NextTile = boardTiles[25];
            boardTiles[25].NextTile = boardTiles[26];
            boardTiles[26].NextTile = boardTiles[27];
            boardTiles[27].NextTile = boardTiles[28];
            boardTiles[28].NextTile = boardTiles[29];
            boardTiles[29].NextTile = boardTiles[30];
            boardTiles[30].NextTile = boardTiles[31];
            boardTiles[31].NextTile = boardTiles[0];

            foreach (Player player in Players)
            {
                boardTiles[0].PlayerEnter(player);
            }

            gameCardHandler = new GameCardHandler();
        }

        public void MakeCurrent(Player player)
        {
            currentPlayer = player;
            foreach (Player p in Players)
            {
                p.IsCurrent = false;
            }
            player.IsCurrent = true;
        }
    }
}
