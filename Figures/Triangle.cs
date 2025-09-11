using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeMenu.Figures
{
    internal class Triangle : Shape
    {
        protected double b;
        protected double h;

        public Triangle(double b, double h)
        {
            this.b = b;
            this.h = h;
            name = "triangle";
        }

        public override double GetArea()
        {
            return (b * h) / 2;
        }
    }
}
