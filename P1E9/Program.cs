using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1E9
{
    class Program
    {
        // Tecnicatura Superior en Programacion
        // Comision 2
        // Aybar Critto, Nicolas Exequiel
        // Ejercicio 9

        static void Main(string[] args)
        {
            // declarar variables
           
            double _base = 2; // numero 2
            double _exponente = 0; // potencia
            double _resultado = 0; // resultado final

            // declaracion while
            string _deseaCalcular = "S";
            

            // operamos
            while (_deseaCalcular.ToUpper() == "S")
            {
                Console.Clear();
                Console.WriteLine("Ingrese la potencia a la que desea elevar el numero 2.");
                if (double.TryParse(Console.ReadLine(), out _exponente))
                {
                    _resultado = Math.Pow(_base, _exponente);

                    
                }
                else
                {
                    Console.WriteLine("Ocurrio un error. Por favor ingrese un numero valido.");
                }

                Console.WriteLine($"\nEl resultado de {_base} elevado a la {_exponente} es {_resultado}.");
                Console.WriteLine();
                Console.WriteLine("Desea calcular otro numero? [S para SI - N para NO]");
                _deseaCalcular = Console.ReadLine();
                Console.WriteLine("Presione cualquier tecla para finalizar...");

            }
            Console.ReadKey();
        }
    }
}
