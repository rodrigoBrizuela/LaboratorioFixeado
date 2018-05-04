using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1E5
{
    class Program
    {
        // Tecnicatura Superior en Programacion
        // Comision 2
        // Aybar Critto, Nicolas Exequiel
        // Ejercicio 5

        static void Main(string[] args)
        {
            //Declaro variable
            int _i = 0;

            Console.Clear();
     
            // operamos

            for (_i = 1; _i < 11; _i ++) // La sentencia FOR toma el valor i final -1

            {
                Console.WriteLine(_i.ToString("00")); // Pongo "00" para darle un mejor formato visual
            }

            Console.ReadKey();
        }
    }
}
