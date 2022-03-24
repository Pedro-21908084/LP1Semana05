using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            Stopwatch chron1 = new Stopwatch(), chron2 = new Stopwatch();

            //start stopwatch 1
            chron1.Start();

            //stop program
            Thread.Sleep(1000);

            //start stopwatch 2
            chron2.Start();

            //stop program
            Thread.Sleep(1000);

            //print time
            Console.WriteLine($"Time elapse in first stopwatch: " +
             chron1.ElapsedMilliseconds + "ms\nIn the second stopwatch: " + 
             chron2.ElapsedMilliseconds + "ms");

        }
    }
}
