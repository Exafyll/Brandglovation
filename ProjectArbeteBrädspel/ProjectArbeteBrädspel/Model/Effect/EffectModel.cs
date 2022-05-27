using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectArbeteBrädspel.Model.Effect
{
    public abstract class EffectModel
    {
        public string Text = "";

        public abstract void Apply(Player player);
    }
}
