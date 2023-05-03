using System;

namespace Generics
{
    class Program
    { //Com a parametrização, podemos fazer uso do TypeSafety, ou seja, no programa, colocamos o Tipo da variavel que desejamos, como por exemplo a linha abaixo representado por <int>
        //Isso evita erro na execução do codigo~, e aumentando a performace do codigo.
        static void Main(string[] args)
        {
            PrintService<int> printService = new PrintService<int>();

            Console.Write("How many Values: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x =int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }

            int a = printService.First();
            int b = a + 2;
            

            printService.Print();
            Console.WriteLine("First: " + printService.First());

        }
    }
}