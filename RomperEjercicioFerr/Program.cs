using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1E27
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Universidad Tecnologica Nacional
             * Tecnicatura Superior en Programación
             * Comision 2
             * D.N.I 42.269.771
             * Adad, Fernando Yamil
             * Ejercicio 27
             */

            decimal _ventasTotales = 0;
            decimal _tributoMensual = 0.25m;
            decimal _gastoMensual = 0;
            decimal _gananciaMensual = 0;

            bool _verificaDatoCorrecto = false;

            while (_verificaDatoCorrecto == false)
            {
                Console.Clear();
                Console.Write("Ingrese el valor total de las ventas de este mes: ");
                if (decimal.TryParse(Console.ReadLine(), out _ventasTotales))
                {
                    //Operaciones

                    _gastoMensual = _tributoMensual * _ventasTotales;
                    _gananciaMensual = _ventasTotales - _gastoMensual;

                    _verificaDatoCorrecto = true;

                }
                else
                {
                    Console.Write("Ingresó un valor incorrecto, presione cualquier tecla para reinciar.");
                    Console.ReadKey();
                }
            } // fin while

            // Muestra de datos

            Console.Clear();

            Console.Write($"Total de ventas:\t${_ventasTotales}\n\n" +
                $"Impuesto mensual:\t${_gastoMensual}\n" +
                $"Ganancia mensual:\t${_gananciaMensual}");

            Console.ReadKey();

        } // fin main
    }
}  