using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectArbeteBrädspel.Pages
{
    public class NavigationService
    {
        private NavigationStore _navigationStore;

        public NavigationService(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        /// <summary>
        /// Navigate to page
        /// </summary>
        /// <param name="page">The page to navigate to</param>
        public void NavigateTo(ViewModel.ViewModel page)
        {
            _navigationStore.CurrentViewModel = page;
        }
    }
}
