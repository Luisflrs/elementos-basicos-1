using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementosBásicos
{
    class Califiacion_final
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, promedio1, promedio2, promedio3, notafinal;

            Console.WriteLine("Ingrese la nota del Primer Computo: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la nota del Segundo Computo: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la nota del Tercer Computo: ");
            nota3 = Convert.ToDouble(Console.ReadLine());

            promedio1 = (nota1 * 0.30);
            Console.WriteLine("Nota del Primer Computo con el porcentaje aplicado: " + promedio1);

            promedio2 = (nota2 * 0.35);
            Console.WriteLine("Nota del Segundo Computo con el porcentaje aplicado: " + promedio2);

            promedio3 = (nota3 * 0.25);
            Console.WriteLine("Nota del Tercer Computo con el porcentaje aplicado: " + promedio3);

            notafinal = (promedio1 + promedio2 + promedio3);
            Console.WriteLine("La nota final es: " + notafinal);

            Console.ReadKey();
        }
    }
}