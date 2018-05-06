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
            // Tecnicatura Superior en Programacion
            // Aybar Critto, Nicolas Exequiel
            // COMISION 2
            // Ejercicio 16

            // DECLARAR OPERACIONES
            int _num1 = 0;
            int _num2 = 0;
            int _suma = 0;
            int _resta = 0;
            int _division1 = 0;
            int _division2 = 0;
            int _multiplicacion = 0;
            int _resto1 = 0;
            int _resto2 = 0;

            //Declaracion while
            string _deseaCalcular = "S";

            // operamos

            while (_deseaCalcular.ToUpper() == "S")
            {
                Console.Clear(); // Console Clear dentro del while
                Console.WriteLine("Ingrese el primer numero: ");
                if (int.TryParse(Console.ReadLine(), out _num1))
                {
                    Console.WriteLine("Ingrese el segundo numero: ");
                    if (int.TryParse(Console.ReadLine(), out _num2))
                    {
                        _suma = (_num1 + _num2);
                        Console.WriteLine($"La suma de los dos numeros ingresados es: {_suma}");
                        _resta = (_num1 - _num2);
                        Console.WriteLine($"La resta de los dos numeros ingresados es: {_resta}");
                        _multiplicacion = (_num1 * _num2);
                        Console.WriteLine($"La multiplicacion de los dos numeros ingresados es: {_multiplicacion}");
                        _resta = (_num2 - _num1);
                        Console.WriteLine($"La resta de los dos numeros ingresados, con sus operadores invertidos, es: {_resta}");
                        try // Try catch para resolver al division en 0
                        {
                            _division1 = (_num1 / _num2);
                            _resto1 = (_num1 % _num2);
                            Console.WriteLine($"La division de ambos numeros es: {_division1}, y su resto es {_resto1}");
                        }
                        catch (DivideByZeroException) // En caso de que ingrese 0, muestra el mensaje de abajo.
                        {
                            Console.WriteLine("No se puede realizar la division en cero.");
                        }
                        try
                        {
                            _division2 = (_num2 / _num1);
                            _resto2 = (_num2 % _num1);
                            Console.WriteLine($"La division conmutativa es igual a: {_division2}, y su resto es {_resto2}");
                        }
                      
                        catch (DivideByZeroException)
                        {
                            Console.WriteLine("La division conmutativa no se puede realizar ya que no se puede dividir en cero.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ocurrio un error. Por favor introduzca un numero.");
                    } 
                }
                else
                {
                    Console.WriteLine("Ocurrio un error. Por favor introduzca un numero.");
                }
                Console.WriteLine();
                Console.WriteLine("Desea realizar otras operaciones? [S para SI - N para NO]");
                _deseaCalcular = Console.ReadLine();
                Console.WriteLine("Presione cualquier tecla para finalizar...");
            }
            Console.ReadKey();
        }
    }
}