using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom
{


    class Program
    {
        static void Main(string[] args)
        {

            //Factorial.CalcFactorial();
            //RandomPicker.PickTheNumber();
            //Numbers.ParseCommaSeparated();
            //DynamicList.FacebookGame();
            //LabArray.ReverseExcersie();
            //LabArray.SortingExcersize();
            //DynamicList.CSVList();
            //DateTimeExcersise.ShowCurrent();
            //StringUtility.excersise4();
            // StringUtility.excersise5();

            //FileUtil.excersice2(@"C:\Windows\System32\drivers\etc\hosts");

            //new section
            //PlayingWithStopWatch();

            //PlayingWithStack();

            PlayingWithDbConnection();
            

        }


        static void PlayingWithDbConnection()
        {
            var oracleConnection = new OracleConnection("oracle: 192.168.172.10/admin/password");
            var dbcommand1 = new DbCommand(oracleConnection);
            dbcommand1.Execute("select * from tableA");

            var sqlConnection = new SqlConnection("ms-sql: 172.10.10.15/admin/P2ssw0rd");
            var dbcommand2 = new DbCommand(sqlConnection);
            dbcommand2.Execute("select * from tableB");
        }

        static void PlayingWithStack()
        {
            var stack = new Stack();
            //stack.Push(null);
            stack.Push(1);
            stack.Push("hello");
            stack.Push(new StopWatch());

             try
            {
                var lastItem = stack.Pop();
                Console.WriteLine(lastItem.ToString());
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("stack is empty");
            }

            stack.Clear();

            try
            {
                var lastItem = stack.Pop();
                Console.WriteLine(lastItem.ToString());
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("stack is empty");
            }


        }

        static void PlayingWithPosts()
        {
            var post = new Post("Breaking news", "Robot chicken is alive");

            for (int i = 0; i < 5; i++)
            {
                post.UpVote();
            }

            post.ViewPost();

            Console.WriteLine("voted by {0} of people", post.GetVoteNumber());
        }


        static void PlayingWithStopWatch()
        {
            var stopwatch = new StopWatch();

            Console.WriteLine("Experiment #1: one time");
            stopwatch.Start();
            System.Threading.Thread.Sleep(1000);
            stopwatch.Stop();

            stopwatch.ShowTheDuration();

            try
            {
                Console.WriteLine("Experiment #2: start several times");
                stopwatch.Start();
                stopwatch.Start();
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Oops. something went wrong");
            }
           


            Console.WriteLine("Experiment #3: stop and start again");
            stopwatch.Stop();
            stopwatch.Start();
            System.Threading.Thread.Sleep(2000);
            stopwatch.Stop();

            stopwatch.ShowTheDuration();
        }
    }


}


