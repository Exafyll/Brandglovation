using ProjectArbeteBrädspel.Model;
using ProjectArbeteBrädspel.ViewModel.Base;
using ProjectArbeteBrädspel.ViewModel.Popup;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjectArbeteBrädspel.ViewModel.LobbyViewModels
{
    public class LobbyViewModel : LargePopupViewModel
    {
        /// <summary>
        /// Lobby Model
        /// </summary>
        private readonly Lobby lobby;

        /// <summary>
        /// Turn Limit
        /// </summary>
        public string TurnLimit
        {
            get { return lobby.TurnLimit.ToString(); }
            set
            {
                try
                {
                    lobby.TurnLimit = int.Parse(value);
                    Change(nameof(TurnLimit));
                }
                catch(Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e.ToString());
                }
            }
        }

        /// <summary>
        /// Score Limit
        /// </summary>
        public string StartingPoints
        {
            get { return lobby.StartingPoints.ToString(); }
            set
            {
                try
                {
                    lobby.StartingPoints = int.Parse(value);
                    Change(nameof(StartingPoints));
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e.ToString());
                }
            }
        }

        private ObservableCollection<LobbyPlayerViewModel> players;
        public ObservableCollection<LobbyPlayerViewModel> Players
        {
            get { return players; }
            set
            {
                players = value;
                Change(nameof(Players));
            }
        }

        private List<Player.PlayerColor> availableColors;

        #region Commands

        public RelayCommand AddPlayerCommand { get; }

        public RelayCommand RemovePlayerCommand { get; }

        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="lobby">The lobby to viewmodel for</param>
        public LobbyViewModel(Lobby lobby, ICommand command) : base(PopupColor.Default, "Create Game", command)
        {
            this.lobby = lobby;

            players = new ObservableCollection<LobbyPlayerViewModel>();
            availableColors = RecheckAvailableColors();
            foreach (Player player in lobby.Players)
            {
                players.Add(new LobbyPlayerViewModel(player, availableColors));
            }
            #region Command Instantiation

            AddPlayerCommand = new RelayCommand(AddPlayer, AddPlayer_CanExecute);

            RemovePlayerCommand = new RelayCommand(RemovePlayer, RemovePlayer_CanExecute);

            #endregion
        }

        private void AddPlayer()
        {
            if (lobby.Players.Count < 6)
            {
                lobby.AddPlayer(availableColors.First());
                availableColors.Remove(availableColors.First());
                players.Add(new LobbyPlayerViewModel(lobby.Players.Last(), availableColors));
                Change(nameof(Players));
                foreach (LobbyPlayerViewModel player in players)
                {
                    player.AvailableColors = availableColors;
                }

                AddPlayerCommand.RaiseCanExecuteChanged();
                RemovePlayerCommand.RaiseCanExecuteChanged();
            }
        }

        public bool AddPlayer_CanExecute()
        {
            return lobby.Players.Count < 6;
        }

        /// <summary>
        /// Remove the last player
        /// </summary>
        private void RemovePlayer()
        {
            lobby.RemovePlayer();
            players.Remove(players.Last());
            Change(nameof(Players));
            availableColors = RecheckAvailableColors();

            AddPlayerCommand.RaiseCanExecuteChanged();
            RemovePlayerCommand.RaiseCanExecuteChanged();
        }

        public bool RemovePlayer_CanExecute()
        {
            return lobby.Players.Count > 1;
        }

        private List<Player.PlayerColor> RecheckAvailableColors()
        {
            List<Player.PlayerColor> colors = new List<Player.PlayerColor>();
            foreach (Player.PlayerColor color in Enum.GetValues<Player.PlayerColor>())
            {
                colors.Add(color);
            }

            foreach (Player player in lobby.Players)
            {
                colors.Remove(player.Color);
            }

            return colors;
        }
    }
}
