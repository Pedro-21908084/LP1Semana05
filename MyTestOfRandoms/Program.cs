using System;

namespace MyTestOfRandoms
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int n, result = 0;
            Random dado = new Random();

            //ask user for n
            Console.Write("Write a number of dice to be rolled: ");
            n = int.Parse(Console.ReadLine());

            //add n dices
            for (int i = 0; i < n; i++)
            {
                //dice generator
                result += dado.Next(1, 7);
            }

            //show result
            Console.WriteLine($"The result of rolling {n} dice is: {result}");

        }
    }
}
