using ProjectArbeteBrädspel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProjectArbeteBrädspel.ViewModel.Board
{
    public class QueuedCardViewModel : BaseViewModel
    {
        private static int margin;
        private CardTileModel.CardType type;

        public string Title
        {
            get
            {
                switch (type)
                {
                    case CardTileModel.CardType.Company: return "Company Newsletter";
                    case CardTileModel.CardType.Market: return "Market Information";
                    default: return "Growth Strategies";
                }
            }
        }

        public CardTileModel.CardType Type { get { return type; } }

        private bool isFirst;

        public Thickness Margin
        {
            get
            {
                return new Thickness(isFirst ? margin : 0, isFirst ? 0 : margin, isFirst ? 0 : margin, isFirst ? margin : 0);
            }
        }

        public QueuedCardViewModel(CardTileModel.CardType type, bool isFirst)
        {
            margin = 20;
            this.type = type;
            this.isFirst = isFirst;
        }
    }
}
