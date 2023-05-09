using System;

namespace ExerConjuntos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> courseA = new HashSet<int>();
            HashSet<int> courseB = new HashSet<int>();
            HashSet<int> courseC = new HashSet<int>();

            Console.WriteLine("How many Students for Course A");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                courseA.Add(cod);
            }


            Console.WriteLine("How many Students for Course B");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                courseB.Add(cod);
            }


            Console.WriteLine("How many Students for Course C");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                courseC.Add(cod);
            }

            HashSet<int> all = new HashSet<int>(courseA);
            all.UnionWith(courseB);
            all.UnionWith(courseC);
            Console.WriteLine("Total students: " + all.Count);
        }
    }
}