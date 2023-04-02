using System;
using ReferenciaHeranca.Entities;

namespace ReferenciaHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
           BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100, 500);

            Console.WriteLine(account.Balance);
        }
    }
}