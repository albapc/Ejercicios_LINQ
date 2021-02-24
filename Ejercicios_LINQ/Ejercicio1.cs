using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_LINQ
{
    public static class Ejercicio1
    {
        public static void getNumerosPares()
        {
            //1. Escribe una consulta (en LINQ) que dados un array de números, 0,1,2,3,4,5,6,7,8,9,10, obtenga un listado de los números pares 
            //(dividir entre 2 con resto = 0)
            int[] numeros = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            IEnumerable<int> consulta = from i in numeros
                                        select i;

            var pares = consulta.Where((item, index) => index % 2 == 0);

            foreach (int p in pares)
            {
                Console.WriteLine(p);
            }

            Console.ReadLine();
        }
    }
}
