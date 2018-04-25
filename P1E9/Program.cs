using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1E9
{
    class Program
    {
        static void Main(string[] args)
        {
            // declarar variables

            decimal _numero = 0m; // numero 2
            decimal _exponente = 0m; // potencia
            decimal _resultado = 0m; // resultado final

            Console.Clear();

            // operamos
            Console.WriteLine("Ingrese la potencia a la que desea elevar el numero 2.");
            if(decimal.TryParse(Console.ReadLine(), out _exponente))
            {
                _resultado = 2
            }
            

            Console.ReadKey();
        }
    }
}
