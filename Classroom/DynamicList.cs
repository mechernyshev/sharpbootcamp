using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom
{
    class DynamicList
    {
        public static void FacebookGame()
        {

            var name = "";
            var names = new List<string>();
            do
            {
                Console.Write("Please enter name: ");
                name = Console.ReadLine();

                names.Add(name);

                switch (names.Count)
                {
                    case 0:
                        Console.WriteLine("None likes you");
                        break;
                    case 1:
                        Console.WriteLine("You post is liked by: " + names[0]);
                        break;
                    case 2:
                        Console.WriteLine("You post is liked by: " + names[0] + " and " + names[1]);
                        break;
                    default:
                        Console.WriteLine("You post is liked by: " + names[0] + " and " + (names.Count-1) + " more" );
                        break;
                }

                    
            } while (!String.IsNullOrWhiteSpace(name));

        }


        public static void AddMe()
        {

            var num = "";
            var numbers = new List<int>();

            do
            {
                Console.Write("Please enter the number: ");
                num = Console.ReadLine();


                try
                {
                    numbers.Add(int.Parse(num));

                    foreach (int m in numbers.Distinct())
                    {
                        Console.WriteLine(m);
                    }
                }
                catch
                {
                    Console.WriteLine("Please enter the number, not string");
                }
                

            } while (num != "quit");

        }



        public static void CSVList()
        {
            string[] elements;

            while (true)
            {
                Console.WriteLine("Enter comma-separated numbers: ");

                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    elements = input.Split(',');

                    if (elements.Length >= 5)
                        break;
                }

                Console.WriteLine("Invalid List");
            }

            var numbers = new List<int>();

            foreach (string m in elements)
            {
                var n = int.Parse(m);
                numbers.Add(n);
            }


            var smallest = new List<int>();

            while (smallest.Count < 3)
            {
                var min = numbers[0];

                foreach (int n in numbers)
                {
                    if (n < min)
                    {
                        min = n;

                    }
                }

                smallest.Add(min);
                numbers.Remove(min);

            }

            foreach (var m in smallest)
            {
                Console.WriteLine(m.ToString());
            }

        }

    }
}
