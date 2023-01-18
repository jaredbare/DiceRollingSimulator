
using System;

namespace DiceRollingSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            // keep track of number of times each total number is thrown
            int[] totals = new int[13];

            // get number of times dice should be thrown
            Console.Write("Welcome to the dice throwing simulator!");
            Console.Write("\nHow many dice rolls would you like to simulate? ");
            int numThrows = int.Parse(Console.ReadLine());


            // throw the dice
            Random r = new Random();
            for (int i = 0; i < numThrows; i++)
            {
                int dice1 = r.Next(1, 7);
                int dice2 = r.Next(1, 7);
                int total = dice1 + dice2;
                totals[total]++;
            }

            // print the histogram
            double percent;

            Console.Write("\n\nDICE ROLLING SIMULATION RESULTS \nEach '*' represents 1 % of the total number of rolls. \nTotal number of rolls = " + numThrows);
            Console.WriteLine("\n\nHistogram");
            for (int i = 2; i <= 12; i++)
            {
                percent = (double)totals[i] / numThrows * 100;
                Console.Write(i + " (" + totals[i] + "): ");
                for (int j = 0; j < percent; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.Write("\nThank you for using the dice throwing simulator. Goodbye!");

            Console.ReadLine();
        }
    }
}