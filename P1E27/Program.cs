using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1E27
{
    class Program
    {
        // Tecnicatura Superior en Programacion
        // Comision 2
        // Aybar Critto, Nicolas Exequiel
        // Ejercicio 27

        static void Main(string[] args)
        {
            // DECLARACION
            decimal _totalVentas = 0m; // Total vendido bruto
            decimal _impuesto = 25m; // Impuesto del 25% provincial
            decimal _gastos = 0m; // Gastos del comerciante
            decimal _ventas = 0m; // Ventas del comerciante
            decimal _ganancia = 0m; // Ganancia del comerciante

            string _deseaAgregarOtro = "S";

            while(_deseaAgregarOtro.ToUpper() == "S")
            {
                Console.Clear();
                Console.WriteLine("Ingrese el total de ventas: ");
                if(decimal.TryParse(Console.ReadLine(), out _ventas))
                {
                    Console.WriteLine("Ingrese el total de gastos: ");
                    if(decimal.TryParse(Console.ReadLine(), out _gastos))
                    {
                        _totalVentas = (_ventas - _ventas * _impuesto / 100);
                        _ganancia = _totalVentas - _gastos;
                        Console.WriteLine($"La ganancia del comerciante con deduccion de impuestos y de gastos es de ${_ganancia}");

                    }

                }
                Console.WriteLine();
                Console.WriteLine("Desea calcular otra ganancia mensual? [S para SI - N para NO]");
                _deseaAgregarOtro = Console.ReadLine();
                Console.WriteLine("Presione cualquier tecla para finalizar...");
            }
            Console.ReadKey();
        }
    }
}
