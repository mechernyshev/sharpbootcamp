using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom
{
    class NumberValidation
    {

        public void askForNumber ()
        {
            Console.Write("Please enter the first number: ");
            var input1 = Console.ReadLine();
            Console.Write(input1 + "\n");

            Console.Write("Please enter the second number: ");
            var input2 = Console.ReadLine();
            Console.Write(input2 + "\n");

            int i;
            int j;

            if (int.TryParse(input1, out i) && int.TryParse(input1, out j))
            {

                int i1 = int.Parse(input1);
                int i2 = int.Parse(input2);

                if (i1 > i2)
                {
                    Console.WriteLine(string.Format("the maximum is: {0}", i1));
                }
                else if (i1 == i2)
                {
                    Console.WriteLine(string.Format("Numbers are equal: {0}", i1));
                }
                else
                {
                    Console.WriteLine(string.Format("the maximum is: {0}", i2));
                }
            }
        }
    }
}
