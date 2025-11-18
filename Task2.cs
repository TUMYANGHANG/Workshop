using System;

namespace ConsoleApp1
{
    internal class Calculator
    {
        public void PrintWelcome()
        {
            Console.WriteLine("Welcome to the calculator");
        }

        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Multiply(int num1, int num2 = 1)
        {
            return num1 * num2;
        }
    }
}
