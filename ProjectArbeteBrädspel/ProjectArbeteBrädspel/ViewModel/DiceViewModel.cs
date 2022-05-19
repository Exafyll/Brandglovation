using ProjectArbeteBrädspel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectArbeteBrädspel.ViewModel
{
    public class DiceViewModel : ViewModel
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
        }

        public int Roll()
        {
            Visible = true;
            int val = dice.Roll();
            Change("Value");
            return val;
        }
    }
}
