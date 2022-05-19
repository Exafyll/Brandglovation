using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectArbeteBrädspel.Model
{
    public class Dice
    {
        private Random random;
        public enum DiceValue
        {
            One, 
            Two,
            Three,
            Four,
            Five,
            Six
        }

        private DiceValue value;
        public int Value 
        { 
            get 
            { 
                switch (value)
                {
                    case DiceValue.One:
                        return 1;
                    case DiceValue.Two:
                        return 2;
                    case DiceValue.Three:
                        return 3;
                    case DiceValue.Four:
                        return 4;
                    case DiceValue.Five:
                        return 5;
                    default:
                        return 6;
                }
            } 
        }

        public Dice()
        {
            random = new Random();
            value = DiceValue.One;
        }

        public int Roll()
        {
            value = (DiceValue)random.Next(0, 6);
            System.Diagnostics.Debug.WriteLine("Dice Rolled, Value set to " + Value);
            return Value;
        }
    }
}
