using ExercicioAbstract.Entities;
using ExercicioAbstract.Entities.Enums;
using System;
using System.Globalization;

namespace ExercicioAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();
            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) 
            {
                Console.Write($"Shape #{i} Data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                char rc = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (rc == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Heigth: ");
                    double height = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.WriteLine("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));
                }
            }
            Console.WriteLine();
            Console.Write("Shape Areas: ");
            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}