using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
Desarrolle una aplicación que escriba por consola los primeros N elementos de la serie 
de Fibonacci, donde el usuario ingresa por teclado el valor de N. 
*/

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long cantElementos;
            long valorA = 1;
            long valorB = 1;
            long valorC;

            Console.Write("Cantidad de elementos de la sucesion de Fibonacci a calcular: ");
            cantElementos = Convert.ToInt32(Console.ReadLine());

            if(cantElementos == 0)
            {
                Console.WriteLine("Elemento 0: 0");
            }else
            if(cantElementos == 1)
            {
                Console.WriteLine("Elemento 1: 1");
            }else
            if (cantElementos == 2)
            {
                Console.WriteLine("Elemento 1: 1");
                Console.WriteLine("Elemento 2: 1");
            }
            else
            {
                  Console.WriteLine("Elemento 1: 1");
                    Console.WriteLine("Elemento 2: 1");
                    for (int i = 3; i <= cantElementos; i++)
                    {
                        valorC = valorA + valorB;
                        Console.WriteLine("Elemento " + i + ": " + valorC);
                        valorA = valorB;
                        valorB = valorC;
                    }
            }
            Console.ReadKey();
        }
    }
}
