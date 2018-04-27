using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1E10
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar
            int _mayor = 0;
            int _menor = 0;
            int _numero = 0;
            int _n = 0;

            Console.Clear();

            Console.WriteLine("Numeros a ingresar: ");
            if(int.TryParse(Console.ReadLine(), out _n))
            {
                for (int _i = 1; _i <= _n; _i++)
                {
                    Console.Write("Primer numero {0}: ");
                    if(int.TryParse(Console.ReadLine(), out _numero))
                }
            }

        }
    }
}
