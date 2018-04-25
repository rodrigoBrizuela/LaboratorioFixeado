using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1E4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaro
            decimal _numero1 = 0m;
            decimal _numero2 = 0m;
            decimal _numero3 = 0m;

            Console.Clear();

            // OPERO

            Console.Write("Ingrese el primer numero: ");
            if (decimal.TryParse(Console.ReadLine(), out _numero1))
            {
                Console.Write("Ingrese el segundo numero: ");
                if (decimal.TryParse(Console.ReadLine(), out _numero2))
                {
                    Console.Write("Ingrese el tercer numero: ");
                    if (decimal.TryParse(Console.ReadLine(), out _numero3))
                    {
                        if (_numero1 > _numero2 && _numero1 > _numero3)
                        {
                            Console.WriteLine("El primer numero es el mayor");
                        }
                        {
                            if (_numero2 > _numero1 && _numero2 > _numero3)
                            {
                                Console.WriteLine("El segundo numero es el mayor");
                            }
                            {
                                if (_numero3 > _numero1 && _numero3 > _numero2)
                                {
                                    Console.WriteLine("El tercer numero es el mayor");
                                }
                            }
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("Ocurrio un error al ingresar el tercer numero");
                    }
                }
                else
                {
                    Console.WriteLine("Ocurrio un error al ingresar el segundo numero");
                }
            }
            else
            {
                Console.WriteLine("Ocurrio un error al ingresar el primer numero");
            }
            Console.ReadKey();
        }
    }
}
