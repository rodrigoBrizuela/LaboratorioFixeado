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

            // Declaro las variables
            decimal _numero = 0m;
            bool _bandera = false;
            Console.Clear();

           

            //operamos
            while (_bandera == false) // while antes de las condiciones
            {
                Console.Clear();
                Console.WriteLine("Ingrese un numero: ");
                if (decimal.TryParse(Console.ReadLine(), out _numero))
                {
                    if (_numero % 2 != 0)
                    {
                        Console.WriteLine("El numero ingresado es impar.");
                    }

                    else if (_numero == 0)
                    {
                        Console.WriteLine("El numero ingresado es cero.");
                    }
                    else
                    {
                        Console.WriteLine("El numero ingresado es par.");
                    } _bandera = true; // quiero que se cumplan las condiciones del while hasta aqui
                }
                else
                {
                    Console.WriteLine("Ingreso un caracter no valido. Por favor ingrese un numero.");
                    Console.Write("Presione cualquier tecla para reiniciar.");
                }
                Console.ReadKey();
            }
        }
    }
}
            
 