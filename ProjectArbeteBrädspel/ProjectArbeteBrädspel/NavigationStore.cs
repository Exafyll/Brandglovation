using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectArbeteBrädspel
{
    public class NavigationStore : Model.Model
    {
        private Action closeAction;
        public Action CloseAction { get { return closeAction; } }

        private BaseViewModel currentViewModel;
        public BaseViewModel CurrentViewModel 
        { 
            get { return currentViewModel; }
            set
            {
                currentViewModel = value;
                Change(nameof(CurrentViewModel));
            }
        }

        public NavigationStore(Action closeAction)
        {
            this.closeAction = closeAction;
        }
    }
}
