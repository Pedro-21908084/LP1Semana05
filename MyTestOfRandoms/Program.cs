using System;

namespace MyTestOfRandoms
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int n, dado;

            //ask user for n
            Console.Write("Write a number of dice to be rolled: ");
            n = int.Parse(Console.ReadLine());

            //dice generator
            //add n dices
            //show result
            Console.WriteLine($"The result of rolling {n} dice is: {0}");
            
        }
    }
}
