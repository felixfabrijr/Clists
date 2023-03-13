using System;

namespace Clists
{
    class Program
    {
        static void Main(string[] args)
        {
            var nomes = new List<string> { "<nome>", "Ana", "Felipe" };

            foreach (var nome in nomes)
            {
                Console.WriteLine($"Ola {nome.ToUpper()}!");
            }
        }
    }
}
