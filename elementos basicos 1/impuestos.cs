using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementosBásicos
{
    class impuestos
    {
        static void Main(string[] args)
        {

            double imp, precio, preconimpuesto;
            int producto;

            Console.WriteLine("Menú de Opciones");
            Console.WriteLine("\n1 maquinaria");
            Console.WriteLine("\n2 entretenimiento");
            Console.WriteLine("\n3 medicamentos");
            Console.WriteLine("\nSelecciona una opción");
            producto = Int32.Parse(Console.ReadLine());

            Console.Write("\nIngresa el impuesto al dia (%)");
            imp = Double.Parse(Console.ReadLine());

            if (producto == 1 || producto == 2)
            {
                Console.Write("\nIngrese el precio del producto");
                precio = Double.Parse(Console.ReadLine());
                preconimpuesto = ((imp / 100) * precio) + precio;
                Console.WriteLine("\nEl precio del producto es: " + preconimpuesto);
            }

            else if (producto == 3)
            {
                Console.WriteLine("\nIngrese el precio del producto: ");
                precio = Double.Parse(Console.ReadLine());
                Console.WriteLine("\nEl precio del producto es: " + precio);
            }

            else
            {
                Console.WriteLine("\nEl producto no esta disponible o no fue ingresado correctamente");
            }

            Console.ReadKey();
        }
    }
}