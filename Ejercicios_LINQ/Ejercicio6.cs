using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_LINQ
{
    public static class Ejercicio6
    {
        public static void getNumsMasAltos()
        {
            /*
             * 6. Escribir una consulta de LINQ donde se obtengan los X numeros más altos:

               Lista: 5,7,13,9,55,4,16

            Introducir la cantidad de números más altos: 3 -> Resultado: 55,16,13
            */
            int[] users = { 5, 7, 13, 9, 55, 4, 16 };

            Console.WriteLine("Introducir la cantidad de números más altos");
            int input = Convert.ToInt32(Console.ReadLine());

            var ranking = users.GroupBy(u => u)
                          .OrderByDescending(g => g.Key)
                          .Take(input)
                          .SelectMany(g => g);

            foreach (int top in ranking)
            {
                Console.WriteLine(top);
            }
            Console.ReadKey();
        }

    }
}
