using System;
using ExercicioException.Entities;
using ExercicioException.Entities.Exceptions;

class Program
{
    static void Main()
    {
        Console.Write("Enter account data: ");
        Console.Write("Number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Holder: ");
        string holder = Console.ReadLine();
        Console.Write("Initial Balance: ");
        double balance = double.Parse(Console.ReadLine());
        Console.WriteLine("WithDraw Limit: ");
        double withdrawLimit = double.Parse(Console.ReadLine());

        Account acc = new Account(number, holder, balance, withdrawLimit);

        Console.WriteLine();
        Console.Write("Enter amount for withdraw: ");
        double amount = double.Parse(Console.ReadLine());
        try
        {
            acc.Withdraw(amount);
            Console.WriteLine("New Balance: " + acc.Balance.ToString("F2"));
        }
        catch (DomainException e)
        {
            Console.WriteLine("Error Withdraw: " + e.Message);
        }
    }
}