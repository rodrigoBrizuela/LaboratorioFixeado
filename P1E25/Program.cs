using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1E25
{
    class Program
    {
        // Tecnicatura Superior en Programacion
        // Comision 2
        // Aybar Critto, Nicolas Exequiel
        // Ejercicio 25

        static void Main(string[] args)
        {
            //Deportes

            decimal _natacion = 0m;
            decimal _tenis = 0m;
            decimal _golf = 0m;
            decimal _esqui = 0m;
            decimal _otros = 0m;

            //Clima
            decimal _clima = 0m;
            decimal _celsius = 0m;
            decimal _farenheit = 0m;

            //Variable while
            string _deseaCalcularOtro = "S";

            // Operar
            while(_deseaCalcularOtro.ToUpper() == "S")
            {
                Console.Clear();
                Console.WriteLine("Ingrese la cantidad de grados Celcius que desea convertir a Farenheit: ");
                if(decimal.TryParse(Console.ReadLine(), out _celsius))
                {
                    _farenheit = ((9/ 5) * _celsius) + 32;

                   if (_farenheit <= 32)
                   {
                        Console.WriteLine($"La cantidad de grados {_celsius} Celsius equivale a {_farenheit} Farenheit. Esta ideal para practicar otros deportes distintos al Esqui, Golf, Tenis y Natacion.");
                   }
                   else if (_farenheit > 32 && _farenheit <= 35)
                   {
                        Console.WriteLine($"La cantidad de grados {_celsius} Celsius equivale a {_farenheit} Farenheit. Esta ideal para practicar Esqui.");
                   }
                   else if (_farenheit > 35 && _farenheit <= 70)
                   {
                        Console.WriteLine($"La cantidad de grados {_celsius} Celsius equivale a {_farenheit} Farenheit. Esta ideal para practicar Golf.");
                   }
                   else if (_farenheit > 70 && _farenheit <= 85)
                   {
                        Console.WriteLine($"La cantidad de grados {_celsius} Celsius equivale a {_farenheit} Farenheit. Esta ideal para practicar Tenis.");
                   }
                   else if (_farenheit > 85)
                   {
                        Console.WriteLine($"La cantidad de grados {_celsius} Celsius equivale a {_farenheit} Farenheit. Esta ideal para practicar Natacion.");
                   }
                   
                }
                else
                {
                    Console.WriteLine("Ocurrio un error al convertir la temperatura. Por favor ingrese un caracter valido");
                }
                Console.WriteLine();
                Console.WriteLine("Desea convertir otra temperatura? [S para SI - N para NO]");
                _deseaCalcularOtro = Console.ReadLine();
                Console.WriteLine("Presione cualquier tecla para finalizar...");
            }
            Console.ReadKey();

        }
    }
}
