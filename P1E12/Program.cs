using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1E12
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaramos
            decimal _n = 0; // valor inicial
            decimal _ingresado = 0; // valor que ingresa el usuario
            Console.Clear();

            // operamos
            Console.WriteLine("Ingrese el numero que quiera disminuir en forma par hasta el numero 2.");
            if(decimal.TryParse(Console.ReadLine(), out _ingresado))
            {
                if(_ingresado % 2 == 0) // Condicion para cuando ingrese un numero impar
                for(_n = _ingresado; _n >= 2; _n = _n - 2)
                {
                    Console.WriteLine(_n.ToString("0"));
                }
                else
                {
                    Console.WriteLine("Por favor ingrese un numero par");
                }
            }
            else
            {
                Console.WriteLine("Ha introducido un caracter no valido. Por favor ingrese un numero par");
            }
            Console.ReadKey();
        }
    }
}
