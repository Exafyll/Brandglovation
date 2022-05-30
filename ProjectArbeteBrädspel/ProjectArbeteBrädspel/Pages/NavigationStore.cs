using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectArbeteBrädspel.Pages
{
    public class NavigationStore
    {
        private ViewModel.ViewModel _currentViewModel;
        public ViewModel.ViewModel CurrentViewModel 
        { 
            get => _currentViewModel; 
            set
            {
                _currentViewModel = value;
            }
        }

    }
}
