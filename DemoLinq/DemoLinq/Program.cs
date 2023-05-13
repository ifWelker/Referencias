using System;
using DemoLinq.Entities;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace DemoLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Print<T>(string message, IEnumerable<T> collection) //Função para print na tela
            {
                Console.WriteLine(message);
                foreach (T obj in collection)
                {
                    Console.WriteLine(obj);
                }
                Console.WriteLine();
            }

            Category c1 = new Category()
            {
                Id = 1,
                Name = "Tools",
                Tier = 2
            };
            Category c2 = new Category()
            {
                Id = 2,
                Name = "Computers",
                Tier = 1
            };
            Category c3 = new Category()
            {
                Id = 3,
                Name = "Eletronics",
                Tier = 1
            };

            List<Product> products = new List<Product>()
            {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c3 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "Macbook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };

            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0); //Esse Filtra Produtos por Tier e abaixo de 900
            var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name); //Esse filtra por categoria e mostra somente o Nome
            var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name }); //Esse filtra os nomes que começam com C, mostrando nome, preço e categoria.
            var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            var r5 = r4.Skip(2).Take(4);
            var r6 = products.First();
            var r7 = products.Where(p => p.Price > 3000.0).FirstOrDefault();
            var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
            var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
            var r10 = products.Max(p => p.Price);
            var r11 = products.Min(p => p.Price);
            var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate((x, y) => x + y);
            var r16 = products.GroupBy(p => p.Category);




            Print("TIER 1 And Price < 900: ", r1);

            Print("Names of Products From Tools: ", r2);

            Print("Names started with 'C' and Anonymous Objetct", r3);

            Print("Tier 1 order by Price the by Name", r4);

            Print("Tier 1 order by Price the by Name Skip 2 Take 4", r5);

            Console.WriteLine("First or default Teste 1: " + r6);

            Console.WriteLine("First or default Teste 2: " + r7);

            Console.WriteLine("Single or default Teste 1: " + r8);

            Console.WriteLine("Single or default Teste 2: " + r9);

            Console.WriteLine("Max Price: " + r10);

            Console.WriteLine("Min Price: " + r11);

            Console.WriteLine("Category 1 Sum prices: " + r12);

            Console.WriteLine("Category 1 Average prices: " + r13);

            Console.WriteLine("Category 5 Average prices: " + r14);

            Console.WriteLine("Category 1 Aggregate sum: " + r15);

            Console.WriteLine();

            foreach (IGrouping<Category, Product> group in r16)
            {
                Console.WriteLine("Category: " + group.Key.Name + ":");
                foreach(Product p  in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }

        }
    }
}
