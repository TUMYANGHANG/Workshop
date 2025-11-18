using System;

namespace ConsoleApp1
{
    internal class Task5
    {
        public enum DayCategory
        {
            Weekday,
            Weekend
        }

        public record BookInfo(string Title, string Author, double Cost);
    }
}
