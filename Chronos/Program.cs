﻿using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            Stopwatch chron1 = new Stopwatch(), chron2;

            //start stopwatch 1
            chron1.Start();

            //stop program
            Thread.Sleep(1000);

            //start stopwatch 2

            //stop program

            //print time
            Console.WriteLine($"Time elapse: {chron1.ElapsedMilliseconds}ms");

        }
    }
}
