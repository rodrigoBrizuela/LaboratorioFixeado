using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1E8
{
    class Program
    {
        // Tecnicatura Superior en Programacion
        // Comision 2
        // Aybar Critto, Nicolas Exequiel
        // Ejercicio 8

        static void Main(string[] args)
        {
            // DECLARAR
            int _par = 0;
            int _impar = 0;
            Console.Clear();

            // Operamos
            Console.WriteLine("Listado numeros impares del 1 al 999");
            Console.WriteLine("Presione cualquier tecla para mostrar los numeros impares.");
            Console.ReadKey();
            for (_impar = 1; _impar <= 999; _impar = _impar + 2)
            {
                Console.WriteLine(_impar.ToString("000"));
            }
            Console.WriteLine();
            Console.WriteLine("Listado numeros pares del 2 al 1000");
            Console.WriteLine("Presione cualquier tecla para mostrar los numeros pares.");
            Console.ReadKey();
            for (_par = 2; _par <= 1000; _par = _par + 2)
            {
                Console.WriteLine(_par.ToString("000"));
            }
            Console.WriteLine("Presione cualquier tecla para finalizar.");
            Console.ReadKey();
        }
    }
}
