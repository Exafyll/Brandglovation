using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectArbeteBrädspel.Model.Effect
{
    public abstract class PointsEffect : EffectModel
    {
        protected int points;

        public PointsEffect(int points)
        {
            this.points = points;
        }
    }
}
