using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1E13
{
    class Program
    {
        static void Main(string[] args)
        {
            // Capturar los valores ingresados por el usuario
            Console.Write("Ingrese la primer nota: ");
            string _notaStr1 = Console.ReadLine();
            Console.Write("Ingrese la segunda nota: ");
            string _notaStr2 = Console.ReadLine();
            Console.Write("Ingrese la tercera nota: ");
            string _notaStr3 = Console.ReadLine();
           

            decimal _nota1 = 0m; // se escribe el 0m; para determinar que el 0 tiene decimales.
            decimal _nota2 = 0m;
            decimal _nota3 = 0m;
            decimal _promedio = 0m;

            if (decimal.TryParse(_notaStr1, out _nota1))
            {
                if (decimal.TryParse(_notaStr2, out _nota2))
                {
                    if (decimal.TryParse(_notaStr3, out _nota3))
                    {
                        // Aqui opero, hago los 3 if uno dentro de otro, porque tiene que pasar las tres validaciones.
                        // Si no pasa una validacion, se deriva directamente al else correspondiente
                        Console.WriteLine(); // Deja un espacio en blanco. Salto de linea. 

                        _promedio = (_nota1 + _nota2 + _nota3) / 3;

                        if (_promedio == 10)
                        {
                            Console.WriteLine("Excelente");
                        }
                        if(_promedio >= 7 && _promedio < 10)
                        {
                            Console.WriteLine("Muy bueno");
                        }
                        if (_promedio >= 4 && _promedio < 7)
                        {
                            Console.WriteLine("Bueno");
                        }
                        if (_promedio >= 0 && _promedio < 4)
                        {
                            Console.WriteLine("Regular");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ocurrio un error al ingresar la tercera nota.");
                    }
                }
                else
                {
                    Console.WriteLine("Ocurrio un error al ingresar la segunda nota.");
                }
            }
            else
            {
                Console.WriteLine("Ocurrio un error al ingresar la primera nota.");

            }
             Console.ReadKey(); // Lee lo que ingresa el usuario

        }
    }
}