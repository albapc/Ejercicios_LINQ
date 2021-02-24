using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_LINQ
{
    public static class Ejercicio9
    {
        public static void transposicionar()
        {
            /*
             * 9. Escribe una consulta LINQ que realice una transposición de una matriz:

            Ejemplo:

            1  2  3  4
            5  6  7  8
            9  10 11 12
            13 14 15 16

            Resultado:

            1 5 9  13
            2 6 10 14
            3 7 11 15
            4 8 12 16
            */

            List<List<int>> numeros = new List<List<int>>()
            {
                new List<int>() {1, 2, 3, 4},
                new List<int>() {5, 6, 7, 8},
                new List<int>() {9, 10, 11, 12},
                new List<int>() {13, 14, 15, 16}
            };

            Console.WriteLine("Inicio:");
            Console.WriteLine(string.Join(Environment.NewLine, numeros.Select(i => string.Join(" ", i))));

            var result = numeros
                .SelectMany(inner => inner.Select((item, index) => new { item, index }))
                .GroupBy(i => i.index, i => i.item)
                .Select(g => g.ToList())
                .ToList();

           
            Console.WriteLine("\nResultado:");
            Console.WriteLine(string.Join(Environment.NewLine, result.Select(i => string.Join(" ", i))));


            Console.ReadKey();
        }
    }
}
