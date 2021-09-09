using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementosBásicos
{
    class deCaF
    {
        static void Main(string[] args)
        {
            double c, f;

            Console.WriteLine("Ingrese los grados centigrados que desea convertir: ");
            c = Convert.ToDouble(Console.ReadLine());

            f = (c * 9 / 5) + 32;

            Console.WriteLine("Estos son los grados Centgrados en Fahrenheit: " + f);
            Console.ReadKey();
        }
    }
}