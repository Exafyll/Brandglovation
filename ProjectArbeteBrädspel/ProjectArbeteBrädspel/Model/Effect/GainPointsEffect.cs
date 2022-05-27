using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectArbeteBrädspel.Model.Effect
{
    public class GainPointsEffect : PointsEffect
    {
        public GainPointsEffect(int points) : base(points) 
        {
            Text = "Gain " + points + "p";
        }

        public override void Apply(Player player)
        {
            player.GainPoints(points);
        }
    }
}
