using ProjectArbeteBrädspel.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectArbeteBrädspel.ViewModel.Popup;
using System.Windows.Input;

namespace ProjectArbeteBrädspel.ViewModel
{
    public class InvestmentsPopupViewModel : LargePopupViewModel
    {
        private PlayerViewModel player;
        public PlayerViewModel Player
        {
            set
            {
                player = value;
                player.PropertyChanged += Player_PropertyChanged;
                Change(nameof(Investments));
            }
        }


        public ObservableCollection<InvestmentsViewModel> Investments 
        {
            get { return player.Investments; }
        }
        

        public InvestmentsPopupViewModel(PlayerViewModel player, PopupColor color, ICommand action) : base (color, "Investments", action)
        {
            this.player = player;


            player.PropertyChanged += Player_PropertyChanged;
        }

        private void Player_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case nameof(player.Investments):
                    Change(nameof(Investments));
                    break;
            }
        }
    }
}
