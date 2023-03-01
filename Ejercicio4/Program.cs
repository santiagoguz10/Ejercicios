using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite número X");
            long x = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Digite número Y");
            long y = Convert.ToInt64(Console.ReadLine());

            long numero = 0;
            int result = 0;

            if (x > y)
            {
                numero = x;
                result = numeroPerfecto(numero);
                if (result == 1)
                {
                    Console.WriteLine("El numero perfecto es " + x);
                }
                else {
                    Console.WriteLine(-1);
                }               

            }
            else {
                numero = y;
                result = numeroPerfecto(numero);
                if (result == 1)
                {
                    Console.WriteLine("El numero perfecto es Y " + y);
                }
                else
                {
                    Console.WriteLine(-1);
                }

            }           

            Console.ReadLine();
        }

        public static int numeroPerfecto(long num)
        {
            int suma = 0;
            int i = 1;

            do
            {
                if (num % i == 0)
                {
                    suma = suma + i;
                }
                i++;
            } while (i <= num / 2);

            if (suma == num)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
