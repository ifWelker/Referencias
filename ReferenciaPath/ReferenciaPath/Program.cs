using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace ReferenciaPath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\myfolder\file.txt";

            Console.WriteLine(Path.DirectorySeparatorChar);

            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
        }
    }
}
