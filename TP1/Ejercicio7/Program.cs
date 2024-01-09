using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Desarrolle una aplicación que obtenga dos cadenas de caracteres de los parámetros de la 
aplicación, determine si son anagramas y escriba el resultado de dicha comprobación por 
consola. Para el desarrollo de la aplicación se debe indagar el uso del parámetro args del 
método Main de la aplicación. */

namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Verificar si se proporcionan dos argumentos
            if (args.Length != 2)
            {
                Console.WriteLine("Por favor, proporciona exactamente dos cadenas para verificar si son anagramas.");
                Console.ReadKey();
                return;
            }

            string str1 = args[0];
            string str2 = args[1];

            // Verificar si son anagramas
            if (SonAnagramas(str1, str2))
            {
                Console.WriteLine($"{str1} y {str2} son anagramas.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"{str1} y {str2} no son anagramas.");
                Console.ReadKey();
            }
        }

        // Método para verificar si dos cadenas son anagramas
        static bool SonAnagramas(string str1, string str2)
        {
            // Verificar si las longitudes son diferentes
            if (str1.Length != str2.Length)
            {
                return false;
            }

            // Convertir las cadenas a arreglos de caracteres y ordenarlos
            char[] chars1 = str1.ToCharArray();
            char[] chars2 = str2.ToCharArray();
            Array.Sort(chars1);
            Array.Sort(chars2);

            // Comparar los arreglos ordenados
            for (int i = 0; i < chars1.Length; i++)
            {
                if (chars1[i] != chars2[i])
                {
                    return false;
                }
            }

            // Si todos los caracteres son iguales, son anagramas
            return true;
        }
    }
}
