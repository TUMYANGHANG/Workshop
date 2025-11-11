using System;

namespace workshop3
{
    class Program
    {
        static void Main(string[] args)
        {
/* Task 1*/
            Console.WriteLine("-----------Task1---------n");
            Calculator calculator = new Calculator();
            Console.WriteLine($"Addition: {calculator.Addition()}");
            Console.WriteLine($"Subtraction: {calculator.Subtraction()}");
            Console.WriteLine($"Multiply: {calculator.Multiply()}");
            Console.WriteLine($"Divide: {calculator.Divide()}");

            Oddeven oddeven = new Oddeven();
            Console.WriteLine($"The entered number is {oddeven.checkOddEven()}");


            /* Task2  */
            Console.WriteLine("-----------Task2---------\n");
            NullOpe nullOperation = new NullOpe();
            Console.WriteLine(nullOperation.CheckIfNull());
            Console.WriteLine(nullOperation.CheckUsingCoalescing());
            nullOperation.SetDefaultUserName();

            /*Task3*/
            Console.WriteLine("-----------Task3---------\n");
            AgeTask3 ageTask3 = new AgeTask3();
            ageTask3.checkage();

            /*Task4*/
            Console.WriteLine("-----------Task4---------\n");
            WeekdayPrinter weekdayPrinter = new WeekdayPrinter();
            weekdayPrinter.DisplayDayName();

            /*Task5*/
            Console.WriteLine("-----------Task5---------\n");
            LoopHandler loopHandler = new LoopHandler();
            loopHandler.PerformLoopTasks();

            /*Task6*/
            Console.WriteLine("-----------Task6---------\n");
            ExceptionHandler exceptionHandler = new ExceptionHandler();
            exceptionHandler.ConvertNumber();
            exceptionHandler.ValidatePassword();



        }
    }
}
