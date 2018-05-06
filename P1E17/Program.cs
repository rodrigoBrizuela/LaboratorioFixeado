using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1E17
{
    class Program
    {
        // Tecnicatura Superior en Programacion
        // Aybar Critto, Nicolas Exequiel
        // COMISION 2
        // Ejercicio 17

        static void Main(string[] args)
        {
            //Declaracion variables

            int _numero = 0;
            int _ultimaCifra = 0;

            // Variable while
            string _deseaCalcular = "S";

            while (_deseaCalcular.ToUpper() == "S")
            {
                Console.Clear();
                Console.WriteLine("Por favor introduzca el numero del cual desea obtener la ultima cifra:");
                if (int
                    .TryParse(Console.ReadLine(), out _numero))

                {
                    _ultimaCifra = _numero % 10;
                    Console.WriteLine($"La ultima cifra del numero ingresado es: {_ultimaCifra}");
                }
                else
                {
                    Console.WriteLine("Ocurrio un error. Por favor ingrese un numero.");
                }
                Console.WriteLine();
                Console.WriteLine("Desea obtener la ultima cifra de otro numero? [S para SI - N para NO]");
                _deseaCalcular = Console.ReadLine();
                Console.WriteLine("Presione cualquier tecla para finalizar...");
            }
            Console.ReadKey();
        }
    }
}
