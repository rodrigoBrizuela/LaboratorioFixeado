using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1E3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar variables
            Console.Write("Ingrese un numero: ");
            string _numeroPantalla = Console.ReadLine();
            decimal _numero = 0m;

            if (decimal.TryParse(_numeroPantalla, out _numero))
            {
               if (_numero == 0)
                {
                    Console.WriteLine("El numero ingresado es neutro");
                }
                {
                    if (_numero > 0)
                    {
                        Console.WriteLine("El numero ingresado es positivo");
                    }
                    { if (_numero < 0)
                        {
                            Console.WriteLine("El numero ingresado es negativo");
                        }
                       
                        
                    }
                }

            }
            else
            {
                Console.WriteLine("Ocurrio un error. Por favor ingrese un caracter numerico.");

            }
            Console.ReadKey();
        }
    }
}
