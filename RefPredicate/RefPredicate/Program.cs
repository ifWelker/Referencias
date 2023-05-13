using System;
using RefPredicate.Entities;

//Fazer um Programa que, a partir de uma lista de produtos, remova da lista somente aqueles cujo preço minimo seja 100.

namespace RefPredicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            list.RemoveAll(ProductTest);
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        public static bool ProductTest(Product p) 
        {
            return p.Price >= 100;
        }
    }
}
