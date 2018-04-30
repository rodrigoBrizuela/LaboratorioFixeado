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
        // Ejercicio 22

        static void Main(string[] args)
        {

            // variable trabajador
            int _trabajador = 0; // identificador del tipo de trabajador

            // tipo de trabajadores con su respectivo aumento

            decimal _tipoV = 1.10m; // aumento del 10%
            decimal _tipoG = 1.15m; // aumento del 15%
            decimal _tipoE = 1.20m; // aumento del 20%
            decimal _tipoO = 1.30m; // aumento del 30%

            //Nombre del trabajador
            string _nombre = "";

            //sueldo trabajador
            decimal _sueldo = 0m;
            decimal _sueldoFinal = 0m;
            decimal _aumento = 0m;

            //cantidad de hijos que tiene + aumento por hijo
            int _hijos = 0;
            decimal _sueldoPorHijos = 0m;
            decimal _aumentoHijo = 5m; // aumento del 5% por hijo
            decimal _porcentajeFinal = 0m; // porcentaje de aumento final por hijos
            // Condicion while
            string _deseaAgregar = "S";


            //OPERAMOS

            while (_deseaAgregar.ToUpper() == "S") // CONVERTIMOS LOS CARACTERES EN MAYUS
            {
                Console.Clear();
                Console.WriteLine("Ingrese el nombre del trabajador: ");
                _nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el sueldo del trabajador: ");
                if (decimal.TryParse(Console.ReadLine(), out _sueldo))
                {
                    Console.WriteLine("Ingrese el tipo de trabajador [ 1- V | 2- G | 3- E | 4- O]");
                    {
                        if (int.TryParse(Console.ReadLine(), out _trabajador))
                        {
                            Console.WriteLine("Ingrese la cantidad de hijos que tiene el trabajador: ");
                            if (int.TryParse(Console.ReadLine(), out _hijos))
                            {
                                if (_trabajador == 1) // TIPO V
                                {
                                    _aumento = _sueldo * _tipoV;
                                    _sueldoPorHijos = ((_aumentoHijo * _hijos) / 100) + 1;
                                    _porcentajeFinal = (_aumentoHijo * _hijos);
                                    _sueldoFinal = _aumento * _sueldoPorHijos;

                                }
                                else if (_trabajador == 2) // TIPO G
                                {
                                    _aumento = _sueldo * _tipoG;
                                    _sueldoPorHijos = ((_aumentoHijo * _hijos) / 100) + 1;
                                    _porcentajeFinal = (_aumentoHijo * _hijos);
                                    _sueldoFinal = _aumento * _sueldoPorHijos;

                                }
                                else if (_trabajador == 3) // TIPO E
                                {
                                    _aumento = _sueldo * _tipoE;
                                    _sueldoPorHijos = ((_aumentoHijo * _hijos) / 100) + 1;
                                    _porcentajeFinal = (_aumentoHijo * _hijos);
                                    _sueldoFinal = _aumento * _sueldoPorHijos;

                                }
                                else if (_trabajador == 4) // TIPO O
                                {
                                    _aumento = _sueldo * _tipoO;
                                    _sueldoPorHijos = ((_aumentoHijo * _hijos) / 100) + 1;
                                    _porcentajeFinal = (_aumentoHijo * _hijos);
                                    _sueldoFinal = _aumento * _sueldoPorHijos;
                                }
                                Console.WriteLine($"El sueldo con aumento del trabajador {_nombre} es de ${_aumento}.\nAdemas, recibe un aumento extra del {_porcentajeFinal}% por la cantidad de hijos ({_hijos}) que posee.\nEl sueldo final es de ${_sueldoFinal}");
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine("Por favor ingrese la cantidad de hijos expresado en numeros.");
                                
                            }
                            
                        }
                        else
                        {
                            Console.WriteLine("Por favor ingrese el numero del tipo de trabajador [ 1- V | 2- G | 3- E | 4- O]");
                            
                        }
                        
                    }
                }
                else
                {
                    Console.WriteLine("Por favor ingrese el sueldo del trabajador expresado en numeros.");
                    
                }
                Console.WriteLine();
                Console.WriteLine("Desea calcular el sueldo de otro trabajador? [S para SI - N para NO]");
                _deseaAgregar = Console.ReadLine();
                Console.WriteLine("Presione cualquier tecla para finalizar...");

            }
            Console.ReadKey();
        }
    }
}
