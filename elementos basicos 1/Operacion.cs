using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementosBásicos
{
    class Operacion

    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            double res;

            Console.WriteLine("Introduzca el Primer valor");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el Segundo valor");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Presiona una tecla para ver los resultados");
            Console.ReadKey();
            res = (num1 + num2) * (num1 - num2);
            Console.WriteLine(" El resultado de la primera operacion es:  " + res);
            res = num1 * 2 - num2;
            Console.WriteLine(" El resultado de la segunda operacion es. " + res);

            Console.ReadKey();
        }
    }
}