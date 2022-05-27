using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectArbeteBrädspel.Model.Effect
{
    public class LosePointsEffect : PointsEffect
    {
        public LosePointsEffect(int points) : base(points) 
        {
            Text = "Spend " + points + "p";
        }

        public override void Apply(Player player)
        {
            player.LosePoints(points);
        }
    }
}
