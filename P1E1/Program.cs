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
            decimal _base = 0m; // Declaro e inicicializo en 0 ( la m equivale a ,00 )
            decimal _superficie = 0m; // Declaro
            Console.Clear();
            Console.WriteLine("Ingrese la base del triangulo: ");
           

            if (decimal.TryParse(Console.ReadLine(), out _base)) // Console.ReadLine -> lee el valor que ingresa el usuario
            {
                // operar
                _superficie = (_base * (_base * 3)) / 2;
                Console.WriteLine($"La superficie es: {_superficie}");

            }
            else
            {
                Console.WriteLine("Ocurrio un error, ingrese un caracter numerico.");
            }
                Console.ReadKey();
        }
    }
}
