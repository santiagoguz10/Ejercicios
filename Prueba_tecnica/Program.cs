using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_tecnica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cual es su nota?");
            int nota = Convert.ToInt16(Console.ReadLine());
            if (nota == 19 || nota == 20)
            {
                Console.WriteLine("La nota es A");
            }
            else if (nota <= 18 && nota >= 16)
            {
                Console.WriteLine("La nota es B");
            }
            else if (nota <= 15 && nota >= 13)
            {
                Console.WriteLine("La nota es C");
            }
            else if (nota <= 12 && nota >= 10)
            {
                Console.WriteLine("La nota es D");
            }
            else if (nota <= 9 && nota >= 1)
            {
                Console.WriteLine("La nota es E");
            }
            else
            {
            Console.WriteLine("La nota no está entre (0-20)");
            }
   
            Console.ReadLine();

        }
    }
}
