using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ProjectArbeteBrädspel.Model;

namespace ProjectArbeteBrädspel.ViewModel
{
    public class GameViewModel : ViewModel
    {
        private Game game;

        private ObservableCollection<PlayerViewModel> players;
        public ObservableCollection<PlayerViewModel> Players { get { return players; } }

        public PlayerViewModel CurrentPlayer
        {
            get
            {
                return new PlayerViewModel(game.CurrentPlayer);
            }
        }

        private ObservableCollection<CountryViewModel> countries;
        private ObservableCollection<BoardTileViewModel> boardTiles;

        public DiceViewModel Dice { get; }

        public ICommand ColombifyCommand { get; }

        public ICommand RollDiceCommand { get; }

        #region Tiles
        // SCANDINAVIA
        public CountryViewModel Country0 { get { return countries[0]; } }

        public CountryViewModel Country1 { get { return countries[1]; } }

        public CountryViewModel Country2 { get { return countries[2]; } }

        public CountryViewModel Country3 { get { return countries[3]; } }


        public BoardTileViewModel CardTile1 { get { return boardTiles[4]; } }


        // WESTERN EUROPE
        public CountryViewModel Country4 { get { return countries[4]; } }

        public CountryViewModel Country5 { get { return countries[5]; } }

        public CountryViewModel Country6 { get { return countries[6]; } }


        public BoardTileViewModel CardTile2 { get { return boardTiles[8]; } }


        // NORTH AMERICA
        public CountryViewModel Country7 { get { return countries[7]; } }

        public CountryViewModel Country8 { get { return countries[8]; } }

        public CountryViewModel Country9 { get { return countries[9]; } }


        public BoardTileViewModel CardTile3 { get { return boardTiles[12]; } }


        // SOUTH AMERICA
        public CountryViewModel Country10 { get { return countries[10]; } }

        public CountryViewModel Country11 { get { return countries[11]; } }

        public CountryViewModel Country12 { get { return countries[12]; } }


        public BoardTileViewModel CardTile4 { get { return boardTiles[16]; } }


        // OCEANIA
        public CountryViewModel Country13 { get { return countries[13]; } }

        public CountryViewModel Country14 { get { return countries[14]; } }

        public CountryViewModel Country15 { get { return countries[15]; } }


        public BoardTileViewModel CardTile5 { get { return boardTiles[20]; } }


        // EAST ASIA
        public CountryViewModel Country16 { get { return countries[16]; } }

        public CountryViewModel Country17 { get { return countries[17]; } }

        public CountryViewModel Country18 { get { return countries[18]; } }


        public BoardTileViewModel CardTile6 { get { return boardTiles[24]; } }


        // SOUTHWEST ASIA
        public CountryViewModel Country19 { get { return countries[19]; } }

        public CountryViewModel Country20 { get { return countries[20]; } }

        public CountryViewModel Country21 { get { return countries[21]; } }


        public BoardTileViewModel CardTile7 { get { return boardTiles[28]; } }


        // AFRICA
        public CountryViewModel Country22 { get { return countries[22]; } }

        public CountryViewModel Country23 { get { return countries[23]; } }

        public CountryViewModel Country24 { get { return countries[24]; } }
        #endregion

        // Testing Purposes Only
        public LargePopupViewModel TestPopup { get; }

