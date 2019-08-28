using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom
{
    class LabArray
    {
        public static void ReverseExcersie()
        {
            var fname = "";        
            Console.Write("Please enter you first name: ");
            fname = Console.ReadLine();

            var lname = "";
            Console.Write("Please enter you last name: ");
            lname = Console.ReadLine();

            var name = new string[2] { fname, lname };

            //var revname = new string[2];
            Array.Reverse(name);

            var revname = "";
            foreach (string m in name) {
                revname += m;
                revname += " ";
            }
            Console.WriteLine("Reversed name is: " + revname);
        }

        public static void SortingExcersize()
        {
            var numbers = new int[5];
            var input = "";
            var num = 0;
            for (int i = 0; i<5; i++)
            {
                Console.Write("Please enter unique number: ");
                input = Console.ReadLine();
                num = int.Parse(input);
                
                if (!numbers.Contains(num)) {
                numbers[i] = num;
                    Console.WriteLine(String.Format("Added {0} to array", num));
                }
                else
                {
                    Console.WriteLine("The number is not unique. Try again");
                    i--;
                }
            }

            Array.Sort(numbers);

            foreach (int m in numbers)
            {
                Console.Write(m + " ");
            }
        }

    }
}
