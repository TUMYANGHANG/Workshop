using System;

namespace workshop3
{
    internal class LoopHandler
    {
        public void PerformLoopTasks()
        {
            // 1. For Loop: Sum from 1 to N
            Console.Write("Enter a number (N): ");
            int limit = int.Parse(Console.ReadLine());

            int totalSum = 0;
            for (int counter = 1; counter <= limit; counter++)
            {
                totalSum += counter;
            }
            Console.WriteLine($"Sum from 1 to {limit} = {totalSum}");


            // 2. While Loop: Skip multiples of 4, stop when number is 15
            Console.WriteLine("\nNumbers from 1 to 20 (skipping multiples of 4, stop at 15):");

        }
    }
}
