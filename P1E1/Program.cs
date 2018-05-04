using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1E1
{ 
    class Program
    {
        // Tecnicatura Superior en Programacion
        // Comision 2
        // Aybar Critto, Nicolas Exequiel
        // Ejercicio 1

        static void Main(string[] args)
        {
            // declaro variables
            decimal _base = 0m;
            decimal _resultado = 0m;

            // While
            string _deseaCalcular = "S";

            while(_deseaCalcular.ToUpper() == "S")
            {
                Console.Clear();
                //Opero
                Console.WriteLine("Ingrese una base: ");
                if (decimal.TryParse(Console.ReadLine(), out _base))
                {
                    _resultado = _base * (_base * 3) / 2;
                    Console.WriteLine($"La superficie del rectangulo cuya base es el triple de su altura es: {_resultado}");
                }
                else
                {
                    Console.WriteLine("Ocurrio un error al ingresar la base. Por favor ingrese la base con caracteres numericos");
                }
                Console.WriteLine();
                Console.WriteLine("Desea calcular otra superficie? [S para SI - N para NO]");
                _deseaCalcular = Console.ReadLine();
                Console.WriteLine("Presione cualquier tecla para finalizar...");
            }
            Console.ReadKey();
        }
    }
}