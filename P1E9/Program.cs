using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1E9
{
    class Program
    {
        static void Main(string[] args)
        {
            // declarar variables
           
            decimal _base = 2; // numero 2
            decimal _exponente = 0m; // potencia
            decimal _resultado = 0m; // resultado final
            int _contador = 0;
            bool _bandera = false;
            Console.Clear();

            // operamos
            while (_bandera == false)
            {
                Console.WriteLine("Ingrese la potencia a la que desea elevar el numero 2.");
                if (decimal.TryParse(Console.ReadLine(), out _exponente))
                {
                    _resultado = _base;
                    while (_contador < _exponente)
                    {
                        _resultado = _resultado * _base;
                        _contador++;

                    }

                    Console.WriteLine($"\nEl resultado de {_base} elevado a la {_exponente} es {_resultado}\nPresione cualquier tecla para finalizar");
                    _bandera = true;
                }
                else {
                    Console.WriteLine("Por favor ingrese un numero valido.");
                      }
            }
          

            Console.ReadKey();
        }
    }
}
