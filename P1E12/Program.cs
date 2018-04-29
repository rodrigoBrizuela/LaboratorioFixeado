using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1E12
{
    class Program
    {
        // Tecnicatura Superior en Programacion
        // Aybar Critto, Nicolas Exequiel
        // Ejercicio 12

        static void Main(string[] args)
        {
            // declaramos
            decimal _i = 0; // valor inicial
            decimal _num = 0; // valor que ingresa el usuario
            bool _bandera = false;
            Console.Clear();

            // operamos

            while(_bandera == false)  // while se hace antes del if
            {
                Console.Clear();
                Console.WriteLine("Ingrese el numero que quiera disminuir en forma par hasta el numero 2.");
                if (decimal.TryParse(Console.ReadLine(), out _num))
                {
                    if (_num % 2 == 0) // Condicion para cuando ingrese un numero impar
                    {
                        for (_i = _num; _i >= 2; _i = _i - 2)
                        {
                            Console.WriteLine(_i.ToString("0"));
                        }
                        _bandera = true; // bandera true antes de los else
                    }
                    else
                    {
                        Console.WriteLine("Por favor ingrese un numero par");
                    }
                }
                else
                {
                    Console.WriteLine("\nHa introducido un caracter no valido. Por favor ingrese un numero par");
                }
                Console.ReadKey();
            }

        }
    }
}
