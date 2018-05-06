using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1E11
{
    class Program
    {
        // Tecnicatura Superior en Programacion
        // Comision 2
        // Aybar Critto, Nicolas Exequiel
        // Ejercicio 11


        static void Main(string[] args)
        {
            //declarar
            double _x = 0; // numero base
            double _n = 0; // exponente
            double _resultado = 0; // resultado

            //declaracion while
            string _deseaCalcular = "S";

            // OPERAR

            while (_deseaCalcular.ToUpper() == "S")
            {
                Console.Clear();
                Console.WriteLine("Ingrese un numero: ");
                if (double.TryParse(Console.ReadLine(), out _x))
                {
                    Console.WriteLine("Ingrese el exponente al que desea elevar el numero:");
                    {
                        if (double.TryParse(Console.ReadLine(), out _n))
                        {
                            _resultado = Math.Pow(_x, _n);
                            Console.WriteLine($"El numero {_x} elevado a la {_n} es igual a {_resultado}");
                        }
                        else
                        {
                            Console.WriteLine("Ocurrio un error. Por favor ingrese un caracter valido.");
                        }

                    }
                }
                else
                {
                    Console.WriteLine("Ocurrio un error. Por favor ingrese un caracter valido.");
                }

                Console.WriteLine();
                Console.WriteLine("Desea calcular otro numero? [S para SI - N para NO]");
                _deseaCalcular = Console.ReadLine();
                Console.WriteLine("Presione cualquier tecla para finalizar...");
            }
            Console.ReadKey();
        }
    }
}
