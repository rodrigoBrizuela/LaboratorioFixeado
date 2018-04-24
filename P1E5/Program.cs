using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1E5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaro variable
            Console.Clear();


            int i = 0;

            for (i = 1; i < 11; i ++) // La sentencia FOR toma el valor i final -1

            {
                Console.WriteLine(i.ToString("00")); // Pongo "00" para darle un mejor formato visual
            }

            Console.ReadKey();
        }
    }
}
