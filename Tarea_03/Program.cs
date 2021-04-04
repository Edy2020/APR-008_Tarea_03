using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_03
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("");
            Console.WriteLine("Ingrese las horas en minutos: ");
            Console.WriteLine("==============================");
            Console.WriteLine("         Tarifa");
            Console.WriteLine("60 minutos o menos = $500");
            Console.WriteLine("120 minutos        = $800");
            Console.WriteLine("+ 120 minutos      = $1500");
            Console.WriteLine("");
            Console.WriteLine("==============================");

            int horas = Convert.ToInt32(Console.ReadLine());

            if (horas <= 60)
            {
                Console.WriteLine("==============================");
                Console.WriteLine("    La tarifa es de $500");
                Console.WriteLine("==============================");
            }
            else
            {
                if (horas <= 120)
                {
                    Console.WriteLine("==============================");
                    Console.WriteLine("    La tarifa es de $800");
                    Console.WriteLine("==============================");
                }
                else
                {
                    Console.WriteLine("==============================");
                    Console.WriteLine("   La tarifa es de $1500");
                    Console.WriteLine("==============================");
                }
            }

            Console.ReadKey();

        }
    }
}
