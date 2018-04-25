using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1E14
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARAR
            decimal _millas = 0m;
            decimal _metros = 0m;

            Console.Clear();

            // Operar
            Console.WriteLine("Ingrese la cantidad de millas marinas que desea convertir a metros.");
            if (decimal.TryParse(Console.ReadLine(), out _millas))
                
            {
                _metros = (_millas * 1852);
                Console.WriteLine($"La cantidad de millas marinas ingresadas equivale a {_metros} metros");
            }

            Console.ReadKey();
        }
    }
}
