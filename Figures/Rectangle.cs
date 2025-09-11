using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeMenu.Figures
{
    internal class Rectangle : Shape
    {
        protected double b;
        protected double h;

        public Rectangle(double b, double h)
        {
            this.b = b;
            this.h = h;
            name = "rectangle";
        }

        public override double GetArea()
        {
            return b * h;
        }

    }
}
