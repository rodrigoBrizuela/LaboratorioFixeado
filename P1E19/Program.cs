using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1E19
{
    class Program
    {
        // Tecnicatura Superior en Programacion
        // Aybar Critto, Nicolas Exequiel
        // Ejercicio 19
        static void Main(string[] args)
        {

            // Declaracion

            int _horas = 0;
            int _minutos = 0;
            int _segundos = 60;
            string _deseaIngresar = "S";

            // Operar

            while (_deseaIngresar.ToUpper() == "S")
            {
                Console.Clear();

                Console.WriteLine("Ingrese la cantidad de segundos que desee convertir a Horas / Minutos / Segundos");
                if (int.TryParse(Console.ReadLine(), out _segundos))
                {
                    _minutos = (_segundos / 60);
                    _horas = (_minutos / 60 );

                    Console.WriteLine($"La cantidad de segundos {_segundos}, equivale a {_horas} hora(s) ; {_minutos} minutos ; {_segundos} segundos.");

                  
                }
                else
                {
                    Console.WriteLine("Por favor ingrese la cantidad de segundos que desea convertir.");
                }
                Console.WriteLine();
                Console.WriteLine("Desea calcular otra operacion? [S para SI - N para NO]: ");
                _deseaIngresar = Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
