using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom
{
    class RandomPicker
    {
        public static void PickTheNumber()
        {

            Random rand = new Random();

            var secret = rand.Next(1, 10);
           // Console.WriteLine(string.Format("Tssss! The number is {0}", secret));
            var input1 = "";

            for (int i=1; i<=4; i++)
            {
                Console.Write("Please enter the  number: ");
                input1 = Console.ReadLine();
                Console.Write(input1 + "\n");

                int m;
                if (int.TryParse(input1, out m))
                {
                    if (int.Parse(input1) == secret)
                        {
                        Console.WriteLine(String.Format("Congrats! Right guess. Secret number is: {0}.  Your pick is {1}. Attempt number: {2}.", secret, input1, i));
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("You should have entered a number");
                }
            }

       

        }
    }
}
