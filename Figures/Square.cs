using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeMenu.Figures
{
    internal class Square : Rectangle
    {
        public Square(double s) : base(s, s)
        {
            name = "square";
        }
    }
}
