using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementosBásicos
{
    class Division
    {
        static void Main(string[] args)
        {
            int n1;
            int n2;
            int res;

            Console.WriteLine("Escribe un numero entero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe segundo numero entero diferente a cero");
            n2 = int.Parse(Console.ReadLine());

            if (n2 <= 0)
            {
                Console.WriteLine("Error: No se puede dividir entre cero");
            }

            else
            {
                res = n1 / n2;
                Console.WriteLine("Este es el resultado de división: " + res);
            }
            Console.ReadKey();
        }
    }
}