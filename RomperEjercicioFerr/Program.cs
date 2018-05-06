using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1E16
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Universidad Tecnologica Nacional
             * Tecnicatura Superior en Programación
             * Comision 2
             * D.N.I 42.269.771
             * Adad, Fernando Yamil
             * Ejercicio 16
             */

            int _num1 = 0;
            int _num2 = 0;
            bool _finPrograma = false;

            while (_finPrograma == false)
            {
                Console.Clear();
                Console.Write("No ingrese 0.\nIngrese un numero entero: ");
                if (int.TryParse(Console.ReadLine(), out _num1) && _num1 != 0)
                {
                    Console.Write("Ingrese otro numero entero: ");

                    if (int.TryParse(Console.ReadLine(), out _num2) && _num2 != 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Operaciones entre los numeros ingresados: ");
                        Console.WriteLine($"{_num1} y {_num2}\n");

                        Console.WriteLine($"Suma: {_num1 + _num2}" +
                            $"\nResta1({_num1} - {_num2}): {_num1 - _num2}\nResta2({_num2} - {_num1}): {_num2 - _num1}" +
                            $"\nMultiplicacion: {_num1 * _num2}" +
                            $"\nDivision1({_num1} / {_num2}): {_num1 / _num2}\nDivision2({_num2} / {_num1}): {_num2 / _num1}" +
                            $"\nModulo1({_num1} % {_num2}): {_num1 % _num2}\nModulo2({_num2} % {_num1}): {_num2 % _num1}");

                        _finPrograma = true;

                    }
                    else
                    {
                        Console.Write("Ingresó un valor incorrecto, presione cualquier tecla para reiniciar.");
                    }
                }
                else
                {
                    Console.Write("Ingresó un valor incorrecto, presione cualquier tecla para reiniciar.");
                }

                Console.ReadKey();
            }

        }
    }
}