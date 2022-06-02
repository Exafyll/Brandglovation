using ProjectArbeteBrädspel.Pages;
using ProjectArbeteBrädspel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectArbeteBrädspel
{
    public class WindowViewModel : BaseViewModel
    {

        private readonly NavigationStore _navigationStore;

        public BaseViewModel? CurrentViewModel => _navigationStore.CurrentViewModel;

        public WindowViewModel(NavigationStore navigationStore, Action exitCommand)
        {
            _navigationStore = navigationStore;

            _navigationStore.PropertyChanged += _navigationStore_PropertyChanged;

            _navigationStore.CurrentViewModel = new MenuViewModel(_navigationStore, exitCommand);
        }

        private void _navigationStore_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            Change(nameof(CurrentViewModel));
        }
    }
}
