using ProjectArbeteBrädspel.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectArbeteBrädspel.ViewModel
{
    public class InvestmentsViewModel : ViewModel
    {
        private InvestmentHandler handler;

        public string Title
        {
            get => handler.Country.Name;
        }

        public InvestmentViewModel Investment
        {
            get
            {
                return new InvestmentViewModel(handler.Investment);
            }
        }

        //TODO: Public viewmodel for strategy

        public InvestmentsViewModel(InvestmentHandler handler)
        {
            this.handler = handler;
        }
    }
}
