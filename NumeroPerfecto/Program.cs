using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroPerfecto
{
    class Program
    {
        static void Main(string[] args)
        {
            // declarar
            int _numero = 0;
            int _divisor = 0;
            int _contador = 0;

            Console.Clear();

            //operar
            Console.Write("Ingrese un numero: ");
            if(int.TryParse(Console.ReadLine(), out _numero))
            {
                _contador = 0;
                for (_divisor = 1; _divisor < _numero; _divisor++)
                {
                    if( _numero % _divisor == 0)
                    {
                        _contador += _divisor;
                        
                    } // if


                } // for
                if(_numero == _contador)
                {
                    Console.WriteLine($"El numero {_numero} es perfecto");
                }
                else
                {
                    Console.WriteLine($"El numero {_numero} no es perfecto");
                }
           } // if
            Console.ReadKey();
        }
    }
}
