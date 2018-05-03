using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1E21
{
    class Program
    {
        // Tecnicatura Superior en Programacion
        // Aybar Critto, Nicolas Exequiel
        // Comision 2
        // Ejercicio 21

        static void Main(string[] args)
        {
            // DECLARACION
            decimal _pesoPescado = 0m;
            decimal _mayor = 0m;
            decimal _mayor2 = 0m;

            // condicion while
            string _deseaIngresarPescado = "S"; 

            //OPERACION
            while(_deseaIngresarPescado.ToUpper() == "S") // ToUpper, convierte la cadena en string a Mayus forzadamente
            {
      
                Console.WriteLine("Ingrese el peso del pescado:");
                if(decimal.TryParse(Console.ReadLine(), out _pesoPescado))
                {
                    if (_pesoPescado > _mayor2)
                    {

                        if(_mayor2 > _mayor)
                        {
                            _mayor = _mayor2; 
                            _mayor2 = _pesoPescado;
                        }
                       else
                       {
                            _mayor2 = _pesoPescado; 

                       }
                    }
                    else if (_pesoPescado > _mayor && 

                    {                       
                            _mayor = _pesoPescado;
                      
                    }

                }
                else
                {
                    Console.WriteLine("Ocurrio un error al ingresar el peso del pescado. Por favor ingrese el peso en caracteres numericos.");
                }
                Console.WriteLine();
                Console.WriteLine("Desea agregar mas pescados? [S para SI - N para NO]");
                _deseaIngresarPescado = Console.ReadLine();
                
            }
            Console.WriteLine();
            Console.WriteLine($"Los dos pescados mas pesados son los de {_mayor2}GR y {_mayor}GR");
            Console.ReadKey();
        }
    }
}
