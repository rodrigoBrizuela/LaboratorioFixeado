﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1E6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaro variables
            int _numero = 0;
            Console.Clear();

            // OPERAMOS
            Console.WriteLine("Listado de numeros del 1 al 100 con su respectivo cuadrado");
            for (_numero = 1; _numero <= 100; _numero++)
            {
                Console.WriteLine($"{_numero} y su cuadrado es: {_numero * _numero}");  // 
            }
            Console.ReadKey();
        }
    }
}
