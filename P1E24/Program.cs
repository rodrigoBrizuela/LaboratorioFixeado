using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1E24
{
    class Program
    {
        // Tecnicatura Superior en Programacion
        // Comision 2
        // Aybar Critto, Nicolas Exequiel
        // Ejercicio 24

        static void Main(string[] args)
        {
            // Declaracion de la superficie
            decimal _lado1 = 0m;
            decimal _lado2 = 0m;
            decimal _perimetro = 0m;

            // Declaracion de materiales
            decimal _candidadPostes = 0m;
            decimal _cantidadAlambres = 0m;

            // Costo materiales
            decimal _precioPoste = 8m;
            decimal _precioPosteFinal = 0m;
            decimal _precioAlambre = 0.8m;
            decimal _precioAlambreFinal = 0m;

            // Cantidad de dinero
            decimal _totalDinero = 0m;

            // Variable While
            string _deseaCalcular = "S";

            
            //OPERAR
            while(_deseaCalcular.ToUpper() == "S")
            {
                Console.Clear();
                Console.WriteLine("Ingrese el primer lado del terreno rectangular: ");
                if(decimal.TryParse(Console.ReadLine(), out _lado1))
                {
                    Console.WriteLine("Ingrese el segundo lado del terreno rectangular: ");
                    if(decimal.TryParse(Console.ReadLine(), out _lado2))
                    {
                        _perimetro = (_lado1 * 2) + (_lado2 * 2);
                        _candidadPostes = _perimetro / 2;
                        _cantidadAlambres = _perimetro * 5;
                        _precioPosteFinal = _candidadPostes * _precioPoste;
                        _precioAlambreFinal = _cantidadAlambres * _precioAlambre;
                        _totalDinero = _precioAlambreFinal + _precioPosteFinal;

                        Console.WriteLine($"Para una superficie de {_perimetro} metros, se necesitara una cantidad de ${_precioPosteFinal} para comprar los postes y ${_precioAlambreFinal} para comprar los alambres. La suma total es de ${_totalDinero}");
                    }
                    else
                    {
                        Console.WriteLine("Por favor ingrese un valor valido para el lado 2.");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Por favor ingrese un valor valido para el lado 1.");
                }
                Console.WriteLine();
                Console.WriteLine("Desea calcular otra superficie? [S para SI - N para NO]");
                _deseaCalcular = Console.ReadLine();

            }
            Console.ReadKey();
        }
    }
}
