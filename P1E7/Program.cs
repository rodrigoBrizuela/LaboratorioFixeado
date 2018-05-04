using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1E7
{
    class Program
    {
        // Tecnicatura Superior en Programacion
        // Comision 2
        // Aybar Critto, Nicolas Exequiel
        // Ejercicio 7

        static void Main(string[] args)
        {

            // Declaro las variables
            decimal _numero = 0m;

            //Variable while
            string _deseaCalcular = "S";



            //operamos
            while (_deseaCalcular.ToUpper() == "S") // while antes de las condiciones
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
                        Console.WriteLine("El numero ingresado es neutro.");
                    }
                    else
                    {
                        Console.WriteLine("El numero ingresado es par.");
                    }
                }
                else
                {
                    Console.WriteLine("Ingreso un caracter no valido. Por favor ingrese un numero.");

                }
                Console.WriteLine();
                Console.WriteLine("Desea calcular otro numero? [S para SI - N para NO]");
                _deseaCalcular = Console.ReadLine();
                Console.WriteLine("Presione cualquier tecla para finalizar...");

            }
            Console.ReadKey();
        }

    }
}
            
 