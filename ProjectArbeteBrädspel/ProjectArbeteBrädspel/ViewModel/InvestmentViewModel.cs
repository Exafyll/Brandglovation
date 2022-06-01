using ProjectArbeteBrädspel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectArbeteBrädspel.ViewModel
{
    public class InvestmentViewModel : BaseViewModel
    {
        private Investment investment;

        public int Amount { get => investment.Amount; }

        public string Description { get => investment.Desciption; }


        public InvestmentViewModel(Investment investment)
        {
            this.investment = investment;
            investment.PropertyChanged += Investment_PropertyChanged;
        }

        private void Investment_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case nameof(investment.Amount):
                    Change(nameof(Amount));
                    break;
                case nameof(investment.Desciption):
                    Change(nameof(Description));
                    break;
            }
        }
    }
}
