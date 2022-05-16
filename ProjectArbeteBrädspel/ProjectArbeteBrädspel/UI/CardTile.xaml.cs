using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjectArbeteBrädspel
{
    /// <summary>
    /// Interaction logic for CardTile.xaml
    /// </summary>
    public partial class CardTile : UserControl
    {
        public enum CardType
        {
            Growth, 
            Market, 
            Company
        }

        public CardType Type
        {
            get { return (CardType)GetValue(TypeProperty); }
            set { SetValue(TypeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Type.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TypeProperty =
            DependencyProperty.Register("Type", typeof(CardType), typeof(CardTile), new PropertyMetadata(CardType.Growth));

        /*public string Title
        {
            get
            {
                switch (Type)
                {
                    case CardType.Market:
                        return "Market Information";
                    case CardType.Company:
                        return "Company Newsletter";
                    default:
                        return "Growth Strategies";
                }
            }
        }*/

        /*public SolidColorBrush Color
        {
            get
            {
                switch (Type)
                {
                    case CardType.Market:
                        return FindResource("MarketOrangeBrush") as SolidColorBrush;
                    case CardType.Company:
                        return Resources["CompanyYellowBrush"] as SolidColorBrush;
                    default:
                        return Resources["GrowthBlueBrush"] as SolidColorBrush;
                }
            }
        }*/




        public CardTile()
        {
            InitializeComponent();
        }
    }
}
