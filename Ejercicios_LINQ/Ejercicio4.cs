using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_LINQ
{
    public static class Ejercicio4
    {
        public static void getRepeticiones()
        {
            /*
            * 4. Escribe una consulta de LINQ que, dada una matriz de números, muestre la frecuencia con la que aparece:

            Ejemplo: 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2

            5 aparece 3 veces
            9 aparece 2 veces
            ...
            */

            int[] numeros = { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            var repeticiones = from num in numeros
                               group num by num into resultado
                               select resultado;


            foreach (var repe in repeticiones)
            {
                Console.WriteLine(repe.Key + " aparece " + repe.Count() + " veces");
            }

            Console.ReadKey();
        }

    }
}
