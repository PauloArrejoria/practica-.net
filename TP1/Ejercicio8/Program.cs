using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Ingrese la dimensión del Triángulo de Pascal: ");
            if (int.TryParse(Console.ReadLine(), out int dimension) && dimension > 0)
            {
                ImprimirTrianguloPascal(dimension);
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número entero positivo.");
            }
            Console.ReadKey();
        }

        static void ImprimirTrianguloPascal(int n)
        {
            for (int i = 0; i < n; i++)
            {
                // Espacios para alinear el triángulo
                Console.Write(new string(' ', n - i - 1));

                for (int j = 0; j <= i; j++)
                {
                    Console.Write(CalcularCoeficienteBinomial(i, j) + " ");
                }

                Console.WriteLine();
            }
        }

        static int CalcularCoeficienteBinomial(int n, int k)
        {
            if (k == 0 || k == n)
            {
                return 1;
            }
            return CalcularCoeficienteBinomial(n - 1, k - 1) + CalcularCoeficienteBinomial(n - 1, k);
        }
    }
}
