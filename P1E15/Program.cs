using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1E15
{
    class Program
    {
        // Tecnicatura Superior en Programacion
        // Comision 2
        // Aybar Critto, Nicolas Exequiel
        // Ejercicio 15

        static void Main(string[] args)
        {
            // declaro
            decimal _tarifa = 0m;
            decimal _pago = 0m;
            decimal _total = 0m;
            decimal _vuelto = 0m;

            string _deseaAgregar = "S";
       
            // operamos
            while (_deseaAgregar.ToUpper() == "S")
            {
                Console.Clear(); // console clear va dentro del while 
                Console.WriteLine("Por favor, ingrese el total de la venta: ");
                if (decimal.TryParse(Console.ReadLine(), out _tarifa))
                {
                    Console.WriteLine("Por favor, ingrese el total pagado: ");
                    if (decimal.TryParse(Console.ReadLine(), out _pago))
                    {
                        if (_tarifa > _pago) // condicion para el descuento
                        {
                            _total = (100 - ((_pago * 100) / _tarifa));
                            Console.WriteLine($"Usted obtuvo un descuento del {_total}%");
                            
                        }
                        else if (_tarifa < _pago) // condicion para el vuelto
                        {
                            _vuelto = (_pago - _tarifa);
                            Console.WriteLine($"El monto pagado es mayor al total de venta. Su vuelto es de ${_vuelto}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ocurrio un error. Por favor ingrese un caracter valido.");
                    }
                }
                else
                {
                    Console.WriteLine("Ocurrio un error. Por favor ingrese un caracter valido.");
                }
                Console.WriteLine();
                Console.WriteLine("Desea realizar otra venta? [S para Si - N para NO]");
                _deseaAgregar = Console.ReadLine();
                Console.WriteLine("Presione cualquier tecla para finalizar...");
            }
            Console.ReadKey();
        }
        
    }
}
