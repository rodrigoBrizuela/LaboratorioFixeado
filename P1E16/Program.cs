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

                        Console.WriteLine($"La suma de los dos numeros ingresados es: {_num1 + _num2}");
                        Console.WriteLine($"La resta de los dos numeros ingresados es: {_num1 - _num2}");
                        Console.WriteLine($"La multiplicacion de los dos numeros ingresados es: {_num1 * _num2}");
                        Console.WriteLine($"La resta de los dos numeros ingresados, con sus operadores invertidos, es: {_num2 - _num1}");
                        try // Try catch para resolver al division en 0
                        {
                            Console.WriteLine($"La division de ambos numeros es: {_num1 / _num2}, y su resto es {_num1 % _num2}");
                        }
                        catch (DivideByZeroException) // En caso de que ingrese 0, muestra el mensaje de abajo.
                        {
                            Console.WriteLine("No se puede realizar la division en cero.");
                        }
                        try// Try catch para resolver al division en 0 conmutativa
                        {
                            Console.WriteLine($"La division conmutativa es igual a: {_num2 / _num1}, y su resto es {_num2 % _num1}");
                        }
                      
                        catch (DivideByZeroException) // En caso de que ingrese 0, muestra el mensaje de abajo.
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