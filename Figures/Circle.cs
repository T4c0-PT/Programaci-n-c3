using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeMenu.Figures
{
    internal class Circle : Shape
    {
        protected double r;

        public Circle(double r)
        {
            this.r = r;
            name = "Cirle";
        }

        public override double GetArea()
        {
            return 3.14 * Math.Pow(r, 2);
        }

    }
}
