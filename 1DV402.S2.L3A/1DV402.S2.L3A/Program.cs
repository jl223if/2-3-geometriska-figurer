using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L3A
{
    class Program
    {
        enum ShapeType { Ellipse, Rectangle }
        static void Main(string[] args)
        {

            do
            {
                ViewMenu();
                try
                {
                        int choise = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        if (choise < 0 || choise > 2)
                        {
                            throw new ArgumentException();
                        }
                        if (choise == 0)
                        {
                            break;
                        }
                        if (choise == 1)
                        {
                            ViewShapeDetail(CreateShape(ShapeType.Ellipse));
                        }
                        if (choise == 2)
                        {
                            ViewShapeDetail(CreateShape(ShapeType.Rectangle));
                        } 
                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nAnge ett tal mellan 0 2.\n");
                    Console.ResetColor();
                }

                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("\ntryck på valfri tangent för att fortsätta\n");
                Console.ResetColor();
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

        private static Shape CreateShape(ShapeType shapeType)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("========================================");
            Console.WriteLine("==              {0}             ==", shapeType);
            Console.WriteLine("========================================");
            Console.ResetColor();

            double length = ReadDoubleGreaterThanZero("\nLängd: ");
            double width = ReadDoubleGreaterThanZero("bredd: ");

            switch (shapeType)
            {
                case ShapeType.Ellipse:
                    return new Ellipse(length, width);
                case ShapeType.Rectangle:
                    return new Rectangle(length, width);
                default:
                    return null;
            }
        }

        private static double ReadDoubleGreaterThanZero(string prompt)
        {
            Console.Write(prompt);
            while (true)
            {
                try
                {
                    double input = double.Parse(Console.ReadLine());
                    return input;
                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Du matade in något annat än ett tal. Försök igen");
                    Console.ResetColor();
                }
            }
        }

        private static void ViewMenu()
        {

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("==========================================");
            Console.WriteLine("=                                        =");
            Console.WriteLine("=           Geometriska figurer          =");
            Console.WriteLine("=                                        =");
            Console.WriteLine("==========================================");
            Console.ResetColor();
            Console.WriteLine("\n 0. Avsluta");
            Console.WriteLine("\n 1. Ellips");
            Console.WriteLine("\n 2. Rektangel");
            Console.WriteLine("\n------------------------------------------");
            Console.Write("\n Ange menyval [0-2]:");
        }
        private static void ViewShapeDetail(Shape shape)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n========================================");
            Console.WriteLine("=               Detaljer               =");
            Console.WriteLine("========================================");
            Console.ResetColor();
            Console.WriteLine(shape.ToString());
        }

    }
}
