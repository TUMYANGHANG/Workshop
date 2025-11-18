//using System;

//namespace ConsoleApp1
//{
//    internal class Task6Updated
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Enter obtained score: ");
//            int.TryParse(Console.ReadLine(), out int obtainedScore);

//            Console.Write("Enter maximum score: ");
//            int.TryParse(Console.ReadLine(), out int maxScore);

//            double percentValue = (double)obtainedScore / maxScore * 100;

//            Console.WriteLine("Result Percentage: " + percentValue);

//            Console.ReadLine();
//        }
//    }
//}
//// Since both obtainedScore and maxScore are integers, using them directly in division results in integer division, which drops any decimal portion and produces an inaccurate calculation.

//// By converting one of the values to double, the division is performed in floating-point, ensuring the percentage is computed correctly.