using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1E20
{
    class Program
    {
        // Tecnicatura Superior en Programacion
        // Comision 2
        // Aybar Critto, Nicolas Exequiel
        // Ejercicio 20

        static void Main(string[] args)
        {
            // Tipo de trabajador
            int _tipoEmpleado = 0;

            // Sueldo
            decimal _sueldo = 0m;

            // Tipo de categoria
            decimal _categoria1 = 10m; // hasta 30hs extra cobra $10/hr / Cat 1
            decimal _categoria2 = 14m; // hasta 30hs extra cobra $14/hr / Cat 2
            decimal _categoria1pro = 11m; // Mas de 30hs extra cobra $11/hr / Cat 1
            decimal _categoria2pro = 20m; // Mas de 30hs extra cobra $20/hr / Cat 2

            // Cantidad de horas
            decimal _horas = 0m;
            decimal _horasextras = 0m;

            // Expresion booleana
            string _deseaAgregarOtro = "S";

            // Operamos

            while (_deseaAgregarOtro.ToUpper() == "S")
            {
                Console.Clear();
                Console.WriteLine("Ingrese el sueldo del trabajador: ");
                if (decimal.TryParse(Console.ReadLine(), out _sueldo))
                {
                    Console.WriteLine("Ingrese la cantidad de horas extras trabajadas: ");
                    if (decimal.TryParse(Console.ReadLine(), out _horas))
                    {
                        Console.WriteLine("Ingrese el tipo de trabajador [ 1 - Categoria 1 | 2- Categoria 2 | 3- Categoria 1 (+30hs) | 4- Categoria 2 (+30hs) ]");
                        if (int.TryParse(Console.ReadLine(), out _tipoEmpleado))
                        {
                            if (_tipoEmpleado == 1 && _horas <= 30) // EMPLEADO CATEGORIA 1
                            {
                                _horasextras = _horas * _categoria1;
                                _sueldo = _sueldo + _horasextras;
                                Console.WriteLine($"El sueldo final del empleado es de ${_sueldo}. Cobro una cantidad de ${_horasextras} por horas extras.");
                            }
                            else if (_tipoEmpleado == 2 && _horas <= 30) // EMPLEADO CATEGORIA 2
                            {

                                _horasextras = _horas * _categoria2;
                                _sueldo = _sueldo + _horasextras;
                                Console.WriteLine($"El sueldo final del empleado es de ${_sueldo}. Cobro una cantidad de ${_horasextras} por horas extras.");
                            }
                            else if (_tipoEmpleado == 3 && _horas > 30) // EMPLEADO CATEGORIA 1 PRO
                            {

                                _horasextras = _horas * _categoria1pro;
                                _sueldo = _sueldo + _horasextras;
                                Console.WriteLine($"El sueldo final del empleado es de ${_sueldo}. Cobro una cantidad de ${_horasextras} por horas extras.");

                            }
                            else if (_tipoEmpleado == 4 && _horas > 30) // EMPLEADO CATEGORIA 2 PRO
                            {
                                _horasextras = _horas * _categoria2pro;
                                _sueldo = _sueldo + _horasextras;
                                Console.WriteLine($"El sueldo final del empleado es de ${_sueldo}. Cobro una cantidad de ${_horasextras} por horas extras.");
                            }
                            Console.WriteLine();
                            Console.WriteLine("Desea calcular otro salario? [S para SI - N para NO ]");
                            _deseaAgregarOtro = Console.ReadLine();
                          

                        }
                        else
                        {
                            Console.WriteLine("Por favor ingrese la categoria del trabajador [ 1 - Categoria 1 | 2- Categoria 2 | 3- Categoria 1 (+30hs) | 4- Categoria 2 (+30hs) ]");
                        }
                       
                    }
                    else
                    {
                        Console.WriteLine("Ocurrio un error. Por favor ingrese la cantidad de horas trabajadas");
                    }
                }
                else
                {
                    Console.WriteLine("Ocurrio un error. Por favor ingrese el sueldo del trabajador");
                }
                Console.ReadKey(); // Antes de cerrar el while
            }
        }
    }
}
