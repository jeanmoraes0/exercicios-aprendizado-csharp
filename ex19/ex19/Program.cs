using System;
using System.Collections.Generic;
using System.Globalization;
using ex19.Entities;
using ex19.Entities.Enums;

namespace ex19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            List<Shape> list = new List<Shape>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Shape #{i + 1} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                char op = char.Parse(Console.ReadLine().ToLower());
                Console.Write("Coloro (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if ( op == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Circle(radius, color));
                }
            }

            Console.WriteLine();   
            Console.WriteLine("SHAPE AREAS:");            
            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
            
        }
    }
}