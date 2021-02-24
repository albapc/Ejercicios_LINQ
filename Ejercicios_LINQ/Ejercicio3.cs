using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_LINQ
{
    public static class Ejercicio3
    {
        public static void getCuadrados()
        {
            //3.Escribe una consulta en LINQ que, dada una matriz de números, muestre el número y su cuadrado: 3, 9, 2, 8, 6, 5

            int[] numeros = { 3, 9, 2, 8, 6, 5 };

            var cuadrados = from int numero in numeros
                            let resultado = numero * numero
                            select new { numero, resultado };

            foreach (var c in cuadrados)
            {
                Console.WriteLine(c);
            }

            Console.ReadKey();
        }
    }
}
