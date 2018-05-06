using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1E23
{
    class Program
    {
        // Tecnicatura Superior en Programacion
        // Comision 2
        // Aybar Critto, Nicolas Exequiel
        // Ejercicio 23

        static void Main(string[] args)
        {
            // Declaracion de problemas

            int _cantidadPizzas = 0; // cantidad de pizzas
            decimal _descuento = 10m; // descuento 10% por > 3 pizzas
            decimal _descuentoMayor = 15m; // descuento 15% por <= a 3 pizzas
            decimal _precioPizza = 0m; // Precio de la pizza
            decimal _total = 0m; // Total final

            // Variable del while
            string _deseaVenderOtra = "S";

            // Operamos


            while (_deseaVenderOtra.ToUpper() == "S")
            {
                Console.Clear();
                Console.WriteLine("Ingrese la cantidad de pizzas a vender: ");
                if (int.TryParse(Console.ReadLine(), out _cantidadPizzas))
                {
                    Console.WriteLine("Ingrese el precio de las pizzas: ");
                    if (decimal.TryParse(Console.ReadLine(), out _precioPizza))
                    {
                        if(_cantidadPizzas < 3) // Descuentto del 10% menor a 3 pizzas
                        {
                            _total = (_cantidadPizzas * _precioPizza) - (_cantidadPizzas * _precioPizza * _descuento / 100);
                            Console.WriteLine($"El cliente obtuvo un 10% de descuento. El total de la venta es de ${_total}.");
                        }
                        if(_cantidadPizzas >= 3) //  Descuento del 15% mayor o igual a 3 pizzas
                        {
                            _total = (_cantidadPizzas * _precioPizza) - (_cantidadPizzas * _precioPizza * _descuentoMayor / 100);
                            Console.WriteLine($"El cliente obtuvo un 15% de descuento. El total de la venta es de ${_total}.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ocurrio un error. Por favor ingrese el precio de las pizzas.");
                    }

                }
                else
                {
                    Console.WriteLine("Ocurrio un error. Por favor ingrese la cantidad de pizzas a vender.");
                }
                Console.WriteLine();
                Console.WriteLine("Desea realizar otra venta? [S para SI - N para NO]");
                _deseaVenderOtra = Console.ReadLine();
                Console.WriteLine("Presione cualquier tecla para finalizar...");
            }
            Console.ReadKey();
        }
    }
}
