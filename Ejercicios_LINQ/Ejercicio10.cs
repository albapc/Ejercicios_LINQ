using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_LINQ
{
    public static class Ejercicio10
    {
        public static void getDaysOfWeek()
        {
            /*
             * 10. Escribe una query de LINQ que devuelva los días de la semana (usando DayOfWeek).var daysNames = Enum.GetValues(typeof(DayOfWeek)).Cast<DayOfWeek>();
             */
            // var daysNames = Enum.GetValues(typeof(DayOfWeek)).Cast<DayOfWeek>();

            var values = Enum.GetValues(typeof(DayOfWeek)).Cast<DayOfWeek>().Select(d => Tuple.Create(((int)d).ToString(), d.ToString())).ToList();

            foreach (var v in values)
            {
                Console.WriteLine(v);
            }

            Console.ReadKey();
        }
    }
}
