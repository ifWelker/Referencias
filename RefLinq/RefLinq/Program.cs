using System;
using System.Linq;

namespace RefLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Linq é feito atraves de 3 passos:

            // 1º Definir o Data Source (array, coleção, array, recurso de E/S, arquivo, banco de dados, etc.)
            int[] numbers = new int[] { 2, 3, 4, 5, };

            // 2º Definir A Consulta (Query)
            IEnumerable<int> result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            // 3º Executar a Consulta (Query)
            foreach (int x in result)
            {
                Console.WriteLine(x);
            }

        }
    }
}
