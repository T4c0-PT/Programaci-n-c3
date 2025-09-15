using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeMenu.Game
{
    internal class EMelee : Enemy
    {

        public EMelee(double health, double attack, bool isLive)
        {
            Health = health;
            Attack = attack;
            IsLive = isLive;
        }

        public override double GetHurt(double hit)
        {   
            Health -= hit;
            if (Health <= 0) IsLive = false;
            return Health;
        }

        public override double GetAttack()
        {
            return Attack;
        }

        public override bool GetLive()
        {
            return IsLive;
        }


    }
}
