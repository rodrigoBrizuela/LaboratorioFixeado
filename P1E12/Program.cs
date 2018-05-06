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
        // Comision 2
        // Aybar Critto, Nicolas Exequiel
        // Ejercicio 12

        static void Main(string[] args)
        {
            // declaramos
            decimal _i = 0; // valor inicial
            decimal _num = 0; // valor que ingresa el usuario
            // condicion while
            string _deseaCalcular = "S";
            

            // OPERAMOS.

            while(_deseaCalcular.ToUpper() == "S")  // while se hace antes del if
            {
                Console.Clear();
                Console.WriteLine("Ingrese el numero que quiera disminuir en forma par hasta el numero 2.");
                if (decimal.TryParse(Console.ReadLine(), out _num))
                {
                    if (_num % 2 == 0) // Condicion para cuando ingrese un numero impar
                    {
                        for (_i = _num; _i >= 2; _i = _i - 2)
                        {
                            Console.WriteLine(_i.ToString("00"));
                        }
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
                Console.WriteLine();
                Console.WriteLine("Desea hacer descender otro numero? [S para SI - N para NO]");
                _deseaCalcular = Console.ReadLine();
                Console.WriteLine("Presione cualquier tecla para finalizar...");
            }       
            Console.ReadKey();
        }
        
    }
}
