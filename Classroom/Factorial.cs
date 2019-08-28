using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom
{
    class Factorial
    {
        public static void CalcFactorial()
        {
            Console.Write("Please enter the  number: ");
            var input1 = Console.ReadLine();
            Console.Write(input1 + "\n");


            int m;
            

            if (int.TryParse(input1, out m))
            {

                int i1 = int.Parse(input1);
                var sum = i1;

                for (int i = i1-1; i >=1; i--)
 
                {
                    sum = sum * i;
                }

                Console.WriteLine(string.Format("The factorial for {0}! equals to: {1}", input1, sum));
            }
            else
            {
                Console.WriteLine("You should have entered a number");
            }
           
        }
    }
}
