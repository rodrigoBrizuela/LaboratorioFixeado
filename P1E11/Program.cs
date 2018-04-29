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
        // Aybar Critto, Nicolas Exequiel
        // Ejercicio 11


        static void Main(string[] args)
        {
            //declarar
            int _x = 0; // numero base
            int _n = 0; // exponente
            int _y = 0; // resultado
            bool _bandera = false; //  bandera while

            Console.Clear();

            while (_bandera == false)
            {
                Console.WriteLine("Ingrese un numero: ");
                if (int.TryParse(Console.ReadLine(), out _x))
                {
                    Console.WriteLine("Ingrese el exponente al que desea elevar el numero:");
                    {
                        if (int.TryParse(Console.ReadLine(), out _n))
                        {
                            _y = 1; // El resultado no puede ser 0, esto ayuda a que un numero elevado a la 0 es = a 1
                            for (int _i = 1; _i <= _n; _i++) // declaro la variable de inicializacion int _i para el for
                            {
                                _y = (_x * _y); // formula para obtener el exponente ( Resultado = base x resultado )
                            }
                            Console.WriteLine($"El numero {_x} elevado a la {_n} es igual a {_y}");
                            _bandera = true;
                        }
                        else
                        {
                            Console.WriteLine("Por favor ingrese un caracter valido.");
                        }

                    }
                }
                else
                {
                    Console.WriteLine("Por favor ingrese un caracter valido.");

                }
            }
            Console.ReadKey();
        }
    }
}
