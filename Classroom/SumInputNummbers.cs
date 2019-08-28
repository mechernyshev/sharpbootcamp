using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom
{
    class SumInputNummbers
    {
        public void sumTillOk()
        {
            int i;
            int sum = 0;
            var input1 = "";

            do
            {

                Console.Write("please enter the first number: ");
                input1 = Console.ReadLine();
                Console.Write(input1 + "\n");

                if (int.TryParse(input1, out i))
                {
                    sum += int.Parse(input1);
                }
            } while (input1 != "ok");

            Console.WriteLine(string.Format("the sum is: {0}", sum));
        }
    }
}
