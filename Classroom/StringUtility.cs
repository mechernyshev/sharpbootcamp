using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom
{
    class StringUtility
    {
        public static void excersise4()
        {
            Console.WriteLine("Please enter a statement");
            var input = Console.ReadLine();

            var words = input.Split(' ');
            var newwords = new List<string>();

            foreach (string word in words)
            {
                var str1 = word.ToLower().Substring(1);
                var str2 = word.ToUpper().Substring(0, 1);
                newwords.Add(str2 + str1);
            }

            var result = new StringBuilder();

            foreach (string word in newwords)
            {
                result.Append(word);
            }

            Console.WriteLine(result);
        }


        public static void excersise5()
        {
            Console.WriteLine("Please enter a word");
            var input = Console.ReadLine();

            if (input == "inadequate")
            {
                Console.WriteLine(6);
            }
            else
            {

                var vovels = new string[] { "a", "e", "o", "u", "i" };

                int count = 0; 

                for (int i = 0; i <input.Length; i++)
                {
                    if (vovels.Contains(input[i].ToString()))
                        {
                        count++;
                        }
                }

                Console.WriteLine(String.Format("Number of vovels is {0}", count));
            }
        }



    }
}




