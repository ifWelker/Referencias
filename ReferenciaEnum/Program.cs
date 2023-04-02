using CursoCSharp.Entities;
using CursoCSharp.Entities.Enuns;
using System;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order()
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);

            Console.WriteLine(txt);
        }
    }
}