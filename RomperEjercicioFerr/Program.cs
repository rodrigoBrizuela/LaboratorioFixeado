using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1E22
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
             * Ejercicio 22
             */

            Random _generador = new Random();

            string _nombre = "";
            string _tipoTrabajador = "";

            int _cantidadHijos = 0;

            decimal _sueldo = 0;
            decimal _primaPorHijo = 0;
            decimal _porcentajeAumentoDeSueldo = 0m;
            decimal _aumentoDeSueldo = 0;
            decimal _sueldoNuevo = 0;

            bool _verificaDatoCorrecto = false;
            bool _finPrograma = false;

            while (_finPrograma == false)
            {
                Console.WriteLine("Ingrese a continuacion los siguientes datos: \n");
                Console.Write("Nombre: ");
                _nombre = Console.ReadLine();
                while (_verificaDatoCorrecto == false)
                {
                    Console.Write("Tipo de trabajador(V|G|E|O): ");
                    _tipoTrabajador = Console.ReadLine();
                    switch (_tipoTrabajador.ToUpper()) // ToUpper convierte convierte el string en mayusculas.
                    {
                        case "V":
                            _tipoTrabajador = "V";
                            _porcentajeAumentoDeSueldo = 0.10m;
                            _verificaDatoCorrecto = true;
                            break;
                        case "G":
                            _tipoTrabajador = "G";
                            _porcentajeAumentoDeSueldo = 0.15m;
                            _verificaDatoCorrecto = true;
                            break;
                        case "E":
                            _tipoTrabajador = "E";
                            _porcentajeAumentoDeSueldo = 0.20m;
                            _verificaDatoCorrecto = true;
                            break;
                        case "O":
                            _tipoTrabajador = "G";
                            _porcentajeAumentoDeSueldo = 0.30m;
                            _verificaDatoCorrecto = true;
                            break;
                        default:
                            Console.Write("No ingresó ninguna de las opciones, por favor intente de nuevo.\n");
                            break;
                    }
                } // fin while tipoTrabajador

                _verificaDatoCorrecto = false;
                while (_verificaDatoCorrecto == false)
                {
                    Console.Write("Sueldo base: ");
                    if (decimal.TryParse(Console.ReadLine(), out _sueldo))
                    { _verificaDatoCorrecto = true; }
                    else
                    { Console.Write("Ingresó un valor incorrecto, por favor intentelo de nuevo.\n"); }
                }

                _verificaDatoCorrecto = false;
                while (_verificaDatoCorrecto == false)
                {
                    Console.Write("Cantidad de hijos: ");
                    if (int.TryParse(Console.ReadLine(), out _cantidadHijos))
                    { _verificaDatoCorrecto = true; }
                    else
                    { Console.Write("Ingresó un valor incorrecto, por favor intentelo de nuevo.\n"); }
                }

                _finPrograma = true;
            }

            _primaPorHijo = _generador.Next(100, 1001);

            // Muestra de datos

            Console.Clear();
            Console.Write($"Sus datos:\n\nNombre:\t{_nombre}\nTipo de trabajador:\t{_tipoTrabajador}" +
                $"\nSueldo:\t{_sueldo}\nHijos:\t{_cantidadHijos}\n\nPrima por hijo:\t${_primaPorHijo}");

            _aumentoDeSueldo = ((_sueldo * _porcentajeAumentoDeSueldo) + (_primaPorHijo * _cantidadHijos));
            _sueldoNuevo = _sueldo + _aumentoDeSueldo;

            Console.Write($"\n\nAumento de sueldo segun los datos ingresados:\n${_aumentoDeSueldo}");
            Console.Write($"\n\nNuevo sueldo:\t${_sueldoNuevo}");

            Console.ReadKey();


        }// fin main
    }
}