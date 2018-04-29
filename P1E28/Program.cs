using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1E28
{
    class Program
    {
        // Tecnicatura Superior en Programacion
        // Aybar Critto, Nicolas Exequiel
        // Ejercicio 28

        static void Main(string[] args)
        {
            // Declaracion de contadores de las obras sociales
            // Contar cantidad de ventas
            int _cantidadOsde = 0;
            int _cantidadGalvez = 0;
            int _cantidadSinObraSocial = 0;

            // Declaracion de Totalizadores
            // Acumular los totales de las ventas
            decimal _totalGalvez= 0;
            decimal _totalOsde = 0;
            decimal _totalSinObraSocial = 0;

            // Variables del Sistema
            int _cantidadProductos = 0;
            decimal _precioProductos = 0m;
            int _opcionDeObraSocial = 0; // 1 para galvez, 2 para osde, 3 sin obra social.

            // Opcion para realizar 'n' ventas (S o N) 
            string _deseaRealizarOtraVenta = "S";

            decimal _subTotal = 0m; // declaramos el sub total
            decimal _montoDescuento = 0m; // declaramos el monto descuento
            decimal _porcentajeDeGalvez = 20m;
            decimal _porcentajeDeOsde = 30m;
           

            while (_deseaRealizarOtraVenta.ToUpper() == "S") // ToUpper sirve para convertir a MAYUS el caracter ingresado.
            {
                Console.Clear(); // Limpiar la pantalla

                Console.Write("Ingrese el monto del producto: ");
                _precioProductos = decimal.Parse(Console.ReadLine()); // Convertimos el string a decimal mediante el code decimal.Parse
                Console.Write("Ingrese la cantidad de productos: ");
                _cantidadProductos = int.Parse(Console.ReadLine()); // Convertimos el string a int de la cantidad de productos
                Console.Write("Ingrese opcion de venta [1- GALVEZ , 2- OSDE, 3- SIN OBRA SOCIAL]: ");
                _opcionDeObraSocial = int.Parse(Console.ReadLine());
                if(_opcionDeObraSocial == 1)
                {
                    //GALVEZ 20%
                    _subTotal = (_precioProductos) * (_cantidadProductos);
                    _montoDescuento = _subTotal * (_porcentajeDeGalvez / 100);

                    //totalGalvez = _totalGalvez + (_subTotal - _montoDescuento);
                    _totalGalvez += _subTotal - _montoDescuento;
                    _cantidadGalvez++; // aumenta la cantidad de ventas de galvez

                }
                else if (_opcionDeObraSocial == 2)
                {
                    //OSDE 30%
                    _subTotal = (_precioProductos * _cantidadProductos);
                    _montoDescuento = _subTotal * (_porcentajeDeOsde / 100);

                    // _totalGalvez = _totalGalvez + (_subTotal - _montoDescuento);
                    _totalOsde += _subTotal - _montoDescuento;
                    _cantidadOsde++; // aumenta la cantidad de ventas de osde
                }
                else if (_opcionDeObraSocial == 3)
                {
                    //SIN OBRA SOCIAL 0%
                    _subTotal = (_precioProductos * _cantidadProductos);
                    _cantidadSinObraSocial++;
                }
                Console.WriteLine();
                Console.WriteLine("Desea realizar otra venta ( S o N )?: ");
                _deseaRealizarOtraVenta = Console.ReadLine();
            }


            // MOSTRAR RESULTADOS
            Console.WriteLine($"Total Galvez: ${_totalGalvez} - Cant. Ventas: {_cantidadGalvez}");
            Console.WriteLine($"Total Osde: ${_totalOsde} - Cant. Ventas: {_cantidadOsde}");
            Console.WriteLine($"Total Galvez: ${_totalSinObraSocial} - Cant. Ventas: {_cantidadSinObraSocial}");



            Console.ReadKey();
        }
    }
}
