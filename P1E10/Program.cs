using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1E10
{
    class Program
    {
        // Tecnicatura Superior en Programacion
        // Comision 2
        // Aybar Critto, Nicolas Exequiel
        // Ejercicio 10

        static void Main(string[] args)
        {
            //almacenamiento de los valores mayor menor
            int _mayor = 0;
            int _menor = 0;
            //
            int _numero = 0;
            Random _generador = new Random(); // Generador de numeros aleatorios

            Console.Clear();

            Console.WriteLine("Numeros a ingresar: ");

            for (int _i = 1; _i <= 20; _i++)
            {
                _numero = _generador.Next(100);
                Console.WriteLine(_numero.ToString("00"));
                if(_numero > _mayor)
                {
                    if(_mayor > _menor)
                    {
                        _menor = _mayor;
                        _mayor = _numero;
                    }
                    else
                    {
                        _mayor = _numero;
                    }
                }
                else if (_numero >= _menor && _numero < _mayor)
                {
                    _menor = _numero;
                
                }
            }
            Console.WriteLine($"El numero mayor es {_mayor} y el menor es {_menor}");
            Console.ReadKey();
        }
    }
}
