using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1E7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Ingrese un numero: ");
            decimal _numero = 0m;

            if (decimal.TryParse(Console.ReadLine(), out _numero))
            {
                if (_numero % 2 == 0)
                {
                    Console.WriteLine("El numero ingresado es par.");
                }

                else if (_numero == 0)
                {
                    Console.WriteLine("El numero ingresado es cero.");
                }
                else
                {
                    Console.WriteLine("El numero ingresado es impar.");
                }
            }
            else
            {
                Console.WriteLine("Ingreso un caracter no valido. Por favor intente nuevamente");
            }
            Console.ReadKey();
        }
           
    }
}

