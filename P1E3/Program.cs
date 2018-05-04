using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1E3
{
    class Program
    {
        // Tecnicatura Superior en Programacion
        // Comision 2
        // Aybar Critto, Nicolas Exequiel
        // Ejercicio 3

        static void Main(string[] args)
        {
            //Declarar variables
            decimal _numero = 0m;

            // Declaracion while
            string _deseaCalcular = "S";


            // Operar

            while (_deseaCalcular.ToUpper() == "S")
            {
                Console.Clear();
                Console.WriteLine("Ingrese un numero: ");
                if (decimal.TryParse(Console.ReadLine(), out _numero))
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
                        {
                            if (_numero < 0)
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
                Console.WriteLine();
                Console.WriteLine("Desea calcular otro numero? [S para SI - N para NO]");
                _deseaCalcular = Console.ReadLine();
                Console.WriteLine("Presione cualquier tecla para finalizar..."); 
            }
            Console.ReadKey();
        }
       
    }
}
