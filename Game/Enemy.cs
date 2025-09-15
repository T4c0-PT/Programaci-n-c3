using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ShapeMenu.Game
{
    internal class Enemy
    {
        protected double Health, Attack;
        protected bool IsLive;

        public double health { get { return Health; } }
        public double attack { get { return Attack; } }
        public bool Islive { get { return IsLive; } }

        public virtual double GetHurt(double hit)
        {
            return 0;
        }

        public virtual double GetAttack()
        {
            return 0;
        }

        public virtual bool GetLive()
        {
            return IsLive;
        }



    }
}
