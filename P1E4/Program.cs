using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1E4
{
    class Program
    {

        // Tecnicatura Superior en Programacion
        // Comision 2
        // Aybar Critto, Nicolas Exequiel
        // Ejercicio 4

        static void Main(string[] args)
        {
            //Declaro
            decimal _numero1 = 0m;
            decimal _numero2 = 0m;
            decimal _numero3 = 0m;

            // Declararacion para el while
            string _deseaAgregar = "S";

            // OPERO
            while (_deseaAgregar.ToUpper() == "S")
            {
                Console.Clear();
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
                                Console.WriteLine($"El primer ingresado es el mayor ({_numero1})");
                            }
                            {
                                if (_numero2 > _numero1 && _numero2 > _numero3)
                                {
                                    Console.WriteLine($"El segundo numero ingresado es el mayor ({_numero2})");
                                }
                                {
                                    if (_numero3 > _numero1 && _numero3 > _numero2)
                                    {
                                        Console.WriteLine($"El tercer numero ingresado es el mayor ({_numero3})");
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
                Console.WriteLine();
                Console.WriteLine("Desea intentar nuevamente? [S para SI - N para no]");
                _deseaAgregar = Console.ReadLine();
            }
            Console.ReadKey();
        }
        
    }
}
