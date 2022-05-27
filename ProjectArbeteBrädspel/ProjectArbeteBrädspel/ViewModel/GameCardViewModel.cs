using ProjectArbeteBrädspel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjectArbeteBrädspel.ViewModel
{
    public class GameCardViewModel : LargePopupViewModel
    {
        private GameCardHandler handler;

        public string Description
        {
            get
            {
                if (handler.DrawnCard != null)
                {
                    return handler.DrawnCard.Description;
                }
                return "";
            }
        }

        public string Effect
        {
            get
            {
                if (handler.DrawnCard != null)
                {
                    return handler.DrawnCard.Effect.Text;
                }
                return "";
            }
        }

        public GameCardViewModel(GameCardHandler handler, ICommand command) : base(PopupColor.Default, "Game Card", command)
        {
            this.handler = handler;
            handler.PropertyChanged += Handler_PropertyChanged;
        }

        private void Handler_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                // Handle change of drawn card
                case nameof(handler.DrawnCard):
                    IsVisible = handler.DrawnCard != null;
                    if (handler.DrawnCard != null)
                    {
                        switch(handler.DrawnCard.Type)
                        {
                            case CardTileModel.CardType.Growth:
                                Title = "Growth Strategies";
                                Color = PopupColor.GrowthBlue;
                                break;
                            case CardTileModel.CardType.Company:
                                Title = "Company Newsletter";
                                Color = PopupColor.CompanyYellow;
                                break;
                            case CardTileModel.CardType.Market:
                                Title = "Market Information";
                                Color = PopupColor.MarketOrange;
                                break;

                        }
                    }
                    else
                    {
                        Title = "Game Card";
                        Color = PopupColor.Default;
                    }
                    Change(nameof(Description));
                    Change(nameof(Effect));
                    break;
            }
        }
    }
}
