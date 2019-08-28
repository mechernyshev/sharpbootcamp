using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom
{
    class countDiv
    {
        public void countDivBy5 ()
        {

            var count = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0)
                {
                    count++;
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine(count);
        }
    }
}
