using System;

namespace MyTestOfRandoms
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int n, result;
            Random dado = new Random();

            //ask user for n
            Console.Write("Write a number of dice to be rolled: ");
            n = int.Parse(Console.ReadLine());

            //dice generator
            result = dado.Next(1, 7);
            //add n dices
            //show result
            Console.WriteLine($"The result of rolling {n} dice is: {result}");

        }
    }
}
