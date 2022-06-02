using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjectArbeteBrädspel.ViewModel.Base
{
    public class RelayCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private Action action;
        private Func<bool>? canExecuteEvaluator;

        public RelayCommand(Action action, Func<bool>? canExecuteEvaluator)
        {
            this.action = action;
            this.canExecuteEvaluator = canExecuteEvaluator;
        }

        public RelayCommand(Action action) : this(action, null) { }

        public bool CanExecute(object? parameter)
        {
            if (canExecuteEvaluator == null)
            {
                return true;
            }
            else
            {
                return canExecuteEvaluator.Invoke();
            }
        }
        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, new EventArgs());
        }

        public void Execute(object? parameter)
        {
            action.Invoke();
        }
    }
}
