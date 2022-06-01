using ProjectArbeteBrädspel.Model;
using ProjectArbeteBrädspel.Pages;
using ProjectArbeteBrädspel.ViewModel.Base;
using ProjectArbeteBrädspel.ViewModel.LobbyViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjectArbeteBrädspel.ViewModel
{
    public class MenuViewModel : BaseViewModel
    {
        private NavigationStore _navigationStore;

        private Lobby lobby;
        public LobbyViewModel Lobby { get; }

        /// <summary>
        /// The command to open the Local Game creation menu
        /// </summary>
        public ICommand LocalGameCommand { get; }

        /// <summary>
        /// The command to create a new Game
        /// </summary>
        public ICommand CreateGameCommand { get; }

        /// <summary>
        /// The command to open the rules
        /// </summary>
        public ICommand RulesCommand { get; }

        /// <summary>
        /// The command to exit the game
        /// </summary>
        public ICommand ExitCommand { get; }

        public MenuViewModel(NavigationStore navigationStore, Action exitCommand)
        {
            _navigationStore = navigationStore;

            LocalGameCommand = new RelayCommand(ShowLobby);
            CreateGameCommand = new NavigateCommand<GameViewModel>(_navigationStore, CreateGame);
            ExitCommand = new RelayCommand(exitCommand);

            lobby = new Lobby();
            Lobby = new LobbyViewModel(lobby, CreateGameCommand);
        }

        public void ShowLobby()
        {
            Lobby.IsVisible = true;
        }

        public GameViewModel CreateGame()
        {
            return new GameViewModel(new Game(lobby.TurnLimit, lobby.Players), _navigationStore);
        }

    }
}
