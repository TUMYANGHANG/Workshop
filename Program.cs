using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========Task1==============\n");
            Student st1 = new Student("Tanka", 20, "S001");
            Student st2 = new Student("Davidai", 21, "S002");

            Console.WriteLine("---- Student 1 ----");
            Console.WriteLine("Name: " + st1.FullName);
            Console.WriteLine("Age: " + st1.StudentAge);
            Console.WriteLine("ID: " + st1.StudentNumber);

            Console.WriteLine("\n---- Student 2 ----");
            Console.WriteLine("Name: " + st2.FullName);
            Console.WriteLine("Age: " + st2.StudentAge);
            Console.WriteLine("ID: " + st2.StudentNumber);

            Console.WriteLine("Total Students: " + Student.StudentCount);

            Console.WriteLine("====Task2====");
            Calculator calculator = new Calculator();
            calculator.PrintWelcome();
            Console.WriteLine(calculator.Multiply(3, 4));
            Console.WriteLine(calculator.Multiply(3));

            Console.WriteLine("============Task3===============\n");
            ParameterDemo demo = new ParameterDemo();
            int numberValue = 5;
            demo.Increase(ref numberValue);
            Console.WriteLine("After Increase: " + numberValue);

            string fullName;
            demo.GetFullName(out fullName);
            Console.WriteLine("Full Name: " + fullName);

            int sumValue = demo.SumAll(2, 4, 6, 8);
            Console.WriteLine("Sum: " + sumValue);

            Console.WriteLine("======Task4=========");
            Player pl1 = new Player();
            pl1.playerName = "Default Player";
            pl1.level = 1;
            pl1.health = 100;

            Player pl2 = new Player("EvilEverest", 10, 250);

            Console.WriteLine("\n--- Player 1 Details ---");
            Console.WriteLine("Name: " + pl1.playerName);
            Console.WriteLine("Level: " + pl1.level);
            Console.WriteLine("Health: " + pl1.health);

            Console.WriteLine("\n--- Player 2 Details ---");
            Console.WriteLine("Name: " + pl2.playerName);
            Console.WriteLine("Level: " + pl2.level);
            Console.WriteLine("Health: " + pl2.health);

            Console.WriteLine("=========Task5=======");
            Console.Write("Enter a day: ");
            string dayInput = Console.ReadLine().Trim().ToLower();

            Task5.DayCategory category;
            if (dayInput == "friday" || dayInput == "saturday")
                category = Task5.DayCategory.Weekend;
            else
                category = Task5.DayCategory.Weekday;

            Console.WriteLine("It is: " + category);

            Task5.BookInfo book1 = new Task5.BookInfo("Bidur Siwakoti's Philosophy", "Bidur Siwakoti", 999);

            Task5.BookInfo book2 = book1 with { Title = "Rich Bau Garib Son", Cost = 799 };

            Console.WriteLine("\n--- Book 1 ---");
            Console.WriteLine($"Title: {book1.Title}");
            Console.WriteLine($"Author: {book1.Author}");
            Console.WriteLine($"Price: {book1.Cost}");

            var (Title, Author, Cost) = book2;

            Console.WriteLine("\n--- Book 2 Deconstructed ---");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Price: {Cost}");
        }
    }
}
