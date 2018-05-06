using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1E25
{
    class Program
    {
        public static decimal conversionCelsiusFarenheit(decimal _gradosCelsius)
        {

            decimal _resultado = 0;

            _resultado = _gradosCelsius * (9m / 5m) + 32;

            return _resultado;

        }

        static void Main(string[] args)
        {
            /* Universidad Tecnologica Nacional
             * Tecnicatura Superior en Programación
             * Comision 2
             * D.N.I 42.269.771
             * Adad, Fernando Yamil
             * Ejercicio 25
             */

            decimal _gradosCelsius = 0;
            decimal _gradosFahrenheit = 0;
            string _deporte = "";

            bool _verificaDatoCorrecto = false;

            _verificaDatoCorrecto = false;
            while (_verificaDatoCorrecto == false)
            {
                Console.Clear();
                Console.Write("Segun la temperatura que ingrese, en celsius, se determinara qué deporte es el mas apropiado.\n\nTemperatura en Celsius: ");
                if (decimal.TryParse(Console.ReadLine(), out _gradosCelsius))
                {
                    _gradosFahrenheit = conversionCelsiusFarenheit(_gradosCelsius);
                    if (_gradosFahrenheit > 85)
                    {
                        _deporte = "Natacion";
                    }
                    else if (_gradosFahrenheit > 70 && _gradosFahrenheit <= 85)
                    {
                        _deporte = "Tenis";
                    }
                    else if (_gradosFahrenheit > 35 && _gradosFahrenheit <= 70)
                    {
                        _deporte = "Golf";
                    }
                    else if (_gradosFahrenheit > 32 && _gradosFahrenheit <= 35)
                    {
                        _deporte = "Esqui";
                    }
                    else
                    {
                        _deporte = "otro no especificado";
                    }

                    Console.Write($"Temperatura en Fahrenheit: {_gradosFahrenheit}");
                    Console.Write($"\n\nEl deporte más apropiado es {_deporte}");

                }
                else
                {
                    Console.Write("Ingresó un valor incorrecto, presione cualquier tecla para reiniciar.");
                }

                Console.ReadKey();
            }


        }
    }
}