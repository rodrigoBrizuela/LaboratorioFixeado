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

            // DECLARAR
            int _num1 = 0;
            int _num2 = 0;
            int _suma = 0;
            int _resta = 0;
            int _division1 = 0;
            int _division2 = 0;
            int _multiplicacion = 0;
            int _resto1 = 0;
            int _resto2 = 0;
            bool _bandera = false;

            // operamos

            while (_bandera == false)
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



                        if (_num1 != 0)
                        {
                            _division2 = (_num2 / _num1);
                            _resto2 = (_num2 % _num1);

                            Console.WriteLine($"La division conmutativa, es: {_division2}, y su resto es {_resto2}");
                            if (_num2 != 0)
                            {

                                _division1 = (_num1 / _num2);
                                _resto1 = (_num1 % _num2);
                                Console.WriteLine($"La division de los dos numeros ingresados es: {_division1}, y su resto es {_resto1}");
                                _bandera = true;
                            }
                            
                            else
                            {
                                Console.WriteLine("La division no se puede realizar, ya que no se puede dividir en 0.");
                                
                            }
                        }
                        else
                        {
                            Console.WriteLine("La division conmutativa no se puede realizar, ya que no se puede dividir en 0.");
                        }
                    }

                    Console.ReadKey();
                }
            }
            
        }
    }
}



//
//               else
//               {
//                   Console.WriteLine("Por favor ingrese un numero entero.\nPresione cualquier tecla para reiniciar.");
//               }
//           }
//       }
//               else
//               {
//                   Console.WriteLine("Por favor ingrese un numero entero.\nPresione cualquier tecla para reiniciar.");
//               }
//               Console.ReadKey(); // Este comando tiene que estar dentro del while/main
//           }
//           
//       }
//   }
//

