using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1E14
{
    class Program
    {
        // Tecnicatura Superior en Programacion
        // Comision 2
        // Aybar Critto, Nicolas Exequiel
        // Ejercicio 14

        static void Main(string[] args)
        {
            //DECLARAR
            decimal _millas = 0m;
            decimal _metros = 0m;
            decimal _conversor = 1852m;

            // operacion while
            string _deseaCalcular = "S";

            // Operar
            while(_deseaCalcular.ToUpper() == "S")
            {
                Console.Clear();


                Console.WriteLine("Ingrese la cantidad de millas marinas que desea convertir a metros.");
                if (decimal.TryParse(Console.ReadLine(), out _millas))

                {
                    _metros = (_millas * _conversor);
                    Console.WriteLine($"La cantidad de millas marinas ingresadas equivale a {_metros} metros");
                }
                else
                {
                    Console.WriteLine("Ocurrio un error. Por favor ingrese un numero valido.");
                }

                Console.WriteLine();
                Console.WriteLine("Desea convertir otro numero? [S para SI - N para NO]");
                _deseaCalcular = Console.ReadLine();
                Console.WriteLine("Presione cualquier tecla para finalizar...");
            }
            Console.ReadKey();
        }
    }
}
