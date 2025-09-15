using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeMenu.Game
{
    internal class Player
    {
        private double health;
        private double attack;

        public double Health { get { return health; } }


        public Player(double health, double attack)
        {
            this.health = health;
            this.attack = attack;
        }

        public double GetHurt(double hit)
        {
            health -= hit;
            if (health < 0)
                health = 0;
            return health;
        }

        public double GetAttack() 
        { 
            return attack;
        }




    }
}
