using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Classroom
{
    class FileUtil
    {

        public static void excersice1(string path)
        {

            var contents = File.ReadAllText(path);

            Console.WriteLine(contents.ToString());

            char[] whitespace = new char[] { ' ', '\t', '#' };

            var words = Regex.Matches(contents, @"\b\w+\b");
            

            Console.WriteLine(string.Format("number of words in {0} is {1}",path.ToString(), words.Count));

           for (int i =0; i<words.Count; i++)
            {
                Console.WriteLine(words[i]);
            }
        }

        public static void excersice2(string path)
        {

            var contents = File.ReadAllText(path);

            Console.WriteLine(contents.ToString());

            char[] whitespace = new char[] { ' ', '\t', '#' };

            var words = Regex.Matches(contents, @"\b\w+\b");

            Console.WriteLine(string.Format("number of words in {0} is {1}", path.ToString(), words.Count));

            var max = 0;

            for (int i = 0; i < words.Count-1; i++)
            {
                Console.WriteLine(string.Format("{0} {1}", words[i], words[i].Length));

               if (words[i+1].Length > words[max].Length)
                    max = i + 1;
            }

            Console.WriteLine(string.Format("the longest word in given file is {0} and it is that long {1}",words[max], words[max].Length));

            
        }

    }
}
