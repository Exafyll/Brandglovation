using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjectArbeteBrädspel.ViewModel
{
    public class LargePopupViewModel : ViewModel
    {
        public enum PopupColor
        {
            GrowthBlue, 
            CompanyYellow, 
            MarketOrange, 
            PlayerRed, 
            PlayerGrey, 
            PlayerYellow, 
            PlayerGreen,
            PlayerBlue, 
            PlayerPurple, 
            Default
        }

        private PopupColor color;
        public PopupColor Color 
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
                Change("Color");
            }
        }

        private string title;
        public string Title 
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
                Change(nameof(Title));
            }
        }

        private bool isVisible;
        public bool IsVisible 
        {
            get
            {
                return isVisible;
            }
            set
            {
                isVisible = value;
                Change(nameof(IsVisible));
            }
        }

        public ICommand Command { get; }

        public LargePopupViewModel(PopupColor color, string title, ICommand command)
        {
            this.color = color;
            this.title = title;
            isVisible = false;

            Command = command;
        }
    }
}
