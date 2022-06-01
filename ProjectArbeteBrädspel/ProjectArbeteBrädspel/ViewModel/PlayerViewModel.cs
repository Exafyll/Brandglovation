using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectArbeteBrädspel.Model;
using ProjectArbeteBrädspel.ViewModel.Board;

namespace ProjectArbeteBrädspel.ViewModel
{
    public class PlayerViewModel : BaseViewModel
    {
        private Player player;

        public string Name { get { return player.Name; } }

        public string Points { get { return player.Points + "p"; } }

        public Player.PlayerColor Color { get { return player.Color; } }

        public bool IsCurrent
        {
            get { return player.IsCurrent; }
            //set
            //{
            //    player.IsCurrent = value;
            //    Change("IsCurrent");
            //}
        }

        public ObservableCollection<QueuedCardViewModel> QueuedCards
        {
            get
            {
                ObservableCollection<QueuedCardViewModel> queue = new ObservableCollection<QueuedCardViewModel>();
                for (int i = player.CardQueue.Count - 1; i >= 0; i--)
                {
                    CardTileModel.CardType card = player.CardQueue[i];
                    bool first = i == 0;
                    queue.Add(new QueuedCardViewModel(card, first));
                }
                return queue;
            }
        }

        public PlayerViewModel(Player player)
        {
            this.player = player;
            this.player.PropertyChanged += Player_PropertyChanged;
        }

        private void Player_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            switch(e.PropertyName)
            {
                case nameof(player.IsCurrent):
                    Change(nameof(IsCurrent));
                    break;
                case nameof(player.CardQueue):
                    Change(nameof(QueuedCards));
                    break;
                case nameof(player.Points):
                    Change(nameof(Points));
                    break;
                case nameof(player.Investments):
                    Change(nameof(Investments));
                    break;
            }
        }

        //public void Move()
        //{
        //    player.Move();
        //    Change("QueuedCards");
        //}
    }
}
