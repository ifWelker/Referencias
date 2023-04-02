using System;
using Heranca2.Entities;

namespace Heranca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0, 500);

            // UPCASTING - Converte uma SubClasse em uma SuperClasse

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0, 200);
            Account acc3 = new SavingsAccount(1004, "Ana", 0, 0.01);

            //DOWNCASTING - Converte uma SuperClasse em uma SubClasse

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);

            //BusinessAccount acc5 = (BusinessAccount)acc3;
            if (acc3 is BusinessAccount)
            {
               // BusinessAccount acc5 = (BusinessAccount)acc3; - Uma das Formas de Fazer o Casting
               BusinessAccount acc5 = acc3 as BusinessAccount; //Essa é a outra Forma de Fazer o Casting
                acc5.Loan(200);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }

        }
    }
}