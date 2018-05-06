using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1E13
{
    class Program
    {
        // Tecnicatura Superior en Programacion
        // Comision 2
        // Aybar Critto, Nicolas Exequiel
        // Ejercicio 13

        static void Main(string[] args)
        {
            // DECLARAR VALORES

            decimal _nota1 = 0m;
            decimal _nota2 = 0m;
            decimal _nota3 = 0m;
            decimal _promedio = 0m;

            // Condicion while
            string _deseaCalcular = "S";

            // OPERAMOS
            
            while(_deseaCalcular.ToUpper() == "S")
            {
                Console.Clear();
                Console.WriteLine("Por favor ingrese la primera nota:");
                if (decimal.TryParse(Console.ReadLine(), out _nota1))
                {
                    Console.WriteLine("Por favor ingrese la segunda nota:");
                    if (decimal.TryParse(Console.ReadLine(), out _nota2))
                    {
                        Console.WriteLine("Por favor ingrese la tercera nota:");
                        if (decimal.TryParse(Console.ReadLine(), out _nota3))
                        {
                            // Aqui opero, hago los 3 if uno dentro de otro, porque tiene que pasar las tres validaciones.
                            // Si no pasa una validacion, se deriva directamente al else correspondiente
                            Console.WriteLine(); // Deja un espacio en blanco. Salto de linea. 
                            _promedio = (_nota1 + _nota2 + _nota3) / 3;

                            if (_promedio > 10)
                            {
                                Console.WriteLine("El promedio no puede ser mayor a 10. Por favor revise las notas e ingreselas nuevamente.");
                            }
                            if (_promedio == 10)
                            {
                                Console.WriteLine("Excelente");
                            }
                            if (_promedio >= 7 && _promedio < 10)
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
                Console.WriteLine();
                Console.WriteLine("Desea calcular otro promedio? [S para SI - N para NO]");
                _deseaCalcular = Console.ReadLine();
                Console.WriteLine("Presione cualquier tecla para finalizar...");
            }      
             Console.ReadKey(); // Lee lo que ingresa el usuario
        }
    }
}