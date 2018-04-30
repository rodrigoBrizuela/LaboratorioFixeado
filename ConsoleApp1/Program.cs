using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   
        class Program
        {
            static void Main(string[] args)
            {
                int num, hor, min, seg;
                Console.WriteLine("ingrese los segundos");
                num = Convert.ToInt32(Console.ReadLine());
                hor = (num / 3600);
                min = ((num - hor * 3600) / 60);
                seg = num - (hor * 3600 + min * 60);
                Console.WriteLine(hor + " h " + min + " m " + seg + " s ");
                Console.ReadLine();
            }
        }
    }

