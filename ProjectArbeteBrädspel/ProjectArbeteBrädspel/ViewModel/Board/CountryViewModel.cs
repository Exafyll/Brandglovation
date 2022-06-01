using ProjectArbeteBrädspel.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectArbeteBrädspel.ViewModel.Board
{
    public class CountryViewModel : BoardTileViewModel
    {
        private bool colombiaMode;
        public void Colombify()
        {
            colombiaMode = !colombiaMode;
            Change("Name");
            Change("FlagSource");
        }

        private Country country;

        public string Name
        {
            get
            {
                return colombiaMode ? "Colombia" : country.Name;
            }
        }

        public string FlagSource
        {
            get
            {
                return colombiaMode ? "/Images/co.png" : country.FlagSource;
            }
        }

        public CountryViewModel(Country country) : base(country)
        {
            colombiaMode = false;
            this.country = country;
        }
    }
}
