using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ShapeMenu.Figures
{
    internal class FigureMenu : Menu
    {
        private List<Shape> shapes = new List<Shape>();
        public override void Execute()
        {
            Console.WriteLine("menu de figuras");
            Console.WriteLine("Que quieres hacer \n1 : Crear una figura \n2 : Ver figuras \n3 : Salir");

            int select;

            if (!int.TryParse(Console.ReadLine(), out select))
            {
                Console.Clear();
                Console.WriteLine("Porfavor Ingrese un numero valido");
                Console.ReadKey();
                Console.Clear();
                Execute();
                return;
            }

            switch (select)
            {
                case 1: Console.Clear(); AddShape();
                    break;
                case 2: Console.Clear(); ShapeList();
                    break;
                case 3:
                    break;

                default: Console.Clear(); Console.WriteLine("Opcion no valida, intente denuevo"); Console.ReadKey(); Console.Clear(); Execute();
                    break;
            }
        }

        private void AddShape() 
        {
            Console.WriteLine("Que figura quieres crear \n1 : Crear un cuadrado \n2 : Crear un rectangulo \n3 : Crear un triangulo \n4 : Crear un circulo \n5 : Regresar");

            int ss;

            if (!int.TryParse(Console.ReadLine(), out ss))
            {
                Console.Clear();
                Console.WriteLine("Porfavor Ingrese un numero valido");
                Console.ReadKey();
                Console.Clear();
                AddShape();
                return;
            }

            double h, b, s, r;

            switch (ss)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("escribe el lado del cuadrado");
                    while (!double.TryParse(Console.ReadLine(), out s))
                        Console.WriteLine("Error, ingrese un numero");

                    Shape sq = new Square(s);
                    shapes.Add(sq);
                    Result($"\nEl area del cuadrado es: {sq.GetArea()}");

                    break;

                case 2:
                    Console.Clear();

                    Console.WriteLine("escribe la base del rectangulo");
                    while (!double.TryParse(Console.ReadLine(), out b))
                        Console.WriteLine("Error, ingrese un numero");

                    Console.WriteLine("escribe la altura del rectangulo");
                    while (!double.TryParse(Console.ReadLine(), out h))
                        Console.WriteLine("Error, ingrese un numero");

                    Rectangle re = new Rectangle(b,h);
                    shapes.Add(re);
                    Result($"\nEl area del cuadrado es: {re.GetArea()}");

                    break;
                case 3:
                    Console.Clear();

                    Console.WriteLine("escribe la base del triangulo");
                    while (!double.TryParse(Console.ReadLine(), out b))
                        Console.WriteLine("Error, ingrese un numero");

                    Console.WriteLine("escribe la altura del triangulo");
                    while (!double.TryParse(Console.ReadLine(), out h))
                        Console.WriteLine("Error, ingrese un numero");

                    Triangle tr = new Triangle(b, h);
                    shapes.Add(tr);
                    Result($"El area del cuadrado es: {tr.GetArea()}");

                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("escribe el lado del cuadrado");
                    while (!double.TryParse(Console.ReadLine(), out r))
                        Console.WriteLine("Error, ingrese un numero");

                    Circle ci = new Circle(r);
                    shapes.Add(ci);
                    Result($"\nEl area del cuadrado es: {ci.GetArea()}");

                    break;

                case 5:
                    Console.Clear(); Execute();
                    break;

                default:
                    Console.Clear(); Console.WriteLine("Opcion no valida, intente denuevo"); Console.ReadKey(); Console.Clear(); AddShape();
                    break;
            }
        }

        private void ShapeList()
        {
            Console.Clear();

            if (shapes.Count == 0) 
                Console.WriteLine("No tienes figuras creadas todavia");
            else 
            { 
                Console.WriteLine("Figuras Creadas:");
                for (int i = 0; i < shapes.Count; i++)
                { 
                    Shape shape = shapes[i];
                    Console.WriteLine($"{i + 1}. {shape.Name} - Área: {shape.GetArea()}");

                }
            }

            Console.WriteLine("\nPresione cualquier tecla para volver al menu");
            Console.ReadKey();
            Console.Clear();
            Execute();
        }

        private void Result(string area)
        {
            Console.WriteLine(area);
            Console.WriteLine("\nPresione cualquier tecla para volver al menu");
            Console.ReadKey();
            Console.Clear();
            Execute();
        }
        
    }
}
