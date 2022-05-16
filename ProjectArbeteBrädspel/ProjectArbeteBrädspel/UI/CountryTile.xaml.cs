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
    /// Interaction logic for CountryTile.xaml
    /// </summary>
    public partial class CountryTile : UserControl
    {
        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Title.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(CountryTile), new PropertyMetadata(String.Empty));



        public ImageSource FlagSource
        {
            get { return (ImageSource)GetValue(FlagSourceProperty); }
            set { SetValue(FlagSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FlagSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FlagSourceProperty =
            DependencyProperty.Register("FlagSource", typeof(ImageSource), typeof(CountryTile), new PropertyMetadata(null));



        public CountryTile()
        {
            InitializeComponent();
        }
    }
}
