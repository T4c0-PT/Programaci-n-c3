using ShapeMenu.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new FigureMenu();
            menu.Execute();
        }
    }
}
