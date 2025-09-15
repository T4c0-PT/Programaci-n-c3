using ShapeMenu.Figures;
using ShapeMenu.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeMenu
{
    internal class Program
    {
        private List<Menu> menu = new List<Menu>();

        static void Main(string[] args)
        {
            Menu game = new GameMenu();
            Menu figures = new FigureMenu();

            int select;

            Console.WriteLine("Que quieres hacer \n1: Buscar el area de una figura \n2: Jugar TBS");

            while (!int.TryParse(Console.ReadLine(), out select))
                Console.WriteLine("numero no valido");

            switch (select)
            {
                case 1:
                    Console.Clear(); figures.Execute();
                    break;
                case 2:
                    Console.Clear(); game.Execute();  
                    break;
                default:
                    break;
            }
        }
    }
}
