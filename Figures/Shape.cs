using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeMenu.Figures
{
    internal class Shape
    {
        protected string name;

        public string Name { get { return name; } }

        public virtual double GetArea()
        {
            return 0;
        }

        

    }
}
