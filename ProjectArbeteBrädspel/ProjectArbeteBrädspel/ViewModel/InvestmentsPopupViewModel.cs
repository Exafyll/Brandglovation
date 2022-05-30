using ProjectArbeteBrädspel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectArbeteBrädspel.ViewModel
{
    public class InvestmentsPopupViewModel : LargePopupViewModel
    {
        private Player player;

        public InvestmentsPopupViewModel(Player player, LargePopupViewModel.PopupColor color) : base (color, "Investments", null)
        {
            this.player = player;
        }
    }
}
