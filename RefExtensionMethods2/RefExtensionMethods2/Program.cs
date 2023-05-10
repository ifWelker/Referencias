using System;
using RefExtensionMethods.Extensions;

namespace RefExtensionMethods2
{

    internal class Program
    {
        static void Main(string[] args)
        {
            string S1 = "Good moorning dead students";
            Console.WriteLine(S1.Cut(10));
        }
    }
}