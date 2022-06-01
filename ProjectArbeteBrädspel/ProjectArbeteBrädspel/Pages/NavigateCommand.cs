using ProjectArbeteBrädspel.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjectArbeteBrädspel.Pages
{
    public class NavigateCommand<VM> : ICommand
        where VM : BaseViewModel
    {
        private readonly NavigationStore navigationStore;
        private readonly Func<VM> createViewModel;
        public NavigateCommand(NavigationStore navigationStore, Func<VM> createViewModel)
        {
            this.navigationStore = navigationStore;
            this.createViewModel = createViewModel;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            navigationStore.CurrentViewModel = createViewModel();
        }
    }
}