        public GameViewModel(Game game)
        {
            this.game = game;

            players = new ObservableCollection<PlayerViewModel>();
            foreach (Player player in game.Players)
            {
                players.Add(new PlayerViewModel(player));
            }

            countries = new ObservableCollection<CountryViewModel>();
            boardTiles = new ObservableCollection<BoardTileViewModel>();

            #region Countries

            countries.Add(new CountryViewModel(game.Countries[0]));
            countries.Add(new CountryViewModel(game.Countries[1]));
            countries.Add(new CountryViewModel(game.Countries[2]));
            countries.Add(new CountryViewModel(game.Countries[3]));

            boardTiles.Add(Country0);
            boardTiles.Add(Country1);
            boardTiles.Add(Country2);
            boardTiles.Add(Country3);

            boardTiles.Add(new BoardTileViewModel(game.BoardTiles[4]));

            countries.Add(new CountryViewModel(game.Countries[4]));
            countries.Add(new CountryViewModel(game.Countries[5]));
            countries.Add(new CountryViewModel(game.Countries[6]));

            boardTiles.Add(Country4);
            boardTiles.Add(Country5);
            boardTiles.Add(Country6);

            boardTiles.Add(new BoardTileViewModel(game.BoardTiles[8]));

            countries.Add(new CountryViewModel(game.Countries[7]));
            countries.Add(new CountryViewModel(game.Countries[8]));
            countries.Add(new CountryViewModel(game.Countries[9]));

            boardTiles.Add(Country7);
            boardTiles.Add(Country8);
            boardTiles.Add(Country9);

            boardTiles.Add(new BoardTileViewModel(game.BoardTiles[12]));

            countries.Add(new CountryViewModel(game.Countries[10]));
            countries.Add(new CountryViewModel(game.Countries[11]));
            countries.Add(new CountryViewModel(game.Countries[12]));

            boardTiles.Add(Country10);
            boardTiles.Add(Country11);
            boardTiles.Add(Country12);

            boardTiles.Add(new BoardTileViewModel(game.BoardTiles[16]));

            countries.Add(new CountryViewModel(game.Countries[13]));
            countries.Add(new CountryViewModel(game.Countries[14]));
            countries.Add(new CountryViewModel(game.Countries[15]));

            boardTiles.Add(Country13);
            boardTiles.Add(Country14);
            boardTiles.Add(Country15);

            boardTiles.Add(new BoardTileViewModel(game.BoardTiles[20]));

            countries.Add(new CountryViewModel(game.Countries[16]));
            countries.Add(new CountryViewModel(game.Countries[17]));
            countries.Add(new CountryViewModel(game.Countries[18]));

            boardTiles.Add(Country16);
            boardTiles.Add(Country17);
            boardTiles.Add(Country18);

            boardTiles.Add(new BoardTileViewModel(game.BoardTiles[24]));

            countries.Add(new CountryViewModel(game.Countries[19]));
            countries.Add(new CountryViewModel(game.Countries[20]));
            countries.Add(new CountryViewModel(game.Countries[21]));

            boardTiles.Add(Country19);
            boardTiles.Add(Country20);
            boardTiles.Add(Country21);

            boardTiles.Add(new BoardTileViewModel(game.BoardTiles[28]));

            countries.Add(new CountryViewModel(game.Countries[22]));
            countries.Add(new CountryViewModel(game.Countries[23]));
            countries.Add(new CountryViewModel(game.Countries[24]));

            boardTiles.Add(Country22);
            boardTiles.Add(Country23);
            boardTiles.Add(Country24);

            #endregion

            ColombifyCommand = new RelayCommand(Colombify);

            Dice = new DiceViewModel(game.Dice);

            RollDiceCommand = new RelayCommand(RollDice);

            TestPopup = new LargePopupViewModel(LargePopupViewModel.PopupColor.MarketOrange, "Market Information");
        }

        private void Colombify()
        {
            foreach (CountryViewModel country in countries)
            {
                country.Colombify();
            }
            Change("Countries");
        }

        private void RollDice()
        {
            int value = Dice.Roll();
            Change("Dice");
            MovePlayer(value);
        }

        private async void MovePlayer(int steps)
        {
            await Task.Delay(1000);
            for (int i = 0; i < steps; i++)
            {
                CurrentPlayer.Move();
                Change(nameof(CurrentPlayer));
                foreach (BoardTileViewModel tile in boardTiles)
                {
                    tile.PlayersChanged();
                }
                Change("Countries");
                await Task.Delay(750);
            }
            Dice.Visible = false;
        }


    }
}
