using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite la frase");
            string palabra = Console.ReadLine();

            string palabraNueva = "";
            string palabraActual = "";

            foreach (char letra in palabra)
            {
                if (letra != ' ')
                    palabraActual += letra;
                else
                {
                    palabraNueva = " " + palabraActual + palabraNueva;
                    palabraActual = "";
                }
            }

            palabraNueva = palabraActual + palabraNueva;

            Console.WriteLine(palabraNueva);

            Console.ReadLine();
        }
    }
}
