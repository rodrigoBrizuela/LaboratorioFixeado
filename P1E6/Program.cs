using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1E6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Listado de numeros del 1 al 100");

            int numeros = 0;

            for (numeros = 1; numeros <= 100; numeros++)
            {
                Console.WriteLine(numeros.ToString("000")); // Convierte el valor 000 en n
            }
            Console.ReadKey();
        }
    }
}
