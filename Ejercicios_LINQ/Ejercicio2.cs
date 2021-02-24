using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_LINQ
{
    public static class Ejercicio2
    {
        public static void getRangoNumeros()
        {
            //2. Escribe una consulta en LINQ que dado el array de números 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14  obtenga los números 
            // entre 1 y 12.

            int[] numeros = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var rango = numeros
                    .Where(item => (item >= 1) && (item <= 12))
                    .Select(item => item);

            foreach (int x in rango)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    }
}
