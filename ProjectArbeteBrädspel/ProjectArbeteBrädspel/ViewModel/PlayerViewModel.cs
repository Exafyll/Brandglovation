using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectArbeteBrädspel.Model;

namespace ProjectArbeteBrädspel.ViewModel
{
    public class PlayerViewModel : ViewModel
    {
        private Player player;

        public string Name { get { return player.Name; } }

        public int Points { get { return player.Points; } }

        public Player.PlayerColor Color { get { return player.Color; } }

        public bool IsCurrent
        {
            get { return player.IsCurrent; }
            set
            {
                player.IsCurrent = value;
                Change("IsCurrent");
            }
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
        }

        public void Move()
        {
            player.Move();
            Change("QueuedCards");
        }
    }
}
