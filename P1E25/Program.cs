﻿using System;
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

            //Clima
            decimal _celsius = 0m;
            decimal _farenheit = 0m;

            //Variable while
            string _deseaCalcularOtro = "S";

            // Operar
            while(_deseaCalcularOtro.ToUpper() == "S")
            {
                Console.Clear();
                Console.WriteLine("Ingrese la cantidad de grados Celsius que desea convertir a Farenheit: ");
                if(decimal.TryParse(Console.ReadLine(), out _celsius))
                {
                    _farenheit = _celsius * (9m / 5m) + 32; // Formula para pasar de Celsius a Farenheit. // Agregar m a la formula division para convertir a decimal

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
