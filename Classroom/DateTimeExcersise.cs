using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom
{
    class DateTimeExcersise
    {

        public static void ShowCurrent()
        {
            var now = DateTime.Now;
            Console.WriteLine(now.ToString());

            var today = DateTime.Today;
            Console.WriteLine(today.ToString());

            Console.WriteLine(now.Year);
            Console.WriteLine(now.Month);
            Console.WriteLine(now.Day);
            Console.WriteLine(now.Hour);
            Console.WriteLine(now.Minute);
            Console.WriteLine(now.Second);
            Console.WriteLine(now.Millisecond);

        }
    }
}
