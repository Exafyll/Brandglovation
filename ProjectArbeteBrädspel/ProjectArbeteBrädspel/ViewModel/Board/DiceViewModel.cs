using ProjectArbeteBrädspel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectArbeteBrädspel.ViewModel
{
    public class DiceViewModel : BaseViewModel
    {
        private Dice dice;

        public int Value { get { return dice.Value; } }

        private bool visible;
        public bool Visible 
        { 
            get 
            { 
                return visible;
            }
            set 
            { 
                visible = value;
                Change("Visible");
            } 
        }

        public DiceViewModel(Dice dice)
        {
            visible = false;
            this.dice = dice;
            this.dice.PropertyChanged += Dice_PropertyChanged;
        }

        private void Dice_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case nameof(dice.Value):
                    Change(nameof(Value));
                    break;
            }
        }
    }
}
