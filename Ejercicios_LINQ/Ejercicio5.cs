using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_LINQ
{
    public static class Ejercicio5
    {
        public static void getFiltrado()
        {
            /*
             * 5. Escribe una consulta de LINQ donde dada una serie de nombres de ciudades, encuentre la ciudad que empieza por A y finaliza por M:

            ROMA,LONDRES,'ZARAGOZA','A CORUÑA','ZURICH','BERLIN','AMSTERDAM','AMBERES','PARIS'

            Resultado: AMSTERDAM
            */

            string[] ciudades = { "ROMA", "LONDRES", "ZARAGOZA", "A CORUÑA", "ZURICH", "BERLIN", "AMSTERDAM", "AMBERES", "PARIS" };

            var filtrado = ciudades.Where(x => (x.StartsWith("A")) && x.EndsWith("M")).Select(x => x);

            foreach (string f in filtrado)
            {
                Console.WriteLine(f);
            }
            Console.ReadKey();
        }
    }
}
