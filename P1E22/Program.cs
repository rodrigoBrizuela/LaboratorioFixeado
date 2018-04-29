using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1E22
{

    class Program
    {
        // Tecnicatura Superior en Programacion
        // Aybar Critto, Nicolas Exequiel
        // COMISION 2
        // Ejercicio 19

        static void Main(string[] args)
        {

            // variable trabajador
            int _trabajador = 0;

            // tipo de trabajadores con su respectivo aumento
            
            decimal _tipoV = 1.10m;
            decimal _tipoG = 1.15m;
            decimal _tipoE = 1.20m;
            decimal _tipoO = 1.30m;

            //Nombre del trabajador
            string _nombre = "";

            //sueldo trabajador
            decimal _sueldo = 0m;
            decimal _sueldoFinal = 0m;
            decimal _aumento = 0m;

            //cantidad de hijos que tiene + aumento por hijo
            int _hijos = 0;
            decimal _sueldoPorHijos = 0m;
            decimal _aumentoHijo = 1.05m;

            // Condicion while
            string _deseaAgregar = "S";


            //OPERAMOS

            while (_deseaAgregar.ToUpper() == "S") // CONVERTIMOS LOS CARACTERES EN MAYUS
            {
                Console.WriteLine("Ingrese el nombre del trabajador: ");
                _nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el sueldo del trabajador: ");
                if(decimal.TryParse(Console.ReadLine(), out _sueldo))
                {
                    Console.WriteLine("Ingrese el tipo de trabajador [ 1- V | 2- G | 3- E | 4- O]");
                    _trabajador = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la cantidad de hijos que tiene el trabajador: ");
                    _hijos = int.Parse(Console.ReadLine());
                    if (_trabajador == 1) // TIPO V
                    {
                        _aumento = _sueldo * _tipoV;
                        _sueldoPorHijos = _sueldo * ((_aumentoHijo * _hijos) / _hijos);
                        _sueldoFinal = _aumentoHijo + _aumento;
                        Console.WriteLine($"El sueldo con aumento del trabajador {_nombre} es de ${_aumento}. Ademas, recibe un aumento extra de {_aumentohijo} por la cantidad de hijos ({_hijos}) que posee. El sueldo final es {_sueldofinal}");
                    }
                    else if (_trabajador == 2) // TIPO G
                    {
                        _aumento = _sueldo * _tipoG;
                        Console.WriteLine($"El sueldo final con aumento del trabajador {_nombre} es de ${_aumento} ");
                    }
                   else if (_trabajador == 3) // TIPO E
                    {
                        _aumento = _sueldo * _tipoE;
                        Console.WriteLine($"El sueldo final con aumento del trabajador {_nombre} es de ${_aumento} ");
                    }
                    else if (_trabajador == 4) // TIPO O
                    {
                        _aumento = _sueldo * _tipoO;
                        Console.WriteLine($"El sueldo final con aumento del trabajador {_nombre} es de ${_aumento} ");
                    }

                }













                Console.ReadKey();
            }
          
        }
    }
}
