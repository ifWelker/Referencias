using System;
using RefExtensionMethods.Extensions;

namespace RefExtensionMethods
{

    //Essa Demo ela esta sendo usada para verificar o tanto de tempo que foi passado a partir de uma data até a data atual do sistema.
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2023, 05, 01, 22, 59, 45);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}