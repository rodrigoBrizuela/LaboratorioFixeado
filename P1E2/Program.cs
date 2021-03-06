﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1E2
{
    class Program
    {
        // Tecnicatura Superior en Programacion
        // Comision 2
        // Aybar Critto, Nicolas Exequiel
        // Ejercicio 2

        static void Main(string[] args)
        {
            // Declaro las variables
            decimal _altura = 0m;
            decimal _base = 0m;
            decimal _superficie = 0m;
            decimal _perimetro = 0m;

            // Declaracion while
            string _deseaCalcular = "S";


            while (_deseaCalcular.ToUpper() == "S")
            {
                Console.Clear();

                // operamos
                Console.WriteLine("Ingrese la base: ");
                if (decimal.TryParse(Console.ReadLine(), out _base)) // Aqui se indica que al _valorbase se lo trata de convertir en decimal.
                {
                    Console.WriteLine("Ingrese la altura: "); // WriteLine para separar uno de otro
                    if (decimal.TryParse(Console.ReadLine(), out _altura))
                    {
                        _superficie = (_base * _altura); // opero primero
                        Console.WriteLine($"La superficie de tu rectangulo es: {_superficie}"); // despues muestro mensaje
                        _perimetro = ((_base * 2) + (_altura * 2));
                        Console.WriteLine($"El perimetro de tu rectangulo es: {_perimetro}");
                    }
                    else
                    {
                        Console.WriteLine("Ocurrio un error al ingresar la altura"); // error en caso de que ingrese un caracter no valido el usuario
                    }
                }
                else
                {
                    Console.WriteLine("Ocurrio un error al ingresar la base");
                }
                Console.WriteLine();
                Console.WriteLine("Desea calcular otra superficie? [S para SI - N para NO]");
                _deseaCalcular = Console.ReadLine();
                Console.WriteLine("Presione cualquier tecla para finalizar...");
            }
            Console.ReadKey(); // Importante finalizar con un readkey, de esta manera el programa lee los caracteres ingresados por el usuario y no cierra el programa        
        }

    }
}

