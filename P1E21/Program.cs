using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1E21
{
    class Program
    {
        static void Main(string[] args)
        {
            // DECLARACION
            int _cantidadPescados = 0;
            decimal _pesoPescado = 0m;
            string _deseaIngresarPescado = "S"; 

            //OPERACION
            while(_deseaIngresarPescado.ToUpper() == "S") // ToUpper, convierte la cadena en string a Mayus forzadamente
            {
                Console.WriteLine("Ingrese el peso del pescado:");
                if(decimal.TryParse(Console.ReadLine(), out _pesoPescado))
                {
                    _pesoPescado =
                }
            }

        }
    }
}
