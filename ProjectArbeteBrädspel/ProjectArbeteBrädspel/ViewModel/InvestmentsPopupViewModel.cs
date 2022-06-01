using ProjectArbeteBrädspel.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectArbeteBrädspel.ViewModel
{
    public class InvestmentsPopupViewModel : LargePopupViewModel
    {
        private PlayerViewModel player;


        public ObservableCollection<InvestmentsViewModel> Investments 
        {
            get {return player.Investments;}
        }
        

        public InvestmentsPopupViewModel(PlayerViewModel player, LargePopupViewModel.PopupColor color) : base (color, "Investments", null)
        {
            this.player = player;
            this.IsVisible = true;


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
