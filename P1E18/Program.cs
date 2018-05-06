using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1E18
{
    class Program
    {
        // Tecnicatura Superior en Programacion
        // Aybar Critto, Nicolas Exequiel
        // COMISION 2
        // Ejercicio 18

        static void Main(string[] args)
        {
            // DECLARAR
            decimal _centimetros = 0m;
            decimal _pulgada = 0m;
            decimal _conversorPulgadas = 2.54m;
            string _deseaIngresarNum = "S";

            // OPERAR
            
            while (_deseaIngresarNum.ToUpper() == "S")
            {
                Console.Clear(); // borrar consola {} primera linea del while
                Console.WriteLine("Ingrese la cantidad de centimetros que desee convertir a pulgadas");
                if (decimal.TryParse(Console.ReadLine(), out _centimetros))
                {
                    _pulgada = (_centimetros / _conversorPulgadas); // Operacion de conversion

                    Console.WriteLine($"La cantidad de {_centimetros} centimetros equivale a {_pulgada} pulgadas.");
                    
                }
                else
                {

                    Console.WriteLine("Por favor ingrese una cantidad en centimetros.");
                }
                Console.WriteLine();
                Console.WriteLine("Desea convertir otro numero? [S para NO - N para NO]");
                _deseaIngresarNum = Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
