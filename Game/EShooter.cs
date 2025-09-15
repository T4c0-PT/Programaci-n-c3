using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeMenu.Game
{
    internal class EShooter : Enemy
    {
        protected int balls = 5;

        public int Balls { get { return balls; } }

        public EShooter(double health, double attack, bool isLive)
        {
            Health = health;
            Attack = attack;
            IsLive = isLive;
        }

        public override double GetHurt(double hit)
        {
            Health -= hit;
            if (Health <= 0)
            {             
                IsLive = false;
                Health = 0;
            }
            return Health;
        }

        public override double GetAttack()
        {
            if (balls > 0)
            { 
                balls--;
                return attack;
            }

            return 0;
        }
        public override bool GetLive()
        {
            return IsLive;
        }

    }
}
