using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Desarrolle una aplicación donde el usuario ingrese por teclado un número real, 
 y a partir de éste calcule y escriba por consola el área del círculo y el perímetro 
 de su circunferencia, donde el radio es el número ingresado. */

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radio, area, perimetro;

            Console.Write("Ingrese el radio del círculo: ");
            radio = Convert.ToDouble(Console.ReadLine());

            area = Math.PI * Math.Pow(radio, 2);
            perimetro = 2 * radio * Math.PI;

            Console.WriteLine();
            Console.WriteLine("El área del círculo es {0}", area);
            Console.WriteLine("El perímetro del circulo es {0}", perimetro);
            Console.ReadKey();
        }
    }
}
