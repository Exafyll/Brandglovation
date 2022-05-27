using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectArbeteBrädspel.Model
{
    public class Game : Model
    {
        public enum TurnStage
        {
            RollDice, // The player rolls the dice
            Movement, // Waiting for the player movement to finish
            Draw, // The player draws any queued cards
            Apply, // The drawn card's effect is applied
            Invest, // The player invests (or not)
            End // The turn finishes
        }

        private TurnStage turnStage;
        public TurnStage Stage 
        { 
            get { return turnStage; } 
            set 
            { 
                turnStage = value;
                Change(nameof(Stage));
            } 
        }

        /// <summary>
        /// The maximum amount of turns
        /// </summary>
        private readonly int turnLimit;
        public int TurnLimit { get { return turnLimit; } }

        /// <summary>
        /// The current turn
        /// </summary>
        private int turn;
        public int Turn { get { return turn; } set { turn = value; } }

        /// <summary>
        /// The Players taking part in the Game
        /// </summary>
        private readonly List<Player> players;
        public List<Player> Players { get { return players; } }

        /// <summary>
        /// The Player currently taking their turn
        /// </summary>
        public Player CurrentPlayer { get { return players.Where(x => x.IsCurrent == true).FirstOrDefault(); } }

        /// <summary>
        /// The tiles on the game board
        /// </summary>
        private readonly BoardTile[] boardTiles;
        public BoardTile[] BoardTiles { get { return boardTiles; } }

        /// <summary>
        /// The Countries in the game. Subset/Subclasses of BoardTiles/BoardTile
        /// </summary>
        private readonly Country[] countries;
        public Country[] Countries { get { return countries; } }

        /// <summary>
        /// It's a dice. What do you want me to say?
        /// </summary>
        private readonly Dice dice;
        public Dice Dice { get { return dice; } }

        /// <summary>
        /// Handler for the Game Cards (Growth strategies, Market information, etc)
        /// </summary>
        private readonly GameCardHandler gameCardHandler;
        public GameCardHandler GameCardHandler { get { return gameCardHandler; } }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="turnLimit">The maximum amount of turns the game is allowed to take</param>
        /// <param name="players">The participating Players</param>
        public Game(int turnLimit, List<Player> players)
        {
            this.turnLimit = turnLimit;
            turn = 0;
            turnStage = TurnStage.RollDice;
            this.players = players;
            MakeCurrent(players[0]);

            dice = new Dice();

            #region Country Instantiation

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

            #endregion

            #region Board Tile Instantiation

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

            #endregion

            #region Board Tile Chaining

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

            #endregion

            foreach (Player player in Players)
            {
                boardTiles[0].PlayerEnter(player);
            }

            gameCardHandler = new GameCardHandler();
        }

        /// <summary>
        /// Set the current player
        /// </summary>
        /// <param name="player">The player to make current</param>
        public void MakeCurrent(Player player)
        {
            foreach (Player p in Players)
            {
                p.IsCurrent = false;
            }
            player.IsCurrent = true;

            //Notify the ViewModel
            Change(nameof(CurrentPlayer));
        }

        public void NextPlayer()
        {
            if (CurrentPlayer != Players.Last())
            {
                MakeCurrent(Players[Players.IndexOf(CurrentPlayer) + 1]);
            }
            else
            {
                MakeCurrent(Players.First());
            }
        }

        /// <summary>
        /// Move the current player
        /// </summary>
        /// <param name="steps">The number of steps to move</param>
        private async void MovePlayer(int steps)
        {
            Stage = TurnStage.Movement;
            await Task.Delay(1000);
            for (int i = 0; i < steps; i++)
            {
                CurrentPlayer.Move();
                await Task.Delay(750);
            }
            if (CurrentPlayer.CardQueue.Count > 0)
            {
                Stage = TurnStage.Draw;
            }
            else
            {
                Stage = TurnStage.Invest;
            }
        }

        /// <summary>
        /// Progress further through the turn
        /// </summary>
        public void ProgressTurn()
        {
            switch (turnStage)
            {
                case TurnStage.RollDice:
                    MovePlayer(Dice.Roll());
                    break;
                case TurnStage.Draw:
                    gameCardHandler.DrawCard(CurrentPlayer.DrawCard());
                    Stage = TurnStage.Apply;
                    break;
                case TurnStage.Apply:

                    gameCardHandler.ApplyEffect(CurrentPlayer);

                    if (CurrentPlayer.CardQueue.Count > 0)
                    {
                        Stage = TurnStage.Draw;
                    }
                    else
                    {
                        Stage = TurnStage.Invest;
                    }
                    break;
                case TurnStage.Invest:
                    //TODO: Invest in shit
                    Stage = TurnStage.End;
                    break;
                case TurnStage.End:

                    // End the turn
                    NextPlayer();
                    Turn++;
                    Stage = TurnStage.RollDice;

                    break;
            }
        }
    }
}
