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
            PlayerPurple
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

        public ICommand ToggleVisibilityCommand { get; }

        public LargePopupViewModel(PopupColor color, string title)
        {
            this.color = color;
            this.title = title;
            isVisible = true;

            ToggleVisibilityCommand = new RelayCommand(ToggleVisibility);
        }

        public void ToggleVisibility()
        {
            IsVisible = !IsVisible;
        }
    }
}
