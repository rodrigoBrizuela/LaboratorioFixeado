using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1E20
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
             * Ejercicio 20
             */

            int _sueldoExtra = 0;
            int _horasExtra = 0;
            decimal _sueldo = 0;
            int _categoria = 0;

            bool _finPrograma = false;


            _finPrograma = false;
            while (_finPrograma == false)
            {
                Console.Clear();
                Console.WriteLine("Ingrese los siguientes datos a continuacion:\n");
                Console.Write("Horas extra trabajadas: ");
                if (int.TryParse(Console.ReadLine(), out _horasExtra))
                {
                    Console.Write("Sueldo base: ");
                    if (decimal.TryParse(Console.ReadLine(), out _sueldo))
                    {
                        Console.Write("Categoria de empleado (1|2):  ");
                        if (int.TryParse(Console.ReadLine(), out _categoria) && (_categoria > 0 && _categoria < 3))
                        {
                            if (_categoria == 1)
                            {
                                if (_horasExtra <= 30)
                                { _sueldoExtra = _horasExtra * 10; }
                                else
                                { _sueldoExtra = _horasExtra * 11; }
                            }
                            else
                            {
                                if (_horasExtra <= 30)
                                { _sueldoExtra = _horasExtra * 14; }
                                else
                                { _sueldoExtra = _horasExtra * 20; }
                            }

                            Console.Write($"\nImporte por horas extra: {_sueldoExtra}\nCobrará este mes: ${_sueldo + _sueldoExtra}");

                            _finPrograma = true;
                        }
                        else
                        {
                            Console.Write("Ingresó un valor incorrecto, presione cualquier tecla para ingresar");
                        }
                    }
                    else
                    {
                        Console.Write("Ingresó un valor incorrecto, presione cualquier tecla para ingresar");
                    }
                }
                else
                {
                    Console.Write("Ingresó un valor incorrecto, presione cualquier tecla para ingresar");
                }

                Console.ReadKey();
            }

        }
    }
}