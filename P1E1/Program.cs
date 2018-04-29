using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1E1
{ 
    class Program
    {
        static void Main(string[] args)
        {
            // declaro variables
            decimal _base = 0m;
            decimal _resultado = 0m;

            Console.Clear();
            //Opero
            Console.WriteLine("Ingrese una base: ");
            if(decimal.TryParse(Console.ReadLine(), out _base))
            {
                _resultado = _base * (_base * 3) / 2;
                Console.WriteLine($"La superficie del rectangulo cuya base es el triple de su altura es: {_resultado}");
            }

            Console.ReadKey();

        }
    }
}