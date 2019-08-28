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
            PlayingWithStopWatch();

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


