using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1E26
{
    class Program
    {
        // Tecnicatura Superior en Programacion
        // Comision 2
        // Aybar Critto, Nicolas Exequiel
        // Ejercicio 26

        static void Main(string[] args)
        {
            //Declaracion horas
            decimal _horas = 0m; // cantidad de horas trabajadas

            //Declaracion sueldo & pagos
            decimal _sueldo = 0m; // sueldo
            decimal _pagohs = 20m; // $20 la hora x 40hs 
            decimal _pagohsextras = 25m; // $25 hora extra

            //Variable While
            string _deseaCalcular = "S";


            // Operamos

            while(_deseaCalcular.ToUpper() == "S")
            {
                Console.Clear();
                Console.WriteLine("Por favor ingrese la cantidad de horas trabajadas: ");
                if(decimal.TryParse(Console.ReadLine(), out _horas))
                {
                    if(_horas <= 40)
                    {
                        _sueldo = _horas * _pagohs;
                    }
                    else if(_horas > 40)
                    {
                        _sueldo = (40 * _pagohs) + ((_horas - 40) * _pagohsextras);                       
                    }
                    Console.WriteLine($"El obrero trabajo {_horas} horas, por lo cual le corresponde un salario semanal de {_sueldo}");
                }
                else
                {
                    Console.WriteLine("Ocurrio un error al ingresar las horas trabajadas. Por porfavor utilice caracteres numericos.");
                }
                
                Console.WriteLine();
                Console.WriteLine("Desea calcular otro salario semanal? [S para SI - N para NO]");
                _deseaCalcular = Console.ReadLine();
                Console.WriteLine("Presione cualquier tecla para finalizar...");
            }
            Console.ReadKey();
        }
    }
}
