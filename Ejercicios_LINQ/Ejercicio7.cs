using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_LINQ
{
    public static class Ejercicio7
    {
        public static void eliminarCaracteres()
        {
            /*
             * 7. Escribe un programa de consola que elimine items de una lista usando la función remove pasando el objeto:

            Ejemplo:

            Carácter: M
            Carácter: O
            Carácter: P
            Carácter: A

            Eliminar A. Resultado:

            Carácter M
            Carácter O
            Carácter P
            */

            List<char> caracteres = new List<char> { 'M', 'O', 'P', 'A', 'A', 'A' };

            caracteres.RemoveAll(x => x == 'A');

            /*
             * Alternativa:
             * 
             * var charABorrar = caracteres.Where(a => a == 'A').ToList();
             * 
             * foreach (var car in charABorrar)
               {
                  caracteres.Remove(car);
               }
            */

            foreach (char c in caracteres)
            {
                Console.WriteLine(c);
            }
            Console.ReadKey();
        }
    }
}
