using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la base del triangulo: ");
            string valorPantalla = Console.ReadLine();
            decimal _base = 0m; // Declaro e inicicializo en 0 ( la m equivale a ,00 )
            decimal _superficie = 0m; // Declaro.
            _base = decimal.Parse(valorPantalla); // Convierto el valorpantalla a decimal

            if (decimal.TryParse(valorPantalla, out _base))
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
