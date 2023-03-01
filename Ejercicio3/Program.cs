using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Program
    {
        static void Main(string[] args)
        {
            long BC = 0;
            long BV = 0;
            long BD = 0 ;
            long BC2 = 0 ;
            long BM = 0;

            Console.WriteLine("Digite número");
            long N = Convert.ToInt64(Console.ReadLine());

            long C = N;

            if (N >= 50000)
            {
                BC = BC + 1;
                C = C - 50000;
                Console.WriteLine("Resultado " + C);

            }
            else if (N >= 20000)
            {
                BV = BV + 1;
                C = C - 20000;
                Console.WriteLine("Resultado " + C);

            }
            else if (N >= 10000)
            {
                BD = BD + 1;
                C = C - 10000;
                Console.WriteLine("Resultado " + C);

            }
            else if (N >= 5000)
            {
                BC2 = BC2 + 1;
                C = C - 10000;
                Console.WriteLine("Resultado " + C);

            }
            else if (N >= 1000)
            {
                BM = BM + 1;
                C = C - 20000;
                Console.WriteLine("Resultado " + C);
            }
            else {
                long resto = C;
                Console.WriteLine("Resultado " + " N = " + N + ", BC = " + BC + ", BV = " + BV + ", BD = " + BD + ", BC2 = " + BC2 + ", BM = " + BM + ", resto = " + resto);
            }

            Console.ReadLine();
        }
    }
}
