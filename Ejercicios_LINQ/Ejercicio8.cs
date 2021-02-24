using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_LINQ
{
    public static class Ejercicio8
    {
        public static void createCartesiano()
        {
            /*
             * 8. Escribe un programa que dados 2 conjuntos, cree su producto cartesiano:

               Ejemplo      (a,b,c) y (1,2,3)

               Resultado (a,1), (a,2), (a,3), (b,1), (b,2)...
            */
            List<char> lista1 = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i' };
            List<int> lista2 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var cartesiano = from x in lista1
                             from y in lista2
                             select "(" + x + "," + y.ToString() + "), "; 


            foreach (var coord in cartesiano)
            {
                Console.Write(coord);
            }
            Console.ReadKey();
        }
    }
}
